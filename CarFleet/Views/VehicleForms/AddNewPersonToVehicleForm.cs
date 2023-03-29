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
    public partial class AddNewPersonToVehicleForm : Form
    {
        public AddNewPersonToVehicleForm()
        {
            InitializeComponent();
        }

        private void BtnAddInspection_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //CarDetailsForm carDetails = new CarDetailsForm(_vehicleID, _loggedUser);  // create instance of AddEmployeeForm
            //MainAdministrationForm mainForm = (MainAdministrationForm)this.ParentForm;  // get reference to the parent form

            //// load AddEmployeeForm in the mainpanel of the parent form
            //mainForm.loadForm(carDetails);
        }

       
    }
}
