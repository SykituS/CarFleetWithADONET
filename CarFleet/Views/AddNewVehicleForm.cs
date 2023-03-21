using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CarFleetDomain.Models;

namespace CarFleet.Views
{
    public partial class AddNewVehicleForm : Form
    {
        private readonly Users loggedUser;

        public AddNewVehicleForm(Users user)
        {
            loggedUser = user;
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                InsertNewVehicleToDatabase();
            }
            catch (Exception exception)
            {
                LabelWarning.Visible = true;
                LabelWarning.Text = "Something went wrong!";
            }
        }

        private void InsertNewVehicleToDatabase()
        {
            var dataSet = new DataSet();
            DataRow row;
            InsertNewVehicle(dataSet);
            var vehicleID = (int)dataSet.Tables[nameof(Vehicle)].AsEnumerable().Last().ItemArray[0];
            dataSet.Tables.Clear();

            InsertNewVehicleMileage(dataSet, vehicleID);
            dataSet.Tables.Clear();

            InsertNewVehicleInspection(dataSet, vehicleID);
            dataSet.Tables.Clear();

            InsertNewVehicleInsurer(dataSet, vehicleID);
            dataSet.Tables.Clear();

            InsertNewVehicleStatus(dataSet, vehicleID);
            dataSet.Tables.Clear();

            if (RichTextBoxDescription.TextLength > 0)
            {
                InsertNewVehicleDescription(dataSet, vehicleID);
                dataSet.Tables.Clear();
            }
        }

        private void InsertNewVehicleDescription(DataSet dataSet, int vehicleID)
        {
            DataRow row;
            VehicleDescription.GetVehicleDescriptionQuery(dataSet);
            row = dataSet.Tables[nameof(VehicleDescription)].NewRow();

            row[nameof(VehicleDescription.Description)] = RichTextBoxDescription.Text;
            row[nameof(VehicleDescription.VehicleID)] = vehicleID;
            row[nameof(VehicleDescription.CreatedByID)] = loggedUser.ID;
            row[nameof(VehicleDescription.CreatedOn)] = DateTime.Now;
            row[nameof(VehicleDescription.UpdatedByID)] = loggedUser.ID;
            row[nameof(VehicleDescription.UpdatedOn)] = DateTime.Now;

            dataSet.Tables[nameof(VehicleDescription)].Rows.Add(row);
            VehicleDescription.InsertVehicleDescriptionCommand(dataSet);
        }

        private void InsertNewVehicleStatus(DataSet dataSet, int vehicleID)
        {
            DataRow row;
            VehicleStatus.GetVehicleStatusQuery(dataSet);
            row = dataSet.Tables[nameof(VehicleStatus)].NewRow();

            row[nameof(VehicleStatus.Status)] = VehicleStatusEnum.Free;
            row[nameof(VehicleStatus.VehicleID)] = vehicleID;
            row[nameof(VehicleStatus.CreatedByID)] = loggedUser.ID;
            row[nameof(VehicleStatus.CreatedOn)] = DateTime.Now;

            dataSet.Tables[nameof(VehicleStatus)].Rows.Add(row);
            VehicleStatus.InsertVehicleStatusCommand(dataSet);
        }

        private void InsertNewVehicleInsurer(DataSet dataSet, int vehicleID)
        {
            DataRow row;
            VehicleInsurer.GetVehicleInsurerQuery(dataSet);
            row = dataSet.Tables[nameof(VehicleInsurer)].NewRow();

            row[nameof(VehicleInsurer.Insurer)] = TBInsurer.Text;
            row[nameof(VehicleInsurer.StartDateOfInsurence)] = DateTimePickerInsurenceStart.Value;
            row[nameof(VehicleInsurer.EndDateOfInsurence)] = DateTimePickerInsurenceEnd.Value;
            row[nameof(VehicleInsurer.VehicleID)] = vehicleID;
            row[nameof(VehicleInsurer.CreatedByID)] = loggedUser.ID;
            row[nameof(VehicleInsurer.CreatedOn)] = DateTime.Now;
            row[nameof(VehicleInsurer.UpdatedByID)] = loggedUser.ID;
            row[nameof(VehicleInsurer.UpdatedOn)] = DateTime.Now;

            dataSet.Tables[nameof(VehicleInsurer)].Rows.Add(row);
            VehicleInsurer.InsertVehicleInsurerCommand(dataSet);
        }

        private void InsertNewVehicleInspection(DataSet dataSet, int vehicleID)
        {
            DataRow row;
            VehicleInspection.GetVehicleInspectionQuery(dataSet);
            row = dataSet.Tables[nameof(VehicleInspection)].NewRow();

            row[nameof(VehicleInspection.DateOfInspection)] = DateTimePickerInsurenceStart.Value;
            row[nameof(VehicleInspection.DateOfNextInspection)] = DateTimePickerInsurenceEnd.Value;
            row[nameof(VehicleInspection.VehicleID)] = vehicleID;
            row[nameof(VehicleInspection.CreatedByID)] = loggedUser.ID;
            row[nameof(VehicleInspection.CreatedOn)] = DateTime.Now;
            row[nameof(VehicleInspection.UpdatedByID)] = loggedUser.ID;
            row[nameof(VehicleInspection.UpdatedOn)] = DateTime.Now;

            dataSet.Tables[nameof(VehicleInspection)].Rows.Add(row);
            VehicleInspection.InsertVehicleInspectionCommand(dataSet);
        }

        private void InsertNewVehicleMileage(DataSet dataSet, int vehicleID)
        {
            DataRow row;
            VehicleMileage.GetVehicleMileageQuery(dataSet);
            row = dataSet.Tables[nameof(VehicleMileage)].NewRow();

            row[nameof(VehicleMileage.Mileage)] = (int)NumericUDMileage.Value;
            row[nameof(VehicleMileage.VehicleID)] = vehicleID;
            row[nameof(VehicleMileage.CreatedByID)] = loggedUser.ID;
            row[nameof(VehicleMileage.CreatedOn)] = DateTime.Now;
            row[nameof(VehicleMileage.UpdatedByID)] = loggedUser.ID;
            row[nameof(VehicleMileage.UpdatedOn)] = DateTime.Now;

            dataSet.Tables[nameof(VehicleMileage)].Rows.Add(row);
            VehicleMileage.InsertVehicleMileageCommand(dataSet);
        }

        private void InsertNewVehicle(DataSet dataSet)
        {
            Vehicle.GetVehicleQuery(dataSet);
            var row = dataSet.Tables[nameof(Vehicle)].NewRow();

            row[nameof(Vehicle.LicensePlate)] = TBLicensePlate.Text;
            row[nameof(Vehicle.Manufacturer)] = TBManufacturer.Text;
            row[nameof(Vehicle.Model)] = TBModel.Text;
            row[nameof(Vehicle.VinNumber)] = TBVinNumber.Text;
            row[nameof(Vehicle.ProductionYear)] = DateTimePickerProductionYear.Value.Year;
            row[nameof(Vehicle.CreatedByID)] = loggedUser.ID;
            row[nameof(Vehicle.CreatedOn)] = DateTime.Now;
            row[nameof(Vehicle.UpdatedByID)] = loggedUser.ID;
            row[nameof(Vehicle.UpdatedOn)] = DateTime.Now;

            dataSet.Tables[nameof(Vehicle)].Rows.Add(row);
            Vehicle.InsertVehicleCommand(dataSet);
        }
    }
}