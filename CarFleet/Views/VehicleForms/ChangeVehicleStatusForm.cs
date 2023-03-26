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

        private void BtnAddInspection_Click(object sender, EventArgs e)
        {
            VehicleStatusEnum status;
            Enum.TryParse<VehicleStatusEnum>(CBoxVehicleStatus.SelectedValue.ToString(), out status);
        }

        
    }
}
