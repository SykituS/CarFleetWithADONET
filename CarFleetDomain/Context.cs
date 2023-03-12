using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Security.Cryptography;
using CarFleetDomain.Functions;
using CarFleetDomain.Models;
using System.Reflection;

namespace CarFleetDomain
{
    public class Context
    {
        public const string ConnectionString = "Data Source=./; Initial Catalog=CarFleetDB";

        public Context()
        {
        }

        public static Context Create()
        {
            return new Context();
        }
        
        /// <summary>
        /// Create new table in given DataSet and fill it with data returned with command
        /// </summary>
        /// <typeparam name="T">Model for data table</typeparam>
        /// <param name="command">Query ready to use</param>
        /// <param name="dataSet">Existing dataSet to be filled with new data table</param>
        public DataResponse GetTable<T>(SqlCommand command, DataSet dataSet)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var adapter = new SqlDataAdapter();
                    adapter.TableMappings.Add("Table", typeof(T).Name);

                    command.Connection = connection;
                    adapter.SelectCommand = command;
                    
                    adapter.Fill(dataSet);

                    return new DataResponse() { Success = true, Message = "Data was read successfully!" };
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    return new DataResponse() { Success = false, Message = "There was error while updating data: " + ex };
                }
            }
        }

        #region DummyMethodsToBeDeleted
        //public void UpdateTable<T>(SqlCommand command, DataSet dataSet)
        //{
        //    using (var connection = new SqlConnection(ConnectionString))
        //    {
        //        try
        //        {
        //            var adapter = new SqlDataAdapter();

        //            command.Connection = connection;
        //            adapter.UpdateCommand = command;

        //            connection.Open();

        //            adapter.Update(dataSet.Tables[typeof(T).Name]);

        //            connection.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            Debug.WriteLine(ex);
        //        }
        //    }
        //}

        //public void TestCon()
        //{
        //    var con = new SqlConnection(ConnectionString);
        //    var cmd = new SqlCommand();

        //    cmd.CommandText = "Select TOP (10) * from Persons";
        //    cmd.Connection = con;
        //    var list = new List<string>();
        //    con.Open();
        //    var c = PasswordHasher.EncodePassword("password");
        //}

        //public CommandResponse<DataSet> LoginUser(string username, string password)
        //{
        //    var reply = new CommandResponse<DataSet>(new DataSet("Data"));
        //    var passwordHash = PasswordHasher.EncodePassword(password);

        //    var cmdText = "SELECT TOP(1) * FROM Users WHERE @username = UserName AND @password = PasswordHash";
        //    //var cmdText = "SELECT TOP(1) * FROM Users WHERE @username = UserName AND @password = PasswordHash";
        //    var cmd = new SqlCommand(cmdText);

        //    cmd.Parameters.AddWithValue("username", username);
        //    cmd.Parameters.AddWithValue("password", passwordHash);

        //    _context.GetTable<Users>(cmd, reply.ReturnedValue);


        //    var cmdTextPerson = "SELECT * FROM Persons";
        //    var cmdPerson = new SqlCommand(cmdTextPerson);
        //    _context.GetTable<Persons>(cmdPerson, reply.ReturnedValue);


        //    var parentColumn = reply.ReturnedValue.Tables["Persons"].Columns["ID"];
        //    var childColumn = reply.ReturnedValue.Tables["Users"].Columns["PersonID"];

        //    var relation = new DataRelation("UserPerson", parentColumn, childColumn);
        //    reply.ReturnedValue.Relations.Add(relation);

        //    var data = reply.ReturnedValue.Tables["Users"].Rows[0];

        //    return reply;
        //}

        //public void UpdateTest()
        //{
        //    var dataSet = new DataSet();
        //    Persons.GetPersonsQuery(dataSet);

        //    var row = dataSet.Tables[nameof(Persons)]?.AsEnumerable()
        //        .FirstOrDefault(e => e.Field<int>(nameof(Persons.ID)) == 1);
        //    row[nameof(Persons.FirstName)] = "Janek";
        //    row[nameof(Persons.LastName)] = "Torowek";
        //    var response = Persons.UpdatedPersonsCommand(dataSet);
        //}

        //public void InsertTest()
        //{
        //    var dataSet = new DataSet();
        //    Persons.GetPersonsQuery(dataSet);

        //    var row = dataSet.Tables[nameof(Persons)].NewRow();

        //    row[nameof(Persons.FirstName)] = "Januszek";
        //    row[nameof(Persons.LastName)] = "Kowalczyk";
        //    row[nameof(Persons.PhoneNumber)] = "123123123";
        //    row[nameof(Persons.Email)] = "januszek.kowalczyk@gmail.com";

        //    dataSet.Tables[nameof(Persons)].Rows.Add(row);

        //    Persons.InsertPersonsCommand(dataSet);
        //}

        #endregion
    }
}
