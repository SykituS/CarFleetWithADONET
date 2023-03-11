using CarFleetDomain.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;

namespace CarFleetDomain.Functions
{
    public class LoginSystem
    {
        private readonly Context _context;
        public LoginSystem()
        {
            _context = Context.Create();
        }

        //public CommandResponse<Users> LoginUser(string username, string password)
        //{
        //    var reply = new CommandResponse<Users>(new Users());
        //    var passwordHash = PasswordHasher.EncodePassword(password);

        //    var cmdText = "SELECT TOP(1) * FROM Users WHERE @username = UserName AND @password = PasswordHash";
        //    //var cmdText = "SELECT TOP(1) * FROM Users WHERE @username = UserName AND @password = PasswordHash";
        //    var cmd = new SqlCommand(cmdText);

        //    cmd.Parameters.AddWithValue("username", username);
        //    cmd.Parameters.AddWithValue("password", passwordHash);

        //    var dataSet = new DataSet("Data");
        //    _context.GetTable<Users>(cmd, dataSet);


        //    var cmdTextPerson = "SELECT * FROM Persons";
        //    var cmdPerson = new SqlCommand(cmdTextPerson);
        //    _context.GetTable<Persons>(cmdPerson, dataSet);


        //    var parentColumn = dataSet.Tables["Persons"].Columns["ID"];
        //    var childColumn = dataSet.Tables["Users"].Columns["PersonID"];

        //    var relation = new DataRelation("UserPerson", parentColumn, childColumn);
        //    dataSet.Relations.Add(relation);

        //    var data = dataSet.Tables["Users"].Rows[0];
        //    reply.ReturnedValue.ID = (int)data["ID"];
        //    reply.ReturnedValue.UserName = (string)data["UserName"];


        //    return reply;
        //}

        public CommandResponse<DataSet> LoginUser(string username, string password)
        {
            var reply = new CommandResponse<DataSet>(new DataSet("Data"));
            var passwordHash = PasswordHasher.EncodePassword(password);

            var cmdText = "SELECT TOP(1) * FROM Users WHERE @username = UserName AND @password = PasswordHash";
            //var cmdText = "SELECT TOP(1) * FROM Users WHERE @username = UserName AND @password = PasswordHash";
            var cmd = new SqlCommand(cmdText);

            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", passwordHash);
            
            _context.GetTable<Users>(cmd, reply.ReturnedValue);


            var cmdTextPerson = "SELECT * FROM Persons";
            var cmdPerson = new SqlCommand(cmdTextPerson);
            _context.GetTable<Persons>(cmdPerson, reply.ReturnedValue);


            var parentColumn = reply.ReturnedValue.Tables["Persons"].Columns["ID"];
            var childColumn = reply.ReturnedValue.Tables["Users"].Columns["PersonID"];

            var relation = new DataRelation("UserPerson", parentColumn, childColumn);
            reply.ReturnedValue.Relations.Add(relation);

            var data = reply.ReturnedValue.Tables["Users"].Rows[0];

            return reply;
        }

        public void UpdateTest()
        {
            var dataSet = new DataSet();
            Persons.GetPersonsQuery(dataSet);

            var row = dataSet.Tables[nameof(Persons)]?.AsEnumerable()
                .FirstOrDefault(e => e.Field<int>(nameof(Persons.ID)) == 1);
            row[nameof(Persons.FirstName)] = "Janek";
            row[nameof(Persons.LastName)] = "Torowek";
            var response = Persons.UpdatedPersonsCommand(dataSet);
        }

        public void InsertTest()
        {
            var dataSet = new DataSet();
            Persons.GetPersonsQuery(dataSet);

            var row = dataSet.Tables[nameof(Persons)].NewRow();

            row[nameof(Persons.FirstName)] = "Januszek";
            row[nameof(Persons.LastName)] = "Kowalczyk";
            row[nameof(Persons.PhoneNumber)] = "123123123";
            row[nameof(Persons.Email)] = "januszek.kowalczyk@gmail.com";

            dataSet.Tables[nameof(Persons)].Rows.Add(row);

            Persons.InsertPersonsCommand(dataSet);
        }
    }
}
