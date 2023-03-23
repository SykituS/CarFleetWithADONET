using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFleetDomain.Functions;

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

        #region Data Base Methods

        private const string SelectCommand = "SELECT * FROM Users";
        private const string UpdateCommand =
            "UPDATE [dbo].[Users] SET [UserName] = @UserName, [PasswordHash] = @PasswordHash ,[PersonID] = @PersonID ,[RoleID] = @RoleID WHERE PersonID = @UID";
        private const string InsertCommand = "INSERT INTO Users (UserName, PasswordHash, PersonID,RoleID) VALUES (@UserName, @PasswordHash, @PersonID,@RoleID)";
        private const string DeleteCommand = "DELETE FROM Users WHERE ID = @UID";


        public static DataResponse GetUsersQuery(DataSet dataSet)
        {
            var context = new Context();
            var cmd = new SqlCommand(SelectCommand);
            var response = context.GetTable<Users>(cmd, dataSet);

            if (response.Success)
            {
                return new DataResponse() { Success = true, Message = "Data was read successfully!" };
            }

            return new DataResponse() { Success = false, Message = "There was a problem while reading a data! " + response.Message };

        }

        public static DataResponse UpdateUsersCommand(DataSet dataSet)
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

                    // Read ID from Original source (data base) in case they have changed in the process
                    var parameter = adapter.UpdateCommand.Parameters.Add("@UID", SqlDbType.Int);
                    parameter.SourceColumn = "PersonID";
                    parameter.SourceVersion = DataRowVersion.Original;

                    var table = dataSet.Tables[nameof(Users)];

                    if (!dataSet.HasChanges())
                        return new DataResponse() { Success = false, Message = "In given data is no change" };

                    if (dataSet.HasErrors)
                    {
                        dataSet.RejectChanges();
                        return new DataResponse() { Success = false, Message = "Given data has errors!" };
                    }

                    adapter.Update(table);
                    return new DataResponse() { Success = true, Message = "Data was updated successfully" };
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    return new DataResponse() { Success = false, Message = "There was error while updating data: " + ex };
                }
            }
        }

        public static DataResponse InsertUsersCommand(DataSet dataSet)
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
                    adapter.InsertCommand.Parameters.Add("@RoleID", SqlDbType.Int, 2, "RoleID");
                    // Update the database with the changes made to the DataSet
                    var table = dataSet.Tables[nameof(Users)];


                    // Check if there are changes in data set
                    if (!dataSet.HasChanges())
                        return new DataResponse() { Success = false, Message = "In given data is no change" };

                    // Check if data set contains errors
                    if (dataSet.HasErrors)
                    {
                        dataSet.RejectChanges();
                        return new DataResponse() { Success = false, Message = "Given data has errors!" };
                    }

                    // Update the database with the changes made to the DataSet
                    adapter.Update(table);
                    adapter.SelectCommand = new SqlCommand(SelectCommand, connection);
                    adapter.Fill(table);
                    return new DataResponse() { Success = true, Message = "Data was updated successfully" };
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    return new DataResponse() { Success = false, Message = "There was error while updating data: " + ex };
                }
            }
        }
        
        public static DataResponse DeleteUsersCommand(DataSet dataSet)
        {
            throw (new NotImplementedException());
        }
        
        public string GeneratePasswordHash(string firstName, string lastName, string phoneNumber)
        {
            // Take first 3 characters of first name
            var firstNameChars = firstName.Take(3);

            // Take last 3 characters of last name
            var lastNameChars = lastName.Substring(Math.Max(0, lastName.Length - 3));

            // Take last 2 digits of phone number
            var phoneDigits = new string(phoneNumber.Where(char.IsDigit).ToArray());
            var lastTwoPhoneDigits = phoneDigits.Substring(phoneDigits.Length - 2);

            // Concatenate first name, last name, and phone digits
            var concatenated = new string(firstNameChars.Concat(lastNameChars).ToArray()) + lastTwoPhoneDigits;

            // Hash password using SHA-256 algorithm
            return PasswordHasher.EncodePassword(concatenated);
        }

        #endregion
    }

    public enum RoleEnum
    {
        Employee,
        Admin,
    }


}
