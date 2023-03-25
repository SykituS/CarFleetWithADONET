using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            this.Close();
        }

        private DataResponse CheckGivenData()
        {
            var sb = new StringBuilder();
            var response = new DataResponse
            {
                Success = true,
            };

            if (TBLicensePlate.Text.Length < 4)
            {
                sb.AppendLine("Proper license plate needs to be provided");
                response.Success = false;
            }

            if (string.IsNullOrWhiteSpace(TBInsurer.Text))
            {
                sb.AppendLine("Insurer field need to be provided");
                response.Success = false;
            }

            if (string.IsNullOrWhiteSpace(TBManufacturer.Text))
            {
                sb.AppendLine("Manufacturer field need to be provided");
                response.Success = false;
            }

            if (string.IsNullOrWhiteSpace(TBModel.Text))
            {
                sb.AppendLine("Model field need to be provided");
                response.Success = false;
            }

            if (TBVinNumber.Text.Length != 17)
            {
                sb.AppendLine("Vin number must be 17 characters long");
                response.Success = false;
            }

            if (!string.IsNullOrWhiteSpace(RichTextBoxDescription.Text))
            {
                if (RichTextBoxDescription.Text.Length > 500)
                {
                    sb.AppendLine("Given description is too long!");
                    response.Success = false;
                }
            }

            if (NumericUDMileage.Value < 1)
            {
                sb.AppendLine("Mileage can not be under 0");
                response.Success = false;
            }

            if (NumericUDMileage.DecimalPlaces != 0)
            {
                sb.AppendLine("Mileage can't contain any decimal places");
                response.Success = false;
            }

            response.Message = sb.ToString();
            return response;
        }

        private DataResponse InsertNewVehicleToDatabase()
        {
            var dataSet = new DataSet();
            DataRow row;
            var response = InsertNewVehicle(dataSet);

            if (!response.Success)
                return response;

            var vehicleID = (int)dataSet.Tables[nameof(Vehicle)].AsEnumerable().Last().ItemArray[0];
            dataSet.Tables.Clear();

            response = InsertNewVehicleMileage(dataSet, vehicleID);
            dataSet.Tables.Clear();

            if (!response.Success)
                return response;

            response = InsertNewVehicleInspection(dataSet, vehicleID);
            dataSet.Tables.Clear();

            if (!response.Success)
                return response;

            response = InsertNewVehicleInsurer(dataSet, vehicleID);
            dataSet.Tables.Clear();

            if (!response.Success)
                return response;

            response = InsertNewVehicleStatus(dataSet, vehicleID);
            dataSet.Tables.Clear();

            if (RichTextBoxDescription.TextLength > 0)
            {
                response = InsertNewVehicleDescription(dataSet, vehicleID);
                dataSet.Tables.Clear();
            }

            return response;
        }

        private DataResponse InsertNewVehicleDescription(DataSet dataSet, int vehicleID)
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
            return VehicleDescription.InsertVehicleDescriptionCommand(dataSet);
        }

        private DataResponse InsertNewVehicleStatus(DataSet dataSet, int vehicleID)
        {
            DataRow row;
            VehicleStatus.GetVehicleStatusQuery(dataSet);
            row = dataSet.Tables[nameof(VehicleStatus)].NewRow();

            row[nameof(VehicleStatus.Status)] = VehicleStatusEnum.Free;
            row[nameof(VehicleStatus.VehicleID)] = vehicleID;
            row[nameof(VehicleStatus.CreatedByID)] = loggedUser.ID;
            row[nameof(VehicleStatus.CreatedOn)] = DateTime.Now;

            dataSet.Tables[nameof(VehicleStatus)].Rows.Add(row);
            return VehicleStatus.InsertVehicleStatusCommand(dataSet);
        }

        private DataResponse InsertNewVehicleInsurer(DataSet dataSet, int vehicleID)
        {
            DataRow row;
            VehicleInsurer.GetVehicleInsurerQuery(dataSet);
            row = dataSet.Tables[nameof(VehicleInsurer)].NewRow();

            row[nameof(VehicleInsurer.Insurer)] = TBInsurer.Text.ToUpper();
            row[nameof(VehicleInsurer.StartDateOfInsurence)] = DateTimePickerInsurenceStart.Value;
            row[nameof(VehicleInsurer.EndDateOfInsurence)] = DateTimePickerInsurenceEnd.Value;
            row[nameof(VehicleInsurer.VehicleID)] = vehicleID;
            row[nameof(VehicleInsurer.CreatedByID)] = loggedUser.ID;
            row[nameof(VehicleInsurer.CreatedOn)] = DateTime.Now;
            row[nameof(VehicleInsurer.UpdatedByID)] = loggedUser.ID;
            row[nameof(VehicleInsurer.UpdatedOn)] = DateTime.Now;

            dataSet.Tables[nameof(VehicleInsurer)].Rows.Add(row);
            return VehicleInsurer.InsertVehicleInsurerCommand(dataSet);
        }

        private DataResponse InsertNewVehicleInspection(DataSet dataSet, int vehicleID)
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
            return VehicleInspection.InsertVehicleInspectionCommand(dataSet);
        }

        private DataResponse InsertNewVehicleMileage(DataSet dataSet, int vehicleID)
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
            return VehicleMileage.InsertVehicleMileageCommand(dataSet);
        }

        private DataResponse InsertNewVehicle(DataSet dataSet)
        {
            Vehicle.GetVehicleQuery(dataSet);
            var row = dataSet.Tables[nameof(Vehicle)].NewRow();

            row[nameof(Vehicle.LicensePlate)] = TBLicensePlate.Text.ToUpper();
            row[nameof(Vehicle.Manufacturer)] = TBManufacturer.Text.ToUpper();
            row[nameof(Vehicle.Model)] = TBModel.Text.ToUpper();
            row[nameof(Vehicle.VinNumber)] = TBVinNumber.Text.ToUpper();
            row[nameof(Vehicle.ProductionYear)] = DateTimePickerProductionYear.Value.Year;
            row[nameof(Vehicle.CreatedByID)] = loggedUser.ID;
            row[nameof(Vehicle.CreatedOn)] = DateTime.Now;
            row[nameof(Vehicle.UpdatedByID)] = loggedUser.ID;
            row[nameof(Vehicle.UpdatedOn)] = DateTime.Now;

            dataSet.Tables[nameof(Vehicle)].Rows.Add(row);
            return Vehicle.InsertVehicleCommand(dataSet);
        }

        private void AddNewVehicleForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CarListForm carListForm = new CarListForm(loggedUser);  // create instance of AddEmployeeForm
            MainAdministrationForm mainForm = (MainAdministrationForm)this.ParentForm;  // get reference to the parent form

            // load AddEmployeeForm in the mainpanel of the parent form
            mainForm.loadForm(carListForm);
        }

        private void BtnAddCar_Click(object sender, EventArgs e)
        {
            LabelWarning.Visible = true;
            try
            {
                var returnedCheck = CheckGivenData();
                if (!returnedCheck.Success)
                {
                    LabelWarning.Text = returnedCheck.Message;
                    return;
                }

                var response = InsertNewVehicleToDatabase();

                if (response.Success)
                {
                    LabelWarning.Text = "Vehicle successfully added!";
                    LabelWarning.ForeColor = Color.GreenYellow;
                }
                else
                {
                    LabelWarning.Text = response.Message;
                }
            }
            catch (Exception exception)
            {
                LabelWarning.Text = "Something went wrong!";
            }
        }
    }
}