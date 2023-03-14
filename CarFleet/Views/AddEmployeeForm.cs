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
        }
        private bool ValidateEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
    

     

    


        private void BtnNewEmplyee_Click_1(object sender, EventArgs e)
        {

            try
            {
                // Check that all input fields are filled in
                if (string.IsNullOrWhiteSpace(TbFirstName.Text) ||
                    string.IsNullOrWhiteSpace(TbLastName.Text) ||
                    string.IsNullOrWhiteSpace(TbPhone.Text) ||
                    string.IsNullOrWhiteSpace(TbEmail.Text))
                {
                    MessageBox.Show("Please fill in all fields");
                    return;
                }

                // Check that first and last name do not contain numbers
                if (TbFirstName.Text.Any(char.IsDigit) || TbLastName.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("First and last name cannot contain numbers");
                    return;
                }

                // Check that phone number has 9 digits and all of them are numbers
                if (TbPhone.Text.Length != 9 || !TbPhone.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Phone number must have 9 digits and contain only numbers");
                    return;
                }

                // Check that email is in a valid format
                if (!ValidateEmail(TbEmail.Text))
                {
                    MessageBox.Show("Email is not in a valid format");
                    return;
                }

                // Check that email is unique
                if (!_persons.IsEmailUnique(TbEmail.Text))
                {
                    MessageBox.Show("Email is already in use");
                    return;
                }

                // Create a new row with the input data
                var dataSet = new DataSet();
                Persons.GetPersonsQuery(dataSet);
                var row = dataSet.Tables[nameof(Persons)].NewRow();
                row["ID"] = 0;
                row["FirstName"] = TbFirstName.Text;
                row["LastName"] = TbLastName.Text;
                row["PhoneNumber"] = TbPhone.Text;
                row["Email"] = TbEmail.Text;
               
                // Add the new row to the Persons table and update the database
                dataSet.Tables[nameof(Persons)].Rows.Add(row);
                var response = Persons.InsertPersonsCommand(dataSet);

                // Check if the update was successful and show a message
                if (response.Success)
                {   // Get the new Person ID
                    var personID = dataSet.Tables[nameof(Persons)].AsEnumerable().Last().ItemArray[0];
                    var password = _users.GeneratePasswordHash(TbFirstName.Text,TbLastName.Text,TbPhone.Text);





                    // Check if the new Person ID exists in the Users table
                    var dataSetUser = new DataSet();
                    Users.GetUsersQuery(dataSetUser);
                    var usersTable = dataSetUser.Tables[nameof(Users)];
                    var userRow = usersTable.Select($"PersonID = {personID}").FirstOrDefault();
                    if (userRow == null)
                    {
                        // Create a new user with the same email as the Person
                        
                        var newUserRow = usersTable.NewRow();
                        newUserRow["UserName"] = TbEmail.Text;
                        newUserRow["PasswordHash"] = password;
                        newUserRow["PersonID"] = personID;
                        newUserRow["RoleID"] = 1;
                        usersTable.Rows.Add(newUserRow);
                        var usersResponse = Users.InsertUsersCommand(dataSetUser);
                        if (!usersResponse.Success)
                        {
                            MessageBox.Show("Error creating user: " + usersResponse.Message);
                            return;
                        }

                        MessageBox.Show("Employee added successfully");
                        TbFirstName.Clear();
                        TbLastName.Clear();
                        TbPhone.Clear();
                        TbEmail.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Error adding employee: " + response.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
