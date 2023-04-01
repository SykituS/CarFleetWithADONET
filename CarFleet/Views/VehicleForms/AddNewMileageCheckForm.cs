using CarFleetDomain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarFleetDomain.Functions;
using System.Data.SqlClient;
using CarFleet.Views.MainForms;

namespace CarFleet.Views.VehicleForms
{
    public partial class AddNewMileageCheckForm : Form
    {
        private readonly int _vehicleID;
        private readonly Users _loggedUser;
        private int _lastMileage;

        public AddNewMileageCheckForm(int vehicleID, Users loggedUser)
        {
            _vehicleID = vehicleID;
            _loggedUser = loggedUser;
            InitializeComponent();
        }

        private void AddNewMileageCheckForm_Load(object sender, EventArgs e)
        {
            LabelWarning.Text = "";

            var cmd = new SqlCommand();
            var dataSet = new DataSet();
            cmd.Parameters.AddWithValue("@vid", _vehicleID);
            SetUpVehicleMileageData(cmd, dataSet);
        }

        private void SetUpVehicleMileageData(SqlCommand cmd, DataSet dataSet)
        {
            try
            {
                cmd.CommandText = "SELECT Top(1) Mileage FROM VehicleMileage as veh where VehicleID = @vid order by CreatedOn desc";
                var response = VehicleMileage.GetVehicleMileageQuery(dataSet, cmd);

                if (response.Success)
                {
                    _lastMileage = (int)dataSet.Tables[nameof(VehicleMileage)].Rows[0].ItemArray[0];
                    NumericUDMileage.Value = _lastMileage;
                }
                else
                    LabelWarning.Text += response.Message;
            }
            catch (Exception e)
            {
                LabelWarning.Text += "Something went wrong while loading mileage! Please try again";
            }
        }

        private DataResponse CheckGivenData()
        {
            var sb = new StringBuilder();
            var response = new DataResponse
            {
                Success = true,
            };

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

            if (_lastMileage > (int)NumericUDMileage.Value)
            {
                sb.AppendLine("Mileage can't be lower than latest mileage");
                response.Success = false;
            }

            response.Message = sb.ToString();
            return response;
        }

        private void BtnResetTextBox_Click(object sender, EventArgs e)
        {
            NumericUDMileage.Value = _lastMileage;
        }

        private void BtnAddInspection_Click_1(object sender, EventArgs e)
        {
            var returnedCheck = CheckGivenData();
            if (!returnedCheck.Success)
            {
                LabelWarning.Text = returnedCheck.Message;
                LabelWarning.ForeColor = Color.Red;
                return;
            }
            var dataSet = new DataSet();
            var response =
                VehicleSystem.InsertNewVehicleMileage(dataSet, _vehicleID, _loggedUser, (int)NumericUDMileage.Value);

            if (response.Success)
            {
                LabelWarning.Text = "Mileage successfully added!";
                LabelWarning.ForeColor = Color.GreenYellow;
                GoToDetailsPage();
            }
            else
            {
                LabelWarning.Text = response.Message;
                LabelWarning.ForeColor = Color.Red;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            GoToDetailsPage();
        }

        private void GoToDetailsPage()
        {
            var carDetails = new CarDetailsForm(_vehicleID, _loggedUser); // create instance of AddEmployeeForm
            var mainForm = (MainAdministrationForm)this.ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm?.loadForm(carDetails);
        }
    }
}
