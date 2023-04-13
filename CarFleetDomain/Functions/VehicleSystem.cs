using CarFleetDomain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFleetDomain.Functions
{
    public class VehicleSystem
    {
        public static DataResponse InsertNewVehicleDescription(DataSet dataSet, int vehicleID, Users loggedUser, string richTextBoxDescription)
        {
            DataRow row;
            VehicleDescription.GetVehicleDescriptionQuery(dataSet);
            row = dataSet.Tables[nameof(VehicleDescription)].NewRow();

            row[nameof(VehicleDescription.Description)] = richTextBoxDescription;
            row[nameof(VehicleDescription.VehicleID)] = vehicleID;
            row[nameof(VehicleDescription.CreatedByID)] = loggedUser.ID;
            row[nameof(VehicleDescription.CreatedOn)] = DateTime.Now;
            row[nameof(VehicleDescription.UpdatedByID)] = loggedUser.ID;
            row[nameof(VehicleDescription.UpdatedOn)] = DateTime.Now;

            dataSet.Tables[nameof(VehicleDescription)].Rows.Add(row);
            return VehicleDescription.InsertVehicleDescriptionCommand(dataSet);
        }

        public static DataResponse InsertNewVehicleStatus(DataSet dataSet, int vehicleID, Users loggedUser, VehicleStatusEnum status)
        {
            DataRow row;
            VehicleStatus.GetVehicleStatusQuery(dataSet);
            row = dataSet.Tables[nameof(VehicleStatus)].NewRow();

            row[nameof(VehicleStatus.Status)] = status;
            row[nameof(VehicleStatus.VehicleID)] = vehicleID;
            row[nameof(VehicleStatus.CreatedByID)] = loggedUser.ID;
            row[nameof(VehicleStatus.CreatedOn)] = DateTime.Now;

            dataSet.Tables[nameof(VehicleStatus)].Rows.Add(row);
            return VehicleStatus.InsertVehicleStatusCommand(dataSet);
        }

        public static DataResponse InsertNewVehicleInsurer(DataSet dataSet, int vehicleID, Users loggedUser, string insurer, DateTime insurenceStart, DateTime insurenceEnd)
        {
            DataRow row;
            VehicleInsurer.GetVehicleInsurerQuery(dataSet);
            row = dataSet.Tables[nameof(VehicleInsurer)].NewRow();

            row[nameof(VehicleInsurer.Insurer)] = insurer;
            row[nameof(VehicleInsurer.StartDateOfInsurence)] = insurenceStart;
            row[nameof(VehicleInsurer.EndDateOfInsurence)] = insurenceEnd;
            row[nameof(VehicleInsurer.VehicleID)] = vehicleID;
            row[nameof(VehicleInsurer.CreatedByID)] = loggedUser.ID;
            row[nameof(VehicleInsurer.CreatedOn)] = DateTime.Now;
            row[nameof(VehicleInsurer.UpdatedByID)] = loggedUser.ID;
            row[nameof(VehicleInsurer.UpdatedOn)] = DateTime.Now;

            dataSet.Tables[nameof(VehicleInsurer)].Rows.Add(row);
            return VehicleInsurer.InsertVehicleInsurerCommand(dataSet);
        }

        public static DataResponse InsertNewVehicleInspection(DataSet dataSet, int vehicleID, Users loggedUser, DateTime inspectionDate, DateTime inspectionNextDate)
        {
            DataRow row;
            VehicleInspection.GetVehicleInspectionQuery(dataSet);
            row = dataSet.Tables[nameof(VehicleInspection)].NewRow();

            row[nameof(VehicleInspection.DateOfInspection)] = inspectionDate;
            row[nameof(VehicleInspection.DateOfNextInspection)] = inspectionNextDate;
            row[nameof(VehicleInspection.VehicleID)] = vehicleID;
            row[nameof(VehicleInspection.CreatedByID)] = loggedUser.ID;
            row[nameof(VehicleInspection.CreatedOn)] = DateTime.Now;
            row[nameof(VehicleInspection.UpdatedByID)] = loggedUser.ID;
            row[nameof(VehicleInspection.UpdatedOn)] = DateTime.Now;

            dataSet.Tables[nameof(VehicleInspection)].Rows.Add(row);
            return VehicleInspection.InsertVehicleInspectionCommand(dataSet);
        }

        public static DataResponse InsertNewVehicleMileage(DataSet dataSet, int vehicleID, Users loggedUser, int mileage)
        {
            DataRow row;
            VehicleMileage.GetVehicleMileageQuery(dataSet);
            row = dataSet.Tables[nameof(VehicleMileage)].NewRow();

            row[nameof(VehicleMileage.Mileage)] = mileage;
            row[nameof(VehicleMileage.VehicleID)] = vehicleID;
            row[nameof(VehicleMileage.CreatedByID)] = loggedUser.ID;
            row[nameof(VehicleMileage.CreatedOn)] = DateTime.Now;
            row[nameof(VehicleMileage.UpdatedByID)] = loggedUser.ID;
            row[nameof(VehicleMileage.UpdatedOn)] = DateTime.Now;

            dataSet.Tables[nameof(VehicleMileage)].Rows.Add(row);
            return VehicleMileage.InsertVehicleMileageCommand(dataSet);
        }

        public static DataResponse InsertNewVehicle(DataSet dataSet, int vehicleID, Users loggedUser, string licensePlate, string manufacturer, string model, string vin ,int productionYear)
        {
            Vehicle.GetVehicleQuery(dataSet);
            var row = dataSet.Tables[nameof(Vehicle)].NewRow();

            row[nameof(Vehicle.LicensePlate)] = licensePlate.ToUpper();
            row[nameof(Vehicle.Manufacturer)] = manufacturer.ToUpper();
            row[nameof(Vehicle.Model)] = model.ToUpper();
            row[nameof(Vehicle.VinNumber)] = vin.ToUpper();
            row[nameof(Vehicle.ProductionYear)] = productionYear;
            row[nameof(Vehicle.CreatedByID)] = loggedUser.ID;
            row[nameof(Vehicle.CreatedOn)] = DateTime.Now;
            row[nameof(Vehicle.UpdatedByID)] = loggedUser.ID;
            row[nameof(Vehicle.UpdatedOn)] = DateTime.Now;

            dataSet.Tables[nameof(Vehicle)].Rows.Add(row);
            return Vehicle.InsertVehicleCommand(dataSet);
        }

        public static DataResponse InsertNewVehiclePerson(DataSet dataSet, int vehicleID, Users loggedUser,
            int personID)
        {
            VehiclePersonHistory.GetVehiclePersonHistoryQuery(dataSet);
            var row = dataSet.Tables[nameof(VehiclePersonHistory)].NewRow();

            row[nameof(VehiclePersonHistory.VehicleID)] = vehicleID;
            row[nameof(VehiclePersonHistory.PersonID)] = personID;
            row[nameof(VehiclePersonHistory.CreatedByID)] = loggedUser.ID;
            row[nameof(VehiclePersonHistory.CreatedOn)] = DateTime.Now;
            row[nameof(VehiclePersonHistory.UpdatedByID)] = loggedUser.ID;
            row[nameof(VehiclePersonHistory.UpdatedOn)] = DateTime.Now;

            dataSet.Tables[nameof(VehiclePersonHistory)].Rows.Add(row);
            return VehiclePersonHistory.InsertVehiclePersonHistoryCommand(dataSet);
        }
    }
}
