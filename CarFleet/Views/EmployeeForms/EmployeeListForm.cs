using System;
using System.Windows.Forms;
using CarFleet.Views.MainForms;
using CarFleetDomain.Functions;

namespace CarFleet.Views.EmployeeForms
{
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            DisplayData();
            DisplayButtonColumn();
        }

        private void DisplayData()
        {
            var data = new EmployeeSystem().GetEmployees();

            if (data.Message != null) label1.Text = data.Message;
            DataGridViewEmployeeList.DataSource = data.ReturnedValue.Tables["Persons"];
        }

        private void DisplayButtonColumn()
        {
            var editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            DataGridViewEmployeeList.Columns.Add(editButtonColumn);

            // Add a new DataGridViewButtonColumn for the "Delete" button
            var deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Disable";
            deleteButtonColumn.Text = "Disable";
            deleteButtonColumn.HeaderText = "Disable";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            DataGridViewEmployeeList.Columns.Add(deleteButtonColumn);
        }

        private void BtnAddEmployee_Click_1(object sender, EventArgs e)
        {
            var addEmployeeForm = new AddEmployeeForm(); // create instance of AddEmployeeForm
            var mainForm = (MainAdministrationForm)ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm?.loadForm(addEmployeeForm);
        }

        private void BtnEditEmployee_Click(object sender, EventArgs e)
        {
        }

        private void DataGridViewEmployeeList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (DataGridViewEmployeeList.Columns[e.ColumnIndex].Name == "Edit")
            {
                // Get the ID value from the corresponding row
                var id = (int)DataGridViewEmployeeList.Rows[e.RowIndex].Cells["ID"].Value;

                // Open a new instance of the EmployeeEditForm with that ID
                var editEmployeeForm = new EditEmployeeForm(id); // create instance of AddEmployeeForm
                var mainForm = (MainAdministrationForm)ParentForm; // get reference to the parent form
                mainForm?.loadForm(editEmployeeForm);
            }

            if (DataGridViewEmployeeList.Columns[e.ColumnIndex].Name == "Disable")
            {
                var employeeSystem = new EmployeeSystem();
                var id = (int)DataGridViewEmployeeList.Rows[e.RowIndex].Cells["ID"].Value;
                var disabled = (bool)DataGridViewEmployeeList.Rows[e.RowIndex].Cells["Disabled"].Value;
                var response = employeeSystem.DisablePerson(id, disabled);
                if (response.Success)
                {
                    label2.Visible = false;
                    DisplayData();
                }
                else
                {
                    label2.Visible = true;
                    label2.Text = response.Message;
                }
            }
        }

        private void SearchDataGridView(string searchText)
        {
            // End any current editing to ensure that any new rows are properly created
            DataGridViewEmployeeList.EndEdit();
            DataGridViewEmployeeList.ClearSelection();
            // If the search text is empty or null, clear any selected rows and exit the method
            if (string.IsNullOrWhiteSpace(searchText))
            {
                DataGridViewEmployeeList.ClearSelection();

                // Make all rows visible if there is no search text
                foreach (DataGridViewRow row in DataGridViewEmployeeList.Rows)
                    if (!row.IsNewRow && !row.Frozen)
                        row.Visible = true;
                return;
            }

            // Split the search text on whitespace to search for each substring
            var searchTerms = searchText.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in DataGridViewEmployeeList.Rows)
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
                            var cm = (CurrencyManager)BindingContext[DataGridViewEmployeeList.DataSource];
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
                        var cm = (CurrencyManager)BindingContext[DataGridViewEmployeeList.DataSource];
                        if (cm.Position == row.Index) continue;
                        row.Visible = false;
                    }
                }

            // Clear any selected rows if they are no longer visible
            if (DataGridViewEmployeeList.SelectedRows.Count > 0)
            {
                var selectionCleared = false;
                foreach (DataGridViewRow row in DataGridViewEmployeeList.SelectedRows)
                    if (!row.Visible)
                    {
                        row.Selected = false; // set Selected property to false
                        selectionCleared = true;
                    }

                if (!selectionCleared && !DataGridViewEmployeeList.SelectedRows[0].Displayed)
                    DataGridViewEmployeeList.ClearSelection();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            SearchDataGridView(TbSearch.Text.ToLower());
        }
    }
}