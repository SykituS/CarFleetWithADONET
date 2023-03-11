using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFleetDomain.Models
{
    public class Persons
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        private const string SelectCommand = "SELECT * FROM Persons";
        private const string UpdateCommand = "UPDATE Persons SET FirstName = @fname, Lastname = @lname, PhoneNumber = @pnumber, Email = @email WHERE ID = @UID";
        private const string InsertCommand = "INSERT INTO Persons (FirstName, LastName, PhoneNumber, Email) VALUES (@firstName, @lastName, @phoneNumber, @email)";
        private const string DeleteCommand = "SELECT * FROM Persons";

        public static void GetPersonsQuery(DataSet dataSet)
        {
            var context = new Context();
            var cmd = new SqlCommand(SelectCommand);
            context.GetTable<Persons>(cmd, dataSet);
        }

        public static void UpdatedPersonsCommand(DataSet dataSet)
        {
            using (var connection = new SqlConnection(Context.ConnectionString))
            {
                try
                {
                    var adapter = new SqlDataAdapter();

                    adapter.UpdateCommand =
                        new SqlCommand(UpdateCommand, connection);

                    adapter.UpdateCommand.Parameters.Add("@fname", SqlDbType.NVarChar, 255, "FirstName");
                    adapter.UpdateCommand.Parameters.Add("@lname", SqlDbType.NVarChar, 255, "Lastname");
                    adapter.UpdateCommand.Parameters.Add("@pnumber", SqlDbType.VarChar, 15, "PhoneNumber");
                    adapter.UpdateCommand.Parameters.Add("@email", SqlDbType.NVarChar, 255, "Email");

                    var parameter = adapter.UpdateCommand.Parameters.Add("@UID", SqlDbType.Int);
                    parameter.SourceColumn = "ID";
                    parameter.SourceVersion = DataRowVersion.Original;

                    var table = dataSet.Tables[nameof(Persons)];
                    adapter.Update(table);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }
        public static void InsertPersonsCommand(DataSet dataSet)
        {
            using (var connection = new SqlConnection(Context.ConnectionString))
            {
                try
                {
                    // Create a new SqlDataAdapter and update the database with the changes made to the DataSet
                    var adapter = new SqlDataAdapter();

                    // Define the INSERT command to insert new rows into the Persons table
                    adapter.InsertCommand = new SqlCommand(InsertCommand, connection);
                    adapter.InsertCommand.Parameters.Add("@firstName", SqlDbType.NVarChar, 50, "FirstName");
                    adapter.InsertCommand.Parameters.Add("@lastName", SqlDbType.NVarChar, 50, "LastName");
                    adapter.InsertCommand.Parameters.Add("@phoneNumber", SqlDbType.NVarChar, 20, "PhoneNumber");
                    adapter.InsertCommand.Parameters.Add("@email", SqlDbType.NVarChar, 50, "Email");

                    // Update the database with the changes made to the DataSet
                    adapter.Update(dataSet.Tables[nameof(Persons)]);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }
    }
}
