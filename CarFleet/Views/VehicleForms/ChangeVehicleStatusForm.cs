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
using CarFleetDomain.Functions;

namespace CarFleet.Views.VehicleForms
{
    public partial class ChangeVehicleStatusForm : Form
    {
        private readonly int _vehicleID;
        private readonly Users _loggedUser;

        public ChangeVehicleStatusForm(int vehicleID, Users loggedUser)
        {
            _vehicleID = vehicleID;
            _loggedUser = loggedUser;
            InitializeComponent();
        }

        private void ChangeVehicleStatusForm_Load(object sender, EventArgs e)
        {
            CBoxVehicleStatus.DataSource = Enum.GetValues(typeof(VehicleStatusEnum));
            LabelWarning.Text = "";
        }

        private void BtnAddInspection_Click_1(object sender, EventArgs e)
        {
            var parseTry = Enum.TryParse<VehicleStatusEnum>(CBoxVehicleStatus.SelectedValue.ToString(), out var status);

            if (!parseTry)
            {
                LabelWarning.Text = "Error while selecting a status";
                return;
            }

            var dataSet = new DataSet();
            var response = VehicleSystem.InsertNewVehicleStatus(dataSet, _vehicleID, _loggedUser, status);

            if (response.Success)
            {
                GoBackToDetailsPage();
            }
            else
            {
                LabelWarning.Text = response.Message;
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
