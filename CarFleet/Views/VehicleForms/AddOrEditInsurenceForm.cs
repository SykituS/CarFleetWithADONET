using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarFleet.Views.VehicleForms
{
    public partial class AddOrEditInsurenceForm : Form
    {
        private readonly int _insurenceID;
        public AddOrEditInsurenceForm(int insurenceID)
        {
            _insurenceID = insurenceID;
            InitializeComponent();
        }

        private void AddOrEditInsurenceForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddInsurence_Click(object sender, EventArgs e)
        {

        }
    }
}
