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
    public partial class CarDetailsForm : Form
    {
        private int _vehicleID;
        public CarDetailsForm(int vehicleID)
        {
            _vehicleID = vehicleID;
            InitializeComponent();
        }

        private void CarDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
