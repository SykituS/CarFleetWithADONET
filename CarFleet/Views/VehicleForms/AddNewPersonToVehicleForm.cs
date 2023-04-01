using CarFleet.Views.MainForms;
using CarFleetDomain.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CarFleetDomain.Functions;

namespace CarFleet.Views.VehicleForms
{
    public partial class AddNewPersonToVehicleForm : Form
    {
        private readonly int _vehicleID;
        private readonly Users _loggedUser;

        public AddNewPersonToVehicleForm(int vehicleID, Users loggedUser)
        {
            _vehicleID = vehicleID;
            _loggedUser = loggedUser;
            InitializeComponent();
        }

        private void BtnAddPersonToVehicle_Click(object sender, EventArgs e)
        {
            var value = DataGridViewAddPersonToVehicle.SelectedRows[0].Cells[0].Value;
            //TODO: Validation

            if (value == null)
            {
                LabelWarning.Text = "Please select employee first!";
                return;
            }
            var personID = (int)value;

            if (personID == 0)
            {
                LabelWarning.Text = "Please select employee first!";
                return;
            }


            var dataSet = new DataSet();
            var result = VehicleSystem.InsertNewVehiclePerson(dataSet, _vehicleID, _loggedUser, personID);

            if (result.Success)
            {
                VehicleSystem.InsertNewVehicleStatus(dataSet, _vehicleID, _loggedUser, VehicleStatusEnum.InUse);
                GoToDetailsPage();
            }
            else
            {
                LabelWarning.Text = result.Message;
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

        private void AddNewPersonToVehicleForm_Load(object sender, EventArgs e)
        {
            LabelWarning.Text = "";

            var dataSet = new DataSet();
            var cmdText = "SELECT ID, FirstName, LastName, PhoneNumber, Email FROM Persons WHERE Disabled = 0";
            var cmd = new SqlCommand(cmdText);
            Persons.GetPersonsQuery(dataSet, cmd);

            DataGridViewAddPersonToVehicle.DataSource = dataSet.Tables[nameof(Persons)];
            DataGridViewAddPersonToVehicle.Columns[0].Visible = false;
        }

        private void TBSearchEmployee_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
