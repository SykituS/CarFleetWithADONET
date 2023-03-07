using CarFleetDomain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFleetDomain.Functions
{
    public class EmployeeSystem
    {
        private readonly Context _context;
        public EmployeeSystem()
        {
            _context = Context.Create();
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
                reply.ReturnedString = "No value returned";
            }

            return reply;
        }
        public void AddPersonQuery(DataSet dataSet)
        {
            using (var connection = new SqlConnection(Context.ConnectionString)) {


                // Create a new SqlDataAdapter and update the database with the changes made to the DataSet
                var adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand("INSERT INTO Persons (FirstName, LastName, PhoneNumber, Email) VALUES (@firstName, @lastName, @phoneNumber, @email)");
                adapter.InsertCommand.Parameters.AddWithValue("@firstName", "FirstName");
                adapter.InsertCommand.Parameters.AddWithValue("@lastName", "LastName");
                adapter.InsertCommand.Parameters.AddWithValue("@phoneNumber", "PhoneNumber");
                adapter.InsertCommand.Parameters.AddWithValue("@email", "Email");

                var table = new DataTable();
                adapter.Fill(table);
                adapter.Update(table);


            } }
    }
    }
