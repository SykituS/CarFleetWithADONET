using CarFleetDomain.Models;
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
    public partial class ChangeVehicleStatusForm : Form
    {
        private readonly int vehicleID;
        private readonly Users loggedUser;

        public ChangeVehicleStatusForm()
        {
            InitializeComponent();
        }

        private void ChangeVehicleStatusForm_Load(object sender, EventArgs e)
        {
            CBoxVehicleStatus.DataSource = Enum.GetValues(typeof(VehicleStatusEnum));
        }

        //private void BtnAddInspection_Click(object sender, EventArgs e)
        //{
        //    VehicleStatusEnum status;
        //    Enum.TryParse<VehicleStatusEnum>(CBoxVehicleStatus.SelectedValue.ToString(), out status);
        //}

        private void BtnAddInspection_Click_1(object sender, EventArgs e)
        {
            VehicleStatusEnum status;
            Enum.TryParse<VehicleStatusEnum>(CBoxVehicleStatus.SelectedValue.ToString(), out status);

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CarDetailsForm carDetails = new CarDetailsForm(vehicleID, loggedUser);  // create instance of AddEmployeeForm
            MainAdministrationForm mainForm = (MainAdministrationForm)this.ParentForm;  // get reference to the parent form

            // load AddEmployeeForm in the mainpanel of the parent form
            mainForm.loadForm(carDetails);
        }
    }
}
