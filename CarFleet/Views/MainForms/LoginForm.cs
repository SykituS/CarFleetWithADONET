﻿using System.Windows.Forms;
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
                switch (response.ReturnedValue.Role)
                {
                    case RoleEnum.Employee:
                        new MainAdministrationForm(response.ReturnedValue).Show();
                        break;
                    case RoleEnum.Admin:
                        new MainEmployeeForms().Show();
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
