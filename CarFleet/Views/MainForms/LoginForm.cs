using System.Windows.Forms;
using CarFleetDomain.Functions;
using CarFleetDomain.Models;

namespace CarFleet.Views.MainForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            var response = new LoginSystem().LoginUser(TBLogin.Text, TBPassword.Text);

            if (response.Success)
            {
                switch (response.ReturnedValue.RoleID)
                {
                    case (int)RoleEnum.Employee:
                        //new MainEmployeeForms().Show();
                        MessageBox.Show("Sorry, but you don't have access to this application yet!", "Error",
                            MessageBoxButtons.OK);
                        break;
                    case (int)RoleEnum.Admin:
                        new MainAdministrationForm(response.ReturnedValue).Show();
                        break;
                }
            }
            else
            {
                LabelInfo.Visible = true;
                LabelInfo.Text = response.Message;
            }
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
