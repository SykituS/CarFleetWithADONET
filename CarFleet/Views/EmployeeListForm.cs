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
            DataGridViewEmployeeList.Columns.Add(new DataGridViewButtonColumn());
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


            if (DataGridViewEmployeeList.SelectedRows.Count > 0)
            {
                // Get the selected employee object
                var row = DataGridViewEmployeeList.SelectedRows[0];
                int selectedRow = Convert.ToInt32(DataGridViewEmployeeList.SelectedRows[0].Cells["ID"].Value);
                //Persons selectedPerson = _personsList.FirstOrDefault(p => p.ID == selectedRow);
                // Pass the selected employee object to the EditEmployeeForm


                //EditEmployeeForm editEmployeeForm = new EditEmployeeForm(selectedPerson);  // create instance of AddEmployeeForm
                //MainAdministrationForm mainForm = (MainAdministrationForm)this.ParentForm;  // get reference to the parent form
                //mainForm.loadForm(editEmployeeForm);
            }


            // load AddEmployeeForm in the mainpanel of the parent form

        }

        private void DataGridViewEmployeeList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
