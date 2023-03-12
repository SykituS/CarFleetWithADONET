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

namespace CarFleet.Views
{
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
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
        }

        private void DataGridViewEmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            EditEmployeeForm editEmployeeForm = new EditEmployeeForm();  // create instance of AddEmployeeForm
            MainAdministrationForm mainForm = (MainAdministrationForm)this.ParentForm;  // get reference to the parent form

            // load AddEmployeeForm in the mainpanel of the parent form
            mainForm.loadForm(editEmployeeForm);
        }
    }
}
