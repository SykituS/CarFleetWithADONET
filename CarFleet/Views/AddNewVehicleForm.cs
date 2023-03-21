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
    public partial class AddNewVehicleForm : Form
    {
        public AddNewVehicleForm()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            LabelWarning.Visible = true;
            LabelWarning.Text = "Something went wrong!";
        }
    }
}
