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
        private bool ValidateEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        public bool SpecialCharrsValidation(string firstName, string lastName)
        {
            string pattern = @"^[a-zA-Z]+$";
       
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(firstName) && regex.IsMatch(lastName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataResponse CheckData()
        {
            EmployeeSystem employee = new EmployeeSystem();
            var sb = new StringBuilder();
            var response = new DataResponse
            {
                Success = true,
            };
            if (string.IsNullOrWhiteSpace(TbFirstName.Text) ||
               string.IsNullOrWhiteSpace(TbLastName.Text) ||
               string.IsNullOrWhiteSpace(TbPhone.Text) ||
               string.IsNullOrWhiteSpace(TbEmail.Text))
            {
                sb.AppendLine("Please fill in all fields");
                response.Success = false;
            }
            if (TbFirstName.Text.Length <= 4 || TbFirstName.Text.Length > 255 ||
                TbLastName.Text.Length <= 4 || TbLastName.Text.Length > 255 ||
                TbEmail.Text.Length <= 4 || TbEmail.Text.Length > 255)
            {

                sb.AppendLine("First name, last name, email must contain between 5 to 255digits");
                response.Success = false;
            }
            if (TbFirstName.Text.Any(char.IsDigit) || TbLastName.Text.Any(char.IsDigit))
            {

                sb.AppendLine("First and last name cannot contain numbers");
                response.Success = false;
            }
            if (TbPhone.Text.Length != 9 || !TbPhone.Text.All(char.IsDigit))
            {

                sb.AppendLine("Phone number must have 9 digits and contain only numbers");
                response.Success = false;
            }
            if (!ValidateEmail(TbEmail.Text))
            {

                sb.AppendLine("Email is not in a valid format");
                response.Success = false;
            }
            if (CbBox.SelectedItem == null)
            {

                sb.AppendLine("Please selectusers role");
                response.Success = false;
            }

            if (!SpecialCharrsValidation(TbFirstName.Text, TbLastName.Text))
            {
                sb.AppendLine("First name and last name can not contain any special characters!");
                response.Success = false;
            }


           

            response.Message = sb.ToString();
            return response;

        }
        private void BtnNewEmplyee_Click_1(object sender, EventArgs e)
        {
            label6.Visible = true;
            EmployeeSystem employeeSystem = new EmployeeSystem();
            string firstName = TbFirstName.Text;
            string lastName = TbLastName.Text;
            string phone = TbPhone.Text;
            string email = TbEmail.Text;
            int roleID=CbBox.SelectedIndex;

            bool disabled =chBoxActive.Checked;
            var datachecked = CheckData();
            if (!datachecked.Success)
            {
                label6.Text = datachecked.Message;
                return;

            }

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
