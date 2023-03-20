using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarFleetDomain;
using CarFleetDomain.Functions;
using CarFleetDomain.Models;

namespace CarFleet.Views
{
    public partial class EmployeeListForm : Form
    {
        private readonly List<Persons> _personsList;
        public EmployeeListForm()
        {
            _personsList = new List<Persons>();
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            var data = new EmployeeSystem().GetEmployees();

            if (data.Message != null)
            {
                label1.Text = data.Message;
            }
            DataGridViewEmployeeList.DataSource = data.ReturnedValue.Tables["Persons"];
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
        }
        }
    }

