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
    public class Users
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public int PersonID { get; set; }
        public int RoleID { get; set; }

        public Persons Person { get; set; }
        public RoleEnum Role { get; set; }

        private const string SelectCommand = "SELECT * FROM Users";
        private const string UpdateCommand =
            "UPDATE [dbo].[Users] SET [UserName] = @UserName, [PasswordHash] = @PasswordHash ,[PersonID] = @PersonID ,[RoleID] = @RoleID WHERE ID = @UID";
        private const string InsertCommand = "INSERT INTO Users (UserName, PasswordHash, PersonID) VALUES (@UserName, @PasswordHash, @PersonID)";
        private const string DeleteCommand = "DELETE FROM Users WHERE ID = @id";

        public static void GetUsersQuery(DataSet dataSet)
        {
            var context = new Context();
            var cmd = new SqlCommand(SelectCommand);
            context.GetTable<Users>(cmd, dataSet);
        }

        public static void UpdateUsersCommand(DataSet dataSet)
        {
            using (var connection = new SqlConnection(Context.ConnectionString))
            {
                try
                {
                    var adapter = new SqlDataAdapter();

                    adapter.UpdateCommand =
                        new SqlCommand(UpdateCommand, connection);

                    adapter.UpdateCommand.Parameters.Add("@UserName", SqlDbType.NVarChar, 4000, "UserName");
                    adapter.UpdateCommand.Parameters.Add("@PasswordHash", SqlDbType.NVarChar, 4000, "PasswordHash");
                    adapter.UpdateCommand.Parameters.Add("@PersonID", SqlDbType.Int, Int32.MaxValue, "PersonID");
                    adapter.UpdateCommand.Parameters.Add("@RoleID", SqlDbType.Int, 2, "RoleID");

                    var parameter = adapter.UpdateCommand.Parameters.Add("@UID", SqlDbType.Int);
                    parameter.SourceColumn = "ID";
                    parameter.SourceVersion = DataRowVersion.Original;

                    var table = dataSet.Tables[nameof(Users)];
                    adapter.Update(table);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }

        public void InsertUsersCommand(DataSet dataSet)
        {
            using (var connection = new SqlConnection(Context.ConnectionString))
            {
                try
                {
                    // Create a new SqlDataAdapter and configure the INSERT command
                    var adapter = new SqlDataAdapter();
                    adapter.InsertCommand = new SqlCommand(InsertCommand, connection);
                    adapter.InsertCommand.Parameters.Add("@userName", SqlDbType.NVarChar, 50, "UserName");
                    adapter.InsertCommand.Parameters.Add("@passwordHash", SqlDbType.NVarChar, 256, "PasswordHash");
                    adapter.InsertCommand.Parameters.Add("@personID", SqlDbType.Int, 4, "PersonID");

                    // Update the database with the changes made to the DataSet
                    adapter.Update(dataSet, "Users");
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }
    }

    public enum RoleEnum
    {
        Employee,
        Admin,
    }


}
