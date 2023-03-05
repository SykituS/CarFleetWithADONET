using System.Windows.Forms;
using CarFleetDomain;
using CarFleetDomain.Functions;

namespace CarFleet.Views
{
    public partial class LoginForm : Form 
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            var o = new Context();

            o.TestCon();

            var u = new LoginSystem().LoginUser(TBLogin.Text, TBPassword.Text);
            
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
