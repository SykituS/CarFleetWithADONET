using CarFleetDomain.Functions;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace CarFleet.Views
{
    public partial class EditEmployeeForm : Form
    {
        private readonly int _personID;
        private readonly Persons _persons;
        private readonly Context _context;
        private readonly Users _users;
        public EditEmployeeForm(int _personsID)
            
        {

            InitializeComponent();
            _personID = _personsID;
            FillCbBoxWithRoles();
            DisplayPerson(_personID);
            _users = new Users();

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
                ChBoxActive.Checked = person.Disabled;
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
                ChBoxActive.Checked = person.Disabled;
            }
            else
            {
                MessageBox.Show(personresponse.Message+" "+userresponse.Message);
            }
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
        private bool ValidateEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        private bool ValidatePassword(string password)
        {
            string pattern = "^(?=.*[A-Z])(?=.*\\d{2,})(?!.*\\s).{8,15}$";
            return Regex.IsMatch(password, pattern);

        }
        public DataResponse CheckData() {
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
            if (CbBox.SelectedItem==null)
            {

                sb.AppendLine("Please selectusers role");
                response.Success = false;
            }
            if (!SpecialCharrsValidation(TbFirstName.Text, TbLastName.Text))
            {
                sb.AppendLine("First name and last name can not contain any special characters!");
                response.Success = false;
            }



            if (TbPass.Text != TbConfirmPass.Text)
                {
                    sb.AppendLine("Password and confirm password must be equal");
                    response.Success = false;
                }
                if (!ValidatePassword(TbPass.Text))
                {
                    sb.AppendLine("Password must have betwen 8 to 15 digits, two numbers, and one uppercase letter");
                    response.Success = false;
                }
            
            response.Message= sb.ToString();
            return response;

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
            label6.Visible= true;
            EmployeeSystem employeeSystem = new EmployeeSystem();
            int id = _personID;
            string firstName=TbFirstName.Text;
            string lastName=TbLastName.Text;
            string phone=TbPhone.Text;
            string email=TbEmail.Text;
            bool disabled =ChBoxActive.Checked;
            var datachecked = CheckData();
            if (!datachecked.Success)
            { 
            label6.Text=datachecked.Message;
                return;
            
            }
           
            var response = employeeSystem.UpdateEmployee(id, firstName, lastName, phone, email,disabled);
                if (response.Success)
            {
                string userName=TbEmail.Text;
                string passwordHash = PasswordHasher.EncodePassword(TbPass.Text);
                int personID = _personID;
                int roleID = CbBox.SelectedIndex;
                var userresponse = employeeSystem.InesertorUpdateUser(personID, userName, passwordHash , roleID);
                 
                if(userresponse.Success)
                    {
                EmployeeListForm employeeListForm = new EmployeeListForm();  // create instance of AddEmployeeForm
                MainAdministrationForm mainForm = (MainAdministrationForm)this.ParentForm;  // get reference to the parent form

                // load AddEmployeeForm in the mainpanel of the parent form
                mainForm.loadForm(employeeListForm);

                    }
                    label6.Visible = true;
                    // Display the error message on the label
                    label6.Text = response.Message;

                



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
