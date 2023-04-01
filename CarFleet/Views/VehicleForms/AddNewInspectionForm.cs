using CarFleetDomain.Functions;
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
using CarFleet.Views.MainForms;

namespace CarFleet.Views.VehicleForms
{
    public partial class AddNewInspectionForm : Form
    {
        private readonly int _vehicleID;
        private readonly Users _loggedUser;

        public AddNewInspectionForm(int vehicleID, Users loggedUser)
        {
            _vehicleID = vehicleID;
            _loggedUser = loggedUser;
            InitializeComponent();
        }
        private void AddNewInspectionForm_Load(object sender, EventArgs e)
        {
            DateTimePickerNextInspection.Value = DateTime.Now.AddYears(1);
        }

        private void DateTimePickerInspection_ValueChanged(object sender, EventArgs e)
        {
            DateTimePickerNextInspection.Value = DateTimePickerInspection.Value.AddYears(1);
        }

        private void BtnAddInspection_Click(object sender, EventArgs e)
        {
            var returnedCheck = CheckGivenData();
            if (!returnedCheck.Success)
            {
                LabelWarning.Text = returnedCheck.Message;
                LabelWarning.ForeColor = Color.Red;
                return;
            }
            var dataSet = new DataSet();
            var response = VehicleSystem.InsertNewVehicleInspection(dataSet,
                                                                    _vehicleID,
                                                                    _loggedUser,
                                                                    DateTimePickerInspection.Value,
                                                                    DateTimePickerNextInspection.Value);

            if (response.Success)
            {
                LabelWarning.Text = "Mileage successfully added!";
                LabelWarning.ForeColor = Color.GreenYellow;
            }
            else
            {
                LabelWarning.Text = response.Message;
                LabelWarning.ForeColor = Color.Red;
            }
        }

        private DataResponse CheckGivenData()
        {
            var sb = new StringBuilder();
            var response = new DataResponse
            {
                Success = true,
            };

            if (DateTimePickerInspection.Value > DateTimePickerNextInspection.Value)
            {
                sb.AppendLine("Given inspection date are wrong! Next date of inspection can't be lower then date of inspection!");
                response.Success = false;
            }

            response.Message = sb.ToString();
            return response;
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
            var response = VehicleSystem.InsertNewVehicleInspection(dataSet,
                                                                    _vehicleID,
                                                                    _loggedUser,
                                                                    DateTimePickerInspection.Value,
                                                                    DateTimePickerNextInspection.Value);

            if (response.Success)
            {
                LabelWarning.Text = "Mileage successfully added!";
                LabelWarning.ForeColor = Color.GreenYellow;
                GoBackToDetailsPage();
            }
            else
            {
                LabelWarning.Text = response.Message;
                LabelWarning.ForeColor = Color.Red;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            GoBackToDetailsPage();
        }

        private void GoBackToDetailsPage()
        {
            var carDetails = new CarDetailsForm(_vehicleID, _loggedUser); // create instance of AddEmployeeForm
            var mainForm = (MainAdministrationForm)this.ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm?.loadForm(carDetails);
        }
    }
}
