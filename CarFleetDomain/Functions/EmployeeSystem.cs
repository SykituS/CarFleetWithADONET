using CarFleetDomain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CarFleetDomain.Functions
{
    public class EmployeeSystem
    {

        private readonly Context _context;
        private readonly Users _users;
        private readonly Persons _persons;
        public EmployeeSystem()
        {

            _context = Context.Create();
            _persons= new Persons();
            _users= new Users();
        }
        private bool ValidateEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        public CommandResponse<DataSet> GetEmployees()
        {
            var dataSet = new DataSet("Data");

            var cmdTextPerson = "SELECT * FROM Persons";
            var cmdPerson = new SqlCommand(cmdTextPerson);
            _context.GetTable<Persons>(cmdPerson, dataSet);

            var reply = new CommandResponse<DataSet>(dataSet);

            if (dataSet.Tables["Persons"].Rows.Count < 1)
            {
                reply.Message = "No value returned";
            }

            return reply;
        }

        public CommandResponse<Persons> InsertNewEmployee(string firstName, string lastName, string phone, string email)
        {
            var response = new CommandResponse<Persons>(new Persons());


            // Check that all input fields are filled in
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(email))
            {
                response.Message = "Please fill in all fields";
                return response;
            }

            // Check that first and last name do not contain numbers
            if (firstName.Any(char.IsDigit) || lastName.Any(char.IsDigit))
            {
                response.Message = "First and last name cannot contain numbers";
                return response;
            }

            // Check that phone number has 9 digits and all of them are numbers
            if (phone.Length != 9 || !phone.All(char.IsDigit))
            {
                response.Message = "Phone number must have 9 digits and contain only numbers";
                return response;
            }

            // Check that email is in a valid format
            if (!ValidateEmail(email))
            {
                response.Message = "Email is not in a valid format";
                return response;
            }

            // Check that email is unique
            if (!_persons.IsEmailUnique(email))
            {
                response.Message = "Email is already in use";
                return response;
            }

            // Create a new row with the input data
            var dataSet = new DataSet();
            Persons.GetPersonsQuery(dataSet);
            var row = dataSet.Tables[nameof(Persons)].NewRow();
            row["ID"] = 0;
            row["FirstName"] = firstName;
            row["LastName"] = lastName;
            row["PhoneNumber"] = phone;
            row["Email"] = email;

            // Add the new row to the Persons table and update the database
            dataSet.Tables[nameof(Persons)].Rows.Add(row);
            var dbResponse = Persons.InsertPersonsCommand(dataSet);

            // Check if the update was successful and show a message
            if (dbResponse.Success)
            {
                // Get the new Person ID
                var personID = dataSet.Tables[nameof(Persons)].AsEnumerable().Last().ItemArray[0];
                var password = _users.GeneratePasswordHash(firstName, lastName, phone);

                // Check if the new Person ID exists in the Users table
                var dataSetUser = new DataSet();
                Users.GetUsersQuery(dataSetUser);
                var usersTable = dataSetUser.Tables[nameof(Users)];
                var userRow = usersTable.Select($"PersonID = {personID}").FirstOrDefault();
                if (userRow == null)
                {
                    // Create a new user with the same email as the Person
                    var newUserRow = usersTable.NewRow();
                    newUserRow["UserName"] = email;
                    newUserRow["PasswordHash"] = password;
                    newUserRow["PersonID"] = personID;
                    newUserRow["RoleID"] = 1;
                    usersTable.Rows.Add(newUserRow);
                    var usersResponse = Users.InsertUsersCommand(dataSetUser);
                    if (!usersResponse.Success)
                    {
                        response.Message = "Error creating user: " + usersResponse.Message;
                        return response;
                    }



                }
                else
                {
                    response.Message = "Error adding employee: " + dbResponse.Message;
                    return response;
                }
            }
            return response;


        }
       




    }
}
           



