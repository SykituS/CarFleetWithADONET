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
    public partial class AddNewInspectionForm : Form
    {
        public AddNewInspectionForm()
        {
            InitializeComponent();
        }
        private void AddNewInspectionForm_Load(object sender, EventArgs e)
        {
            DateTimePickerNextInspection.Value = DateTime.Now.AddYears(1);
        }

        private void DateTimePickerInspection_ValueChanged(object sender, EventArgs e)
        {
            DateTimePickerNextInspection.Value = DateTimePickerInspection.Value.AddYears(1);
        }

        private void BtnAddInspection_Click(object sender, EventArgs e)
        {

        }
    }
}
