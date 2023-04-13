using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using CarFleetDomain.Models;

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
            _persons = new Persons();
            _users = new Users();
        }

        public CommandResponse<DataSet> GetEmployees()
        {
            var dataSet = new DataSet("Data");

            var cmdTextPerson = "SELECT * FROM Persons";
            var cmdPerson = new SqlCommand(cmdTextPerson);
            _context.GetTable<Persons>(cmdPerson, dataSet);

            var reply = new CommandResponse<DataSet>(dataSet);

            if (dataSet.Tables["Persons"].Rows.Count < 1) reply.Message = "No value returned";

            return reply;
        }

        public static CommandResponse<Persons> GetPersonWithRole(int personID, string connectionString)
        {
            var query = "SELECT p.ID, p.FirstName, p.LastName, p.PhoneNumber, p.Email, p.Disabled " +
                        "FROM Persons p  " +
                        "WHERE p.ID = @PersonID";

            using (var connection = new SqlConnection(Context.ConnectionString))
            {
                var adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@PersonID", personID);
                var dataset = new DataSet();
                //Persons.GetPersonsQuery(dataset);
                adapter.Fill(dataset);

                if (dataset.Tables[0].Rows.Count > 0)
                {
                    var row = dataset.Tables[0].Rows[0];
                    var person = new Persons
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        FirstName = row["FirstName"].ToString(),
                        LastName = row["LastName"].ToString(),
                        PhoneNumber = row["PhoneNumber"].ToString(),
                        Email = row["Email"].ToString(),
                        Disabled = (bool)row["Disabled"]
                    };
                    return new CommandResponse<Persons>(person) { Success = true };
                }

                return new CommandResponse<Persons>(null) { Success = false, Message = "Person not found" };
            }
        }

        public static CommandResponse<Users> GetUserRole(int personID, string connectionString)
        {
            Users users = null;
            var query = "SELECT u.RoleID " +
                        "FROM Users u  " +
                        "WHERE u.PersonID = @personID";

            using (var connection = new SqlConnection(Context.ConnectionString))
            {
                var adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@PersonID", personID);
                var dataset = new DataSet();

                adapter.Fill(dataset);

                if (dataset.Tables[0].Rows.Count > 0)
                {
                    var row = dataset.Tables[0].Rows[0];
                    users = new Users
                    {
                        RoleID = Convert.ToInt32(row["RoleID"])
                    };
                    return new CommandResponse<Users>(users) { Success = true };
                }

                return new CommandResponse<Users>(null) { Success = false, Message = "User not found" };
            }
        }

        public CommandResponse<Persons> DisablePerson(int id, bool disabled)
        {
            var response = new CommandResponse<Persons>(new Persons());
            // Create a row with the input data
            var dataSet = new DataSet();
            Persons.GetPersonsQuery(dataSet);
            var row = dataSet.Tables[nameof(Persons)]?.AsEnumerable()
                .FirstOrDefault(e => e.Field<int>(nameof(Persons.ID)) == id);
            if (disabled.Equals(true))
                row["Disabled"] = 0;
            else
                row["Disabled"] = 1;
            var dbResponse = Persons.DisablePerson(dataSet);
            // Check if the update was successful and show a message
            if (dbResponse.Success)
            {
                response.Success = true;
                response.Message = "Data was updated successfully!";
                return response;
            }

            // Check if the update was successful

            response.Success = false;
            response.Message = "Error while disabling employee: " + dbResponse.Message;
            return response;
        }

        public CommandResponse<Users> InsertOrUpdateUser(int personID, string userName, string passwordHash,
            int roleID)
        {
            var response = new CommandResponse<Users>(new Users());
            var dataSet = new DataSet();
            Users.GetUsersQuery(dataSet);
            var usersTable = dataSet.Tables[nameof(Users)];
            var userRow = usersTable.Select($"PersonID = {personID}").FirstOrDefault();
            if (userRow == null)
            {
                // Create a new user with the same email as the Person
                var newUserRow = usersTable.NewRow();
                newUserRow["UserName"] = userName;
                newUserRow["PasswordHash"] = passwordHash;
                newUserRow["PersonID"] = personID;
                newUserRow["RoleID"] = roleID;
                usersTable.Rows.Add(newUserRow);
                var usersResponse = Users.InsertUsersCommand(dataSet);
                if (!usersResponse.Success)
                {
                    response.Message = "Error creating user: " + usersResponse.Message;
                    response.Success = false;
                    return response;
                }

                response.Success = true;
                return response;
            }

            var userResponse = UpdateUser(userName, passwordHash, personID, roleID);
            if (userResponse.Success)
            {
                userResponse.Success = true;
                return userResponse;
            }

            userResponse.Success = false;
            userResponse.Message = "Error while updating User ";
            return userResponse;
        }

        public CommandResponse<Users> UpdateUser(string userName, string passwordHash, int personID, int roleID)
        {
            var response = new CommandResponse<Users>(new Users());
            //var validationResponse = RoleValidation(roleID);
            //if (!validationResponse.Success)
            //{
            //    response.Message = validationResponse.Message;
            //    return response;
            //}
            var dataSet = new DataSet();
            Users.GetUsersQuery(dataSet);
            var row = dataSet.Tables[nameof(Users)]?.AsEnumerable()
                .FirstOrDefault(e => e.Field<int>(nameof(Users.PersonID)) == personID);
            row["UserName"] = userName;
            row["PasswordHash"] = passwordHash;
            row["PersonID"] = personID;
            row["RoleID"] = roleID;
            var dbResponse = Users.UpdateUsersCommand(dataSet);
            if (dbResponse.Success)
            {
                response.Success = true;
                response.Message = "Data was updated succefully";
                return response;
            }

            response.Success = false;
            response.Message = "Error while updating user: " + dbResponse.Message;
            return response;
        }

        public CommandResponse<Persons> UpdateEmployee(int id, string firstName, string lastName, string phone,
            string email, bool disabled)
        {
            var response = new CommandResponse<Persons>(new Persons());


            // Create a row with the input data
            var dataSet = new DataSet();
            Persons.GetPersonsQuery(dataSet);
            var row = dataSet.Tables[nameof(Persons)]?.AsEnumerable()
                .FirstOrDefault(e => e.Field<int>(nameof(Persons.ID)) == id);
            row["FirstName"] = firstName;
            row["LastName"] = lastName;
            row["PhoneNumber"] = phone;
            row["Email"] = email;
            row["Disabled"] = disabled;
            //row["Disabled"] = 1;
            var dbResponse = Persons.UpdatedPersonsCommand(dataSet);

            // Check if the update was successful and show a message
            if (dbResponse.Success)
            {
                response.Success = true;
                response.Message = "Data was updated successfully!";
                return response;
            }

            // Check if the update was successful

            response.Success = false;
            response.Message = "Error while updating employee: " + dbResponse.Message;
            return response;
        }

        public CommandResponse<Persons> UniqueEmail(string email)
        {
            var response = new CommandResponse<Persons>(new Persons());

            if (_persons.IsEmailUnique(email))
            {
                response.Message = "Email is already in use";
                response.Success = false;
                return response;
            }

            response.Success = true;
            return response;
        }

        public CommandResponse<Persons> InsertNewEmployee(string firstName, string lastName, string phone, string email,
            int roleID, bool disabled)
        {
            var response = new CommandResponse<Persons>(new Persons());
            // Validate the employee data
            var validationEmail = UniqueEmail(email);
            if (!validationEmail.Success)
            {
                response.Message = validationEmail.Message;
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
            row["Disabled"] = disabled;

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
                    newUserRow["RoleID"] = roleID;
                    usersTable.Rows.Add(newUserRow);
                    var usersResponse = Users.InsertUsersCommand(dataSetUser);
                    if (!usersResponse.Success)
                    {
                        response.Message = "Error creating user: " + usersResponse.Message;
                        return response;
                    }

                    response.Success = true;
                    return response;
                }

                response.Message = "Error adding employee: " + dbResponse.Message;
                return response;
            }

            response.Success = true;
            return response;
        }
    }
}