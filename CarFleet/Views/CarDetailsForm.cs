using CarFleetDomain.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            LaberWarning.Text = "";

            var cmd = new SqlCommand();
            var dataSet = new DataSet();
            cmd.Parameters.AddWithValue("@vid", _vehicleID);

            cmd.CommandText = "Select * from VehicleStatus where VehicleID = @vid order by CreatedOn desc";
            var response = VehicleStatus.GetVehicleStatusQuery(dataSet, cmd);


            if (response.Success)
                DataGridViewStatusHistory.DataSource = dataSet.Tables[nameof(VehicleStatus)];
            else
                LaberWarning.Text += response.Message;

            cmd.CommandText = "Select * from VehicleDescription where VehicleID = @vid order by CreatedOn desc";
            response = VehicleDescription.GetVehicleDescriptionQuery(dataSet, cmd);

            if (response.Success)
                DataGridViewDescriptionHistory.DataSource = dataSet.Tables[nameof(VehicleDescription)];
            else
                LaberWarning.Text += response.Message;

            cmd.CommandText = "Select * from VehicleInspection where VehicleID = @vid order by CreatedOn desc";
            response = VehicleInspection.GetVehicleInspectionQuery(dataSet, cmd);

            if (response.Success)
                DataGridViewInspectionHistory.DataSource = dataSet.Tables[nameof(VehicleInspection)];
            else
                LaberWarning.Text += response.Message;

            cmd.CommandText = "Select * from VehicleInsurer where VehicleID = @vid order by CreatedOn desc";
            response = VehicleInsurer.GetVehicleInsurerQuery(dataSet, cmd);

            if (response.Success)
                DataGridViewInsurerHistory.DataSource = dataSet.Tables[nameof(VehicleInsurer)];
            else
                LaberWarning.Text += response.Message;

            cmd.CommandText = "Select * from VehicleMileage where VehicleID = @vid order by CreatedOn desc";
            response = VehicleMileage.GetVehicleMileageQuery(dataSet, cmd);

            if (response.Success)
                DataGridViewMileageHistory.DataSource = dataSet.Tables[nameof(VehicleMileage)];
            else
                LaberWarning.Text += response.Message;

            cmd.CommandText = "Select * from VehiclePersonHistory where VehicleID = @vid order by CreatedOn desc";
            response = VehiclePersonHistory.GetVehiclePersonHistoryQuery(dataSet, cmd);

            if (response.Success)
                DataGridViewPersonHistory.DataSource = dataSet.Tables[nameof(VehiclePersonHistory)];
            else
                LaberWarning.Text += response.Message;
        }

        private void DataGridViewStatusHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.Value == null)
                {
                    return;
                }

                if (DataGridViewStatusHistory.Columns[e.ColumnIndex].Name == "Status")
                {
                    var enumValue = (VehicleStatusEnum)e.Value;
                    var enumstring = "No data";
                    switch (enumValue)
                    {
                        case VehicleStatusEnum.Free:
                            enumstring = "Free";
                            e.CellStyle.BackColor = Color.Chartreuse;
                            break;
                        case VehicleStatusEnum.Reserved:
                            enumstring = "Reserved";
                            e.CellStyle.BackColor = Color.Gray;
                            break;
                        case VehicleStatusEnum.InUse:
                            enumstring = "InUse";
                            e.CellStyle.BackColor = Color.MediumVioletRed;
                            break;
                        case VehicleStatusEnum.InService:
                            enumstring = "InService";
                            e.CellStyle.BackColor = Color.CadetBlue;
                            break;
                        case VehicleStatusEnum.EoL:
                            enumstring = "EoL";
                            e.CellStyle.BackColor = Color.DimGray;
                            break;
                    }
                    e.Value = enumstring;
                }
            }
            catch (Exception ex)
            {
                e.Value = "No data";
            }
        }
    }
}
