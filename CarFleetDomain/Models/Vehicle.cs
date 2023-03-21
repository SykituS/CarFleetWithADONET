using CarFleetDomain.Functions;
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
    public class Vehicle : ModelExtension
    {
        public int ID { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public string LicensePlate { get; set; }
        public string VinNumber { get; set; }

        #region Data Base Methods

        private const string SelectCommand = "SELECT * FROM Vehicle";
        private const string UpdateCommand =
            "UPDATE [dbo].[Vehicle] SET [Manufacturer] = @Manufacturer, [Model] = @Model, [ProductionYear] = @ProductionYear ,[LicensePlate] = @LicensePlate ,[VinNumber] = @VinNumber ,[CreatedOn] = @CreatedOn ,[CreatedByID] = @CreatedByID ,[UpdatedOn] = @UpdatedOn,[UpdatedByID] = @UpdatedByID WHERE ID = @UID";
        private const string InsertCommand = "INSERT INTO [dbo].[Vehicle]([Manufacturer], [Model], [ProductionYear], [LicensePlate], [VinNumber], [CreatedOn], [CreatedByID], [UpdatedOn], [UpdatedByID]) VALUES (@Manufacturer, @Model, @ProductionYear, @LicensePlate, @VinNumber, @CreatedOn, @CreatedByID, @UpdatedOn, @UpdatedByID)";
        private const string DeleteCommand = "DELETE FROM Vehicle WHERE ID = @UID";

        public static DataResponse GetVehicleQuery(DataSet dataSet, SqlCommand selectCmd = null)
        {
            var context = new Context();
            var cmd = selectCmd ?? new SqlCommand(SelectCommand);
            var response = context.GetTable<Vehicle>(cmd, dataSet);

            if (response.Success)
            {
                return new DataResponse() { Success = true, Message = "Data was read successfully!" };
            }

            return new DataResponse() { Success = false, Message = "There was a problem while reading a data! " + response.Message };

        }

        public static DataResponse UpdateVehicleCommand(DataSet dataSet)
        {
            using (var connection = new SqlConnection(Context.ConnectionString))
            {
                try
                {
                    var adapter = new SqlDataAdapter();

                    adapter.UpdateCommand = new SqlCommand(UpdateCommand, connection);

                    adapter.UpdateCommand.Parameters.Add("@Manufacturer", SqlDbType.VarChar).SourceColumn = "Manufacturer";
                    adapter.UpdateCommand.Parameters.Add("@Model", SqlDbType.VarChar).SourceColumn = "Model";
                    adapter.UpdateCommand.Parameters.Add("@ProductionYear", SqlDbType.Int).SourceColumn = "ProductionYear";
                    adapter.UpdateCommand.Parameters.Add("@LicensePlate", SqlDbType.VarChar).SourceColumn = "LicensePlate";
                    adapter.UpdateCommand.Parameters.Add("@VinNumber", SqlDbType.VarChar).SourceColumn = "VinNumber";
                    adapter.UpdateCommand.Parameters.Add("@CreatedOn", SqlDbType.DateTime).SourceColumn = "CreatedOn";
                    adapter.UpdateCommand.Parameters.Add("@CreatedByID", SqlDbType.Int).SourceColumn = "CreatedByID";
                    adapter.UpdateCommand.Parameters.Add("@UpdatedOn", SqlDbType.DateTime).SourceColumn = "UpdatedOn";
                    adapter.UpdateCommand.Parameters.Add("@UpdatedByID", SqlDbType.Int).SourceColumn = "UpdatedByID";

                    // Read ID from Original source (data base) in case they have changed in the process
                    var parameter = adapter.UpdateCommand.Parameters.Add("@UID", SqlDbType.Int);
                    parameter.SourceColumn = "ID";
                    parameter.SourceVersion = DataRowVersion.Original;

                    var table = dataSet.Tables[nameof(Vehicle)];

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

        public static DataResponse InsertVehicleCommand(DataSet dataSet)
        {
            using (var connection = new SqlConnection(Context.ConnectionString))
            {
                try
                {
                    // Create a new SqlDataAdapter and configure the INSERT command
                    var adapter = new SqlDataAdapter();

                    adapter.InsertCommand = new SqlCommand(InsertCommand, connection);

                    adapter.InsertCommand.Parameters.Add("@Manufacturer", SqlDbType.VarChar).SourceColumn = "Manufacturer";
                    adapter.InsertCommand.Parameters.Add("@Model", SqlDbType.VarChar).SourceColumn = "Model";
                    adapter.InsertCommand.Parameters.Add("@ProductionYear", SqlDbType.Int).SourceColumn = "ProductionYear";
                    adapter.InsertCommand.Parameters.Add("@LicensePlate", SqlDbType.VarChar).SourceColumn = "LicensePlate";
                    adapter.InsertCommand.Parameters.Add("@VinNumber", SqlDbType.VarChar).SourceColumn = "VinNumber";
                    adapter.InsertCommand.Parameters.Add("@CreatedOn", SqlDbType.DateTime).SourceColumn = "CreatedOn";
                    adapter.InsertCommand.Parameters.Add("@CreatedByID", SqlDbType.Int).SourceColumn = "CreatedByID";
                    adapter.InsertCommand.Parameters.Add("@UpdatedOn", SqlDbType.DateTime).SourceColumn = "UpdatedOn";
                    adapter.InsertCommand.Parameters.Add("@UpdatedByID", SqlDbType.Int).SourceColumn = "UpdatedByID";

                    // Update the database with the changes made to the DataSet
                    var table = dataSet.Tables[nameof(Vehicle)];

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

        public static DataResponse DeleteVehicleCommand(DataSet dataSet)
        {
            throw (new NotImplementedException());
        }

        #endregion
    }
}
