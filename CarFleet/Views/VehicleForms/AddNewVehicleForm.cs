using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarFleet.Views.MainForms;
using CarFleetDomain.Functions;
using CarFleetDomain.Models;

namespace CarFleet.Views.VehicleForms
{
    public partial class AddNewVehicleForm : Form
    {
        private readonly Users loggedUser;

        public AddNewVehicleForm(Users user)
        {
            loggedUser = user;
            InitializeComponent();
        }

        private void AddNewVehicleForm_Load(object sender, EventArgs e)
        {
            DateTimePickerNextInspection.Value = DateTimePickerInspection.Value.AddYears(1);
            DateTimePickerInsurenceEnd.Value = DateTimePickerInsurenceStart.Value.AddYears(1);

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
                    LabelWarning.ForeColor = Color.Red;
                }
            }
            catch (Exception exception)
            {
                LabelWarning.Text = "Something went wrong!";
                LabelWarning.ForeColor = Color.Red;
            }
        }

        private void DateTimePickerInspection_ValueChanged(object sender, EventArgs e)
        {
            DateTimePickerNextInspection.Value = DateTimePickerInspection.Value.AddYears(1);
        }

        private void DateTimePickerInsurenceStart_ValueChanged(object sender, EventArgs e)
        {
            DateTimePickerInsurenceEnd.Value = DateTimePickerInsurenceStart.Value.AddYears(1);
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

            if (DateTimePickerInsurenceStart.Value > DateTimePickerInsurenceEnd.Value)
            {
                sb.AppendLine("Given insurence date are wrong! End date of insurence can't be lower then start date!");
                response.Success = false;
            }

            if (DateTimePickerInspection.Value > DateTimePickerNextInspection.Value)
            {
                sb.AppendLine("Given inspection date are wrong! Next date of inspection can't be lower then date of inspection!");
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
            var response = VehicleSystem.InsertNewVehicle(dataSet, 0, loggedUser, TBLicensePlate.Text, TBManufacturer.Text, TBModel.Text, TBVinNumber.Text, DateTimePickerProductionYear.Value.Year);

            if (!response.Success)
                return response;

            var vehicleID = (int)dataSet.Tables[nameof(Vehicle)].AsEnumerable().Last().ItemArray[0];
            dataSet.Tables.Clear();

            response = VehicleSystem.InsertNewVehicleMileage(dataSet, vehicleID, loggedUser, (int)NumericUDMileage.Value);
            dataSet.Tables.Clear();

            if (!response.Success)
                return response;

            response = VehicleSystem.InsertNewVehicleInspection(dataSet, vehicleID, loggedUser, DateTimePickerInspection.Value, DateTimePickerNextInspection.Value);
            dataSet.Tables.Clear();

            if (!response.Success)
                return response;

            response = VehicleSystem.InsertNewVehicleInsurer(dataSet, vehicleID, loggedUser, TBInsurer.Text, DateTimePickerInsurenceStart.Value, DateTimePickerInsurenceEnd.Value);
            dataSet.Tables.Clear();

            if (!response.Success)
                return response;

            response = VehicleSystem.InsertNewVehicleStatus(dataSet, vehicleID, loggedUser, VehicleStatusEnum.Free);
            dataSet.Tables.Clear();

            if (RichTextBoxDescription.TextLength > 0)
            {
                response = VehicleSystem.InsertNewVehicleDescription(dataSet, vehicleID, loggedUser, RichTextBoxDescription.Text);
                dataSet.Tables.Clear();
            }

            return response;
        }
    }
}