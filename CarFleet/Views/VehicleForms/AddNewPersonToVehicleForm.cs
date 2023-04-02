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

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            SearchDataGridView(TbSearch.Text.ToLower());
        }

        private void SearchDataGridView(string searchText)
        {
            // End any current editing to ensure that any new rows are properly created
            DataGridViewAddPersonToVehicle.EndEdit();
            DataGridViewAddPersonToVehicle.ClearSelection();
            // If the search text is empty or null, clear any selected rows and exit the method
            if (string.IsNullOrWhiteSpace(searchText))
            {
                DataGridViewAddPersonToVehicle.ClearSelection();

                // Make all rows visible if there is no search text
                foreach (DataGridViewRow row in DataGridViewAddPersonToVehicle.Rows)
                    if (!row.IsNewRow && !row.Frozen)
                        row.Visible = true;
                return;
            }

            // Split the search text on whitespace to search for each substring
            var searchTerms = searchText.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in DataGridViewAddPersonToVehicle.Rows)
                // Skip new rows that haven't been associated with an index yet
                if (!row.IsNewRow && !row.Frozen)
                {
                    var matchFound = true; // initialize to true outside of the inner loop

                    // Loop through each cell in the row and check if it contains any of the search terms
                    foreach (var term in searchTerms)
                    {
                        var termMatchFound = false;
                        // Loop through each column in the row and check if it contains the search term
                        foreach (DataGridViewCell cell in row.Cells)
                            if (cell.Value != null &&
                                cell.Value.ToString().IndexOf(term, StringComparison.OrdinalIgnoreCase) >= 0)
                            {
                                // If a match is found, mark the row as visible and break the inner loop
                                row.Visible = true;
                                termMatchFound = true;
                                break;
                            }

                        if (!termMatchFound)
                        {
                            // Check if the row is associated with the CurrencyManager position
                            var cm = (CurrencyManager)BindingContext[DataGridViewAddPersonToVehicle.DataSource];
                            if (cm.Position == row.Index) continue;
                            row.Visible = false;
                            matchFound = false;
                            break;
                        }
                    }

                    // If no match was found in the current row, mark it as not visible
                    if (!matchFound)
                    {
                        // Check if the row is associated with the CurrencyManager position
                        var cm = (CurrencyManager)BindingContext[DataGridViewAddPersonToVehicle.DataSource];
                        if (cm.Position == row.Index) continue;
                        row.Visible = false;
                    }
                }

            // Clear any selected rows if they are no longer visible
            if (DataGridViewAddPersonToVehicle.SelectedRows.Count > 0)
            {
                var selectionCleared = false;
                foreach (DataGridViewRow row in DataGridViewAddPersonToVehicle.SelectedRows)
                    if (!row.Visible)
                    {
                        row.Selected = false; // set Selected property to false
                        selectionCleared = true;
                    }

                if (!selectionCleared && !DataGridViewAddPersonToVehicle.SelectedRows[0].Displayed)
                    DataGridViewAddPersonToVehicle.ClearSelection();
            }
        }

    }
}
