using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CarFleet.Views.MainForms;
using CarFleetDomain;
using CarFleetDomain.Functions;
using CarFleetDomain.Models;

namespace CarFleet.Views.EmployeeForms
{
    public partial class EditEmployeeForm : Form
    {
        private readonly int _personID;

        public EditEmployeeForm(int personsID)
        {
            InitializeComponent();
            _personID = personsID;
            FillCbBoxWithRoles();
            DisplayPerson(_personID);
        }

        private void DisplayPerson(int id)
        {
            var personResponse = EmployeeSystem.GetPersonWithRole(id, Context.ConnectionString);
            var userResponse = EmployeeSystem.GetUserRole(id, Context.ConnectionString);
            if (personResponse.Success && userResponse.Success)
            {
                var person = personResponse.ReturnedValue;
                var user = userResponse.ReturnedValue;
                TbFirstName.Text = person.FirstName;
                TbLastName.Text = person.LastName;
                TbPhone.Text = person.PhoneNumber;
                TbEmail.Text = person.Email;
                ChBoxActive.Checked = person.Disabled;
                CbBox.SelectedItem = Enum.GetName(typeof(RoleEnum), user.RoleID);
            }
            else if (personResponse.Success)
            {
                var person = personResponse.ReturnedValue;
                TbFirstName.Text = person.FirstName;
                TbLastName.Text = person.LastName;
                TbPhone.Text = person.PhoneNumber;
                TbEmail.Text = person.Email;
                ChBoxActive.Checked = person.Disabled;
            }
            else
            {
                MessageBox.Show(personResponse.Message + " " + userResponse.Message);
            }
        }

        private bool SpecialCharsValidation(string firstName, string lastName)
        {
            var pattern = @"^[a-zA-Z]+$";

            var regex = new Regex(pattern);

            if (regex.IsMatch(firstName) && regex.IsMatch(lastName))
                return true;
            return false;
        }

        private bool ValidateEmail(string email)
        {
            var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private bool ValidatePassword(string password)
        {
            var pattern = "^(?=.*[A-Z])(?=.*\\d{2,})(?!.*\\s).{8,15}$";
            return Regex.IsMatch(password, pattern);
        }

        private DataResponse CheckData()
        {
            var sb = new StringBuilder();
            var response = new DataResponse
            {
                Success = true
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
                sb.AppendLine("Please select users role");
                response.Success = false;
            }

            if (!SpecialCharsValidation(TbFirstName.Text, TbLastName.Text))
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
                sb.AppendLine("Password must have between 8 to 15 digits, two numbers, and one uppercase letter");
                response.Success = false;
            }

            response.Message = sb.ToString();
            return response;
        }

        private void FillCbBoxWithRoles()
        {
            CbBox.DataSource = Enum.GetValues(typeof(RoleEnum));
        }

        private void BtnNewEmployee_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            var employeeSystem = new EmployeeSystem();
            var firstName = TbFirstName.Text;
            var lastName = TbLastName.Text;
            var phone = TbPhone.Text;
            var email = TbEmail.Text;
            var disabled = ChBoxActive.Checked;
            var dataChecked = CheckData();

            if (!dataChecked.Success)
            {
                label6.Text = dataChecked.Message;
                return;
            }

            var response = employeeSystem.UpdateEmployee(_personID, firstName, lastName, phone, email, disabled);
            if (response.Success)
            {
                if (string.IsNullOrWhiteSpace(TbPass.Text) && string.IsNullOrWhiteSpace(TbConfirmPass.Text))
                    GoBackToParentForm();

                var userName = TbEmail.Text;
                var passwordHash = PasswordHasher.EncodePassword(TbPass.Text);
                var roleID = CbBox.SelectedIndex;
                var userResponse = employeeSystem.InsertOrUpdateUser(_personID, userName, passwordHash, roleID);

                if (userResponse.Success) GoBackToParentForm();

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
            GoBackToParentForm();
        }

        private void GoBackToParentForm()
        {
            var employeeListForm = new EmployeeListForm(); // create instance of AddEmployeeForm
            var mainForm = (MainAdministrationForm)ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm?.loadForm(employeeListForm);
        }

        private void CbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}