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
    public partial class AddNewInsurenceForm : Form
    {
        private readonly int _insurenceID;
        private readonly int _vehicleID;
        private readonly Users _loggedUser;
        public AddNewInsurenceForm(int insurenceID, int vehicleID, Users loggedUser)
        {
            _insurenceID = insurenceID;
            _vehicleID = vehicleID;
            _loggedUser = loggedUser;
            InitializeComponent();
        }

        private void AddOrEditInsurenceForm_Load(object sender, EventArgs e)
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

            response.Message = sb.ToString();
            return response;
        }

        private void DateTimePickerInsurenceStart_ValueChanged(object sender, EventArgs e)
        {
            DateTimePickerInsurenceEnd.Value = DateTimePickerInsurenceStart.Value.AddYears(1);
        }

        private void BtnAddInsurence_Click_1(object sender, EventArgs e)
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
                VehicleSystem.InsertNewVehicleInsurer(dataSet, _vehicleID, _loggedUser, TBInsurer.Text, DateTimePickerInsurenceStart.Value, DateTimePickerInsurenceEnd.Value);

            if (response.Success)
            {
                LabelWarning.Text = "Insurence successfully added!";
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
