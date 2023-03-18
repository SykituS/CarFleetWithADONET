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

namespace CarFleet.Views
{
    public partial class EditEmployeeForm : Form
    {
        
        public EditEmployeeForm(Persons _persons)
            
        {
            InitializeComponent();
            int selectedPersonId = _persons.ID;
           

        }
        //public void DisplayPersonInfo(int personId)
        //{
        //    // Query the database to get the person's information based on the ID
        //    // Assume that you have a method in the Persons class to get a single person by ID
        //    Persons person = Persons.GetPersonById(personId);

        //    // Display the person's information in the TextBox
        //    txtPersonInfo.Text = "ID: " + person.ID + Environment.NewLine +
        //                          "First Name: " + person.FirstName + Environment.NewLine +
        //                          "Last Name: " + person.LastName + Environment.NewLine +
        //                          "Phone Number: " + person.PhoneNumber + Environment.NewLine +
        //                          "Email: " + person.Email;
        //}

        private void BtnNewEmplyee_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm();  // create instance of AddEmployeeForm
            MainAdministrationForm mainForm = (MainAdministrationForm)this.ParentForm;  // get reference to the parent form

            // load AddEmployeeForm in the mainpanel of the parent form
            mainForm.loadForm(employeeListForm);
        }
    }
}
