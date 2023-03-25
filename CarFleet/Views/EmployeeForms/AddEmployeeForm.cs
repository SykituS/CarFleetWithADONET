using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFleetDomain.Functions;
using CarFleetDomain.Models;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CarFleet.Views
{
    public partial class AddEmployeeForm : Form
    {
        private readonly Persons _persons;
        private readonly Users _users;
        public AddEmployeeForm()
        {
            InitializeComponent();
            _persons = new Persons();
            _users= new Users();
            FillCbBoxWithRoles();
        }

        private void FillCbBoxWithRoles()
        {
            RoleEnum[] roles = (RoleEnum[])Enum.GetValues(typeof(RoleEnum));
            foreach (RoleEnum role in roles)
            {
                CbBox.Items.Add(Enum.GetName(typeof(RoleEnum), role));
            }
        }
        private void BtnNewEmplyee_Click_1(object sender, EventArgs e)
        { EmployeeSystem employeeSystem = new EmployeeSystem();
            string firstName = TbFirstName.Text;
            string lastName = TbLastName.Text;
            string phone = TbPhone.Text;
            string email = TbEmail.Text;
            int roleID=CbBox.SelectedIndex;

            bool disabled =chBoxActive.Checked;

            var response = employeeSystem.InsertNewEmployee(firstName, lastName, phone, email,roleID,disabled);

            // Check the response to see if the insertion was successful or not
            if (response.Success)
            {
                // Display a success message on the label
                label6.Text = "Employee added successfully";
                // Clear the text boxes
                TbFirstName.Clear();
                TbLastName.Clear();
                TbPhone.Clear();
                TbEmail.Clear();
                
            }
            else
            {
                label6.Visible = true;
                // Display the error message on the label
                label6.Text = response.Message;
            }

            

        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {

            EmployeeListForm employeeListForm = new EmployeeListForm();  // create instance of AddEmployeeForm
            MainAdministrationForm mainForm = (MainAdministrationForm)this.ParentForm;  // get reference to the parent form

            // load AddEmployeeForm in the mainpanel of the parent form
            mainForm.loadForm(employeeListForm);
        }
    }
}
