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
    public class VehicleStatus
    {
        public int ID { get; set; }
        public int VehicleID { get; set; }
        public VehicleStatusEnum Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByID { get; set; }

        public Vehicle Vehicle { get; set; }
        public Persons CreatedBy { get; set; }

        #region Data Base Methods

        private const string SelectCommand = "SELECT * FROM VehicleStatus";
        private const string UpdateCommand = "UPDATE [dbo].[VehicleStatus] SET [VehicleID] = @VehicleID, [Status] = @Status, [CreatedOn] = @CreatedOn, ,[CreatedByID] = @CreatedByID WHERE ID = @UID";
        private const string InsertCommand = "INSERT INTO [dbo].[VehicleStatus] ([VehicleID], [Status], [CreatedOn], [CreatedByID]) VALUES (@VehicleID, @Status, @CreatedOn, @CreatedByID)";
        private const string DeleteCommand = "DELETE FROM VehicleStatus WHERE ID = @UID";

        public static DataResponse GetVehicleStatusQuery(DataSet dataSet, SqlCommand selectCmd = null)
        {
            var context = new Context();
            var cmd = selectCmd ?? new SqlCommand(SelectCommand);
            var response = context.GetTable<VehicleStatus>(cmd, dataSet);

            if (response.Success)
            {
                return new DataResponse() { Success = true, Message = "Data was read successfully!" };
            }

            return new DataResponse() { Success = false, Message = "There was a problem while reading a data! " + response.Message };

        }

        public static DataResponse UpdateVehicleStatusCommand(DataSet dataSet)
        {
            using (var connection = new SqlConnection(Context.ConnectionString))
            {
                try
                {
                    var adapter = new SqlDataAdapter();

                    adapter.UpdateCommand = new SqlCommand(UpdateCommand, connection);
                    
                    adapter.UpdateCommand.Parameters.Add("@Status", SqlDbType.Int).SourceColumn = "Status";
                    adapter.InsertCommand.Parameters.Add("@VehicleID", SqlDbType.Int).SourceColumn = "VehicleID";
                    adapter.UpdateCommand.Parameters.Add("@CreatedOn", SqlDbType.DateTime).SourceColumn = "CreatedOn";
                    adapter.UpdateCommand.Parameters.Add("@CreatedByID", SqlDbType.Int).SourceColumn = "CreatedByID";

                    // Read ID from Original source (data base) in case they have changed in the process
                    var parameter = adapter.UpdateCommand.Parameters.Add("@UID", SqlDbType.Int);
                    parameter.SourceColumn = "ID";
                    parameter.SourceVersion = DataRowVersion.Original;

                    var table = dataSet.Tables[nameof(VehicleStatus)];

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

        public static DataResponse InsertVehicleStatusCommand(DataSet dataSet)
        {
            using (var connection = new SqlConnection(Context.ConnectionString))
            {
                try
                {
                    // Create a new SqlDataAdapter and configure the INSERT command
                    var adapter = new SqlDataAdapter();

                    adapter.InsertCommand = new SqlCommand(InsertCommand, connection);
                    
                    adapter.InsertCommand.Parameters.Add("@Status", SqlDbType.Int).SourceColumn = "Status";
                    adapter.InsertCommand.Parameters.Add("@VehicleID", SqlDbType.Int).SourceColumn = "VehicleID";
                    adapter.InsertCommand.Parameters.Add("@CreatedOn", SqlDbType.DateTime).SourceColumn = "CreatedOn";
                    adapter.InsertCommand.Parameters.Add("@CreatedByID", SqlDbType.Int).SourceColumn = "CreatedByID";

                    // Update the database with the changes made to the DataSet
                    var table = dataSet.Tables[nameof(VehicleStatus)];

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

        public static DataResponse DeleteVehicleStatusCommand(DataSet dataSet)
        {
            throw (new NotImplementedException());
        }

        #endregion
    }

    public enum VehicleStatusEnum
    {
        Free,
        Reserved,
        InUse,
        InService,
        EoL,
    }
}
