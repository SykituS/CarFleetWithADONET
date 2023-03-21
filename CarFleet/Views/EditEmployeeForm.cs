﻿using CarFleetDomain.Functions;
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
using CarFleetDomain;
namespace CarFleet.Views
{
    public partial class EditEmployeeForm : Form
    {
        private readonly int _personID;
        private readonly Persons _persons;
        private readonly Context _context;

        public EditEmployeeForm(int _personsID)
            
        {
            InitializeComponent();
            _personID = _personsID;
            FillCbBoxWithRoles();
            DisplayPerson(_personID);

        }
       
        private void DisplayPerson(int id)
        {
            var personresponse = EmployeeSystem.GetPersonWithRole(id, Context.ConnectionString);
            var userresponse=EmployeeSystem.GetUserRole(id, Context.ConnectionString);
            if (personresponse.Success && userresponse.Success)
            {
                var person = personresponse.ReturnedValue;
                var user = userresponse.ReturnedValue;
                TbFirstName.Text = person.FirstName;
                TbLastName.Text = person.LastName;
                TbPhone.Text = person.PhoneNumber;
                TbEmail.Text = person.Email;
                CbBox.SelectedItem = Enum.GetName(typeof(RoleEnum), user.RoleID);

            }
            else if (personresponse.Success)
            {
                var person = personresponse.ReturnedValue;
                var user = userresponse.ReturnedValue;
                TbFirstName.Text = person.FirstName;
                TbLastName.Text = person.LastName;
                TbPhone.Text = person.PhoneNumber;
                TbEmail.Text = person.Email;
            }
            else
            {
                MessageBox.Show(personresponse.Message+" "+userresponse.Message);
            }
        }
      
        private void FillCbBoxWithRoles()
        {
            RoleEnum[] roles = (RoleEnum[])Enum.GetValues(typeof(RoleEnum));
            foreach (RoleEnum role in roles)
            {
                CbBox.Items.Add(Enum.GetName(typeof(RoleEnum), role));
            }
        }
        private void BtnNewEmplyee_Click(object sender, EventArgs e)
        {
            EmployeeSystem employeeSystem = new EmployeeSystem();
            int id = _personID;
            string firstName=TbFirstName.Text;
            string lastName=TbLastName.Text;
            string phone=TbPhone.Text;
            string email=TbEmail.Text;
            var response = employeeSystem.UpdateEmployee(id, firstName, lastName, phone, email);
                if (response.Success)
            {
                EmployeeListForm employeeListForm = new EmployeeListForm();  // create instance of AddEmployeeForm
                MainAdministrationForm mainForm = (MainAdministrationForm)this.ParentForm;  // get reference to the parent form

                // load AddEmployeeForm in the mainpanel of the parent form
                mainForm.loadForm(employeeListForm);


            }
            else
            {
                label6.Visible = true;
                // Display the error message on the label
                label6.Text = response.Message;


            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm();  // create instance of AddEmployeeForm
            MainAdministrationForm mainForm = (MainAdministrationForm)this.ParentForm;  // get reference to the parent form

            // load AddEmployeeForm in the mainpanel of the parent form
            mainForm.loadForm(employeeListForm);
        }

  

        private void CbBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
