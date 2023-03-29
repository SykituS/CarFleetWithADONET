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
            DispalyData();
            DisplayButtonColumn();
        }

        private void DispalyData() {

            var data = new EmployeeSystem().GetEmployees();

            if (data.Message != null)
            {
                label1.Text = data.Message;
            }
            DataGridViewEmployeeList.DataSource = data.ReturnedValue.Tables["Persons"];
          
        }
        private void DisplayButtonColumn()
        {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Edit";
            editButtonColumn.HeaderText = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            DataGridViewEmployeeList.Columns.Add(editButtonColumn);

            // Add a new DataGridViewButtonColumn for the "Delete" button
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            DataGridViewEmployeeList.Columns.Add(deleteButtonColumn);

        }

        private void BtnAddEmployee_Click_1(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();  // create instance of AddEmployeeForm
            MainAdministrationForm mainForm = (MainAdministrationForm)this.ParentForm;  // get reference to the parent form

            // load AddEmployeeForm in the mainpanel of the parent form
            mainForm.loadForm(addEmployeeForm);

        }

        private void BtnEditEmployee_Click(object sender, EventArgs e)
        {


            
        }

        private void DataGridViewEmployeeList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewEmployeeList.Columns[e.ColumnIndex].Name == "Edit")
            {
                // Get the ID value from the corresponding row
                int id = (int)DataGridViewEmployeeList.Rows[e.RowIndex].Cells["ID"].Value;

                // Open a new instance of the EmployeeEditForm with that ID
                EditEmployeeForm editEmployeeForm = new EditEmployeeForm(id);  // create instance of AddEmployeeForm
                MainAdministrationForm mainForm = (MainAdministrationForm)this.ParentForm;  // get reference to the parent form
                mainForm.loadForm(editEmployeeForm);
            }
            if (DataGridViewEmployeeList.Columns[e.ColumnIndex].Name == "Delete")
            {
                EmployeeSystem employeeSystem = new EmployeeSystem();
                int id = (int)DataGridViewEmployeeList.Rows[e.RowIndex].Cells["ID"].Value;
                bool disabled = (bool)DataGridViewEmployeeList.Rows[e.RowIndex].Cells["Disabled"].Value;
                var response = employeeSystem.DisablePerson(id,disabled);
                if (response.Success)
                {
                    label2.Visible= false;
                    DispalyData();

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
            // If the search text is empty or null, clear any selected rows and exit the method
            if (string.IsNullOrWhiteSpace(searchText))
            {
                DataGridViewEmployeeList.ClearSelection();
                return;
            }
            // Loop through each row in the DataGridView
            foreach (DataGridViewRow row in DataGridViewEmployeeList.Rows)
            {
                // Get the values of the columns for the current row
             
                string fName = row.Cells["FirstName"].Value?.ToString();
                string lName = row.Cells["LastName"].Value?.ToString();
                string email = row.Cells["Email"].Value?.ToString();
                string phone = row.Cells["PhoneNumber"].Value?.ToString();
               
                // Concatenate name and surname and check if it contains the search text
                string fullName = string.IsNullOrWhiteSpace(fName) || string.IsNullOrWhiteSpace(lName)
                    ? null
                    : $"{fName} {lName}";
                // Check if the Id column contains the search text
                if (
                   email?.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0    
                || fullName?.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0
                || phone?.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0
               
           )
                {
                    // If a match is found, select the row and scroll to it
                    row.Selected = true;
                    DataGridViewEmployeeList.FirstDisplayedScrollingRowIndex = DataGridViewEmployeeList.SelectedRows[0].Index;
                    return; // exit the method after the first match is found
                }
            }
            // If no match was found, clear any selected rows
            DataGridViewEmployeeList.ClearSelection();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
       SearchDataGridView(TbSearch.Text);
        }
    }
    }

