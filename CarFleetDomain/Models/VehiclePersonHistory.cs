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
    public class VehiclePersonHistory : ModelExtension
    {
        public int ID { get; set; }
        public int VehicleID { get; set; }
        public int PersonID { get; set; }

        public Vehicle Vehicle { get; set; }
        public Persons Person { get; set; }

        #region Data Base Methods

        private const string SelectCommand = "SELECT * FROM VehiclePersonHistory";
        private const string UpdateCommand = "UPDATE [dbo].[VehiclePersonHistory] SET [VehicleID] = @VehicleID, [PersonID] = @PersonID, [CreatedOn] = @CreatedOn, [CreatedByID] = @CreatedByID, [UpdatedOn] = @UpdatedOn, [UpdatedByID] = @UpdatedByID WHERE ID = @UID";
        private const string InsertCommand = "INSERT INTO [dbo].[VehiclePersonHistory] ([VehicleID], [PersonID], [CreatedOn], [CreatedByID], [UpdatedOn], [UpdatedByID]) VALUES (@VehicleID, @PersonID, @CreatedOn, @CreatedByID, @UpdatedOn, @UpdatedByID)";
        private const string DeleteCommand = "DELETE FROM VehiclePersonHistory WHERE ID = @UID";

        public static DataResponse GetVehiclePersonHistoryQuery(DataSet dataSet, SqlCommand selectCmd = null)
        {
            var context = new Context();
            var cmd = selectCmd ?? new SqlCommand(SelectCommand);
            var response = context.GetTable<VehiclePersonHistory>(cmd, dataSet);

            if (response.Success)
            {
                return new DataResponse() { Success = true, Message = "Data was read successfully!" };
            }

            return new DataResponse() { Success = false, Message = "There was a problem while reading a data! " + response.Message };

        }

        public static DataResponse UpdateVehiclePersonHistoryCommand(DataSet dataSet)
        {
            using (var connection = new SqlConnection(Context.ConnectionString))
            {
                try
                {
                    var adapter = new SqlDataAdapter();

                    adapter.UpdateCommand = new SqlCommand(UpdateCommand, connection);
                    
                    adapter.UpdateCommand.Parameters.Add("@PersonID", SqlDbType.Int).SourceColumn = "PersonID";
                    adapter.UpdateCommand.Parameters.Add("@VehicleID", SqlDbType.Int).SourceColumn = "VehicleID";
                    adapter.UpdateCommand.Parameters.Add("@CreatedOn", SqlDbType.DateTime).SourceColumn = "CreatedOn";
                    adapter.UpdateCommand.Parameters.Add("@CreatedByID", SqlDbType.Int).SourceColumn = "CreatedByID";
                    adapter.UpdateCommand.Parameters.Add("@UpdatedOn", SqlDbType.DateTime).SourceColumn = "UpdatedOn";
                    adapter.UpdateCommand.Parameters.Add("@UpdatedByID", SqlDbType.Int).SourceColumn = "UpdatedByID";

                    // Read ID from Original source (data base) in case they have changed in the process
                    var parameter = adapter.UpdateCommand.Parameters.Add("@UID", SqlDbType.Int);
                    parameter.SourceColumn = "ID";
                    parameter.SourceVersion = DataRowVersion.Original;

                    var table = dataSet.Tables[nameof(VehiclePersonHistory)];

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

        public static DataResponse InsertVehiclePersonHistoryCommand(DataSet dataSet)
        {
            using (var connection = new SqlConnection(Context.ConnectionString))
            {
                try
                {
                    // Create a new SqlDataAdapter and configure the INSERT command
                    var adapter = new SqlDataAdapter();

                    adapter.InsertCommand = new SqlCommand(InsertCommand, connection);

                    adapter.InsertCommand.Parameters.Add("@PersonID", SqlDbType.Int).SourceColumn = "PersonID";
                    adapter.InsertCommand.Parameters.Add("@VehicleID", SqlDbType.Int).SourceColumn = "VehicleID";
                    adapter.InsertCommand.Parameters.Add("@CreatedOn", SqlDbType.DateTime).SourceColumn = "CreatedOn";
                    adapter.InsertCommand.Parameters.Add("@CreatedByID", SqlDbType.Int).SourceColumn = "CreatedByID";
                    adapter.InsertCommand.Parameters.Add("@UpdatedOn", SqlDbType.DateTime).SourceColumn = "UpdatedOn";
                    adapter.InsertCommand.Parameters.Add("@UpdatedByID", SqlDbType.Int).SourceColumn = "UpdatedByID";
                    
                    // Update the database with the changes made to the DataSet
                    var table = dataSet.Tables[nameof(VehiclePersonHistory)];

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

                    // Get updated data table
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

        public static DataResponse DeleteVehiclePersonHistoryCommand(DataSet dataSet)
        {
            throw (new NotImplementedException());
        }

        #endregion
    }
}
