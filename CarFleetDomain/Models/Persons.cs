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
        public bool Disabled { get; set; }

        #region Data Base Methods

        private const string SelectCommand = "SELECT * FROM Persons";
        private const string UpdateCommand = "UPDATE Persons SET FirstName = @fname, Lastname = @lname, PhoneNumber = @pnumber, Email = @email, Disabled = @disabled WHERE ID = @UID";
        private const string InsertCommand = "INSERT INTO Persons (FirstName, LastName, PhoneNumber, Email, Disabled) VALUES (@firstName, @lastName, @phoneNumber, @email, @disabled)";
        private const string DeleteCommand = "DELETE FROM Persons WHERE ID = @UID";
        private const string DisablePersonCommand = "UPDATE Persons SET Disabled=@disabled WHERE ID=@id";
        public static DataResponse GetPersonsQuery(DataSet dataSet, SqlCommand selectCmd = null)
        {
            var context = new Context();
            var cmd = selectCmd ?? new SqlCommand(SelectCommand);
            var response = context.GetTable<Persons>(cmd, dataSet);

            if (response.Success)
            {
                return new DataResponse() { Success = true, Message = "Data was read successfully!" };
            }

            return new DataResponse() { Success = false, Message = "There was a problem while reading a data! " + response.Message };
        }
        public static DataResponse DisablePerson(DataSet dataSet)
        {
            using (var connection = new SqlConnection(Context.ConnectionString))
                try
                {
                    var adapter = new SqlDataAdapter();
                    adapter.UpdateCommand= new SqlCommand(DisablePersonCommand,connection);
                    adapter.UpdateCommand.Parameters.Add("@disabled", SqlDbType.Bit, 2, "Disabled");
                    var parameter = adapter.UpdateCommand.Parameters.Add("@id", SqlDbType.Int);
                    parameter.SourceColumn = "ID";
                    parameter.SourceVersion = DataRowVersion.Original;

                    var table = dataSet.Tables[nameof(Persons)];
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
        public static DataResponse UpdatedPersonsCommand(DataSet dataSet)
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
                    adapter.UpdateCommand.Parameters.Add("@disabled", SqlDbType.Bit, 2, "Disabled");

                    // Read ID from Original source (data base) in case they have changed in the process
                    var parameter = adapter.UpdateCommand.Parameters.Add("@UID", SqlDbType.Int);
                    parameter.SourceColumn = "ID";
                    parameter.SourceVersion = DataRowVersion.Original;

                    var table = dataSet.Tables[nameof(Persons)];

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
        public static DataResponse InsertPersonsCommand(DataSet dataSet)
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
                    adapter.InsertCommand.Parameters.Add("@disabled", SqlDbType.Bit, 2, "Disabled");

                    var table = dataSet.Tables[nameof(Persons)];

                    // Update the database with the changes made to the DataSet
                    if (!dataSet.HasChanges())
                        return new DataResponse() { Success = false, Message = "In given data is no change" };

                    if (dataSet.HasErrors)
                    {
                        dataSet.RejectChanges();
                        return new DataResponse() { Success = false, Message = "Given data has errors!" };
                    }

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
        public bool IsEmailUnique(string email)
        {
            var dataSet = new DataSet();
            Persons.GetPersonsQuery(dataSet);
            var personsTable = dataSet.Tables[nameof(Persons)];
            var query = from row in personsTable.AsEnumerable()
                        where row.Field<string>("Email") == email
                        select row;

            return query.Any();
        }
        //public static bool CheckIfUserExists(DataSet data)
        //{
        //    using (var connection = new SqlConnection(Context.ConnectionString))
        //    {
        //        var selectCommand = "SELECT COUNT(*) FROM Users WHERE PersonID = @personId";
        //        var adapter = new SqlDataAdapter(selectCommand, connection);
        //        adapter.SelectCommand.Parameters.AddWithValue("@personId", "PersonID");
        //        var dataSet = new DataSet();
        //        adapter.Fill(dataSet);
        //        var count = (int)dataSet.Tables[0].Rows[0][0];
        //        return count > 0;
        //    }
        //}

        public static DataResponse DeletePersonsCommand(DataSet dataSet)
        {
            throw (new NotImplementedException());
        }
        #endregion
    }
}
