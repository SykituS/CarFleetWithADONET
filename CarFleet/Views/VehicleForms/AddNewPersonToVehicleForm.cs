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
            var personID = (int)DataGridViewAddPersonToVehicle.SelectedRows[0].Cells[0].Value;
            
            //TODO: Validation

            var dataSet = new DataSet();
            VehicleSystem.InsertNewVehiclePerson(dataSet, _vehicleID, _loggedUser, personID);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            var carDetails = new CarDetailsForm(_vehicleID, _loggedUser);  // create instance of AddEmployeeForm
            var mainForm = (MainAdministrationForm)this.ParentForm;  // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm?.loadForm(carDetails);
        }

        private void AddNewPersonToVehicleForm_Load(object sender, EventArgs e)
        {
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
