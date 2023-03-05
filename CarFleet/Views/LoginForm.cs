using System.Windows.Forms;
using CarFleetDomain;

namespace CarFleet.Views
{
    public partial class LoginForm : Form 
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            var o = new Context();

            o.TestCon();


        }
    }
}
