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
using CarFleetDomain.Functions;

namespace CarFleet.Views.VehicleForms
{
    public partial class AddNewMileageCheckForm : Form
    {
        private readonly int vehicleID;
        private readonly Users loggedUser;


        public AddNewMileageCheckForm(int vehicleID, Users loggedUser)
        {
            this.vehicleID = vehicleID;
            this.loggedUser = loggedUser;
            InitializeComponent();
        }

        private void AddNewMileageCheckForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddInspection_Click(object sender, EventArgs e)
        {
            var returnedCheck = CheckGivenData();
            if (!returnedCheck.Success)
            {
                LabelWarning.Text = returnedCheck.Message;
                LabelWarning.ForeColor = Color.Red;
                return;
            }
            var dataSet = new DataSet();
            var response =
                VehicleSystem.InsertNewVehicleMileage(dataSet, vehicleID, loggedUser, (int)NumericUDMileage.Value);

            if (response.Success)
            {
                LabelWarning.Text = "Mileage successfully added!";
                LabelWarning.ForeColor = Color.GreenYellow;
            }
            else
            {
                LabelWarning.Text = response.Message;
                LabelWarning.ForeColor = Color.Red;
            }
        }

        private DataResponse CheckGivenData()
        {
            var sb = new StringBuilder();
            var response = new DataResponse
            {
                Success = true,
            };

            if (NumericUDMileage.Value < 1)
            {
                sb.AppendLine("Mileage can not be under 0");
                response.Success = false;
            }

            if (NumericUDMileage.DecimalPlaces != 0)
            {
                sb.AppendLine("Mileage can't contain any decimal places");
                response.Success = false;
            }

            response.Message = sb.ToString();
            return response;
        }
    }
}
