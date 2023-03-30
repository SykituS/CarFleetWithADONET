using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CarFleet.Views.MainForms;
using CarFleetDomain.Models;

namespace CarFleet.Views.VehicleForms
{
    public partial class CarListForm : Form
    {
        private readonly Users loggedUser;

        public CarListForm(Users loggedUser)
        {
            this.loggedUser = loggedUser;
            InitializeComponent();
        }

        private void CarListForm_Load(object sender, EventArgs e)
        {
            var dataSet = new DataSet();
            var cmd =
                "SELECT veh.id, veh.Manufacturer, veh.Model, (Select top(1) vehStatus.Status FROM [VehicleStatus] as vehStatus where vehStatus.VehicleID = veh.ID order by CreatedOn desc) as Status, " +
                "veh.ProductionYear, veh.LicensePlate, veh.VinNumber, (Select top(1) vehInspection.DateOfnextInspection from VehicleInspection as vehInspection where vehInspection.VehicleID = veh.ID Order by vehInspection.CreatedOn desc) as NextInspection, " +
                "(Select top(1) vehInsurer.EndDateOfInsurence from VehicleInsurer as vehInsurer where vehInsurer.VehicleID = veh.ID Order by vehInsurer.CreatedOn desc) as Insurence FROM Vehicle as veh";

            //TODO: Show vehicle person in dataGridView

            Vehicle.GetVehicleQuery(dataSet, new SqlCommand(cmd));
            DataGridViewVehicles.DataSource = dataSet.Tables[nameof(Vehicle)];

            var btnDetails = new DataGridViewButtonColumn();
            btnDetails.Text = "Details";
            btnDetails.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            btnDetails.UseColumnTextForButtonValue = true;
            btnDetails.Tag = (Action<int>)BtnViewVehicleDetailsHandler;
            DataGridViewVehicles.Columns.Add(btnDetails);
            DataGridViewVehicles.Columns[0].Visible = false;
        }


        private void BtnAddNewVehicle_Click(object sender, EventArgs e)
        {
            var addNewVehicleForm = new AddNewVehicleForm(loggedUser); // create instance of AddEmployeeForm
            var mainForm = (MainAdministrationForm)ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the mainpanel of the parent form
            mainForm.loadForm(addNewVehicleForm);
            //var form = new AddNewVehicleForm(loggedUser);
            //form.Show();
        }

        private void BtnViewVehicleDetailsHandler(int id)
        {
            var carDetails = new CarDetailsForm(id, loggedUser);
            var mainForm = (MainAdministrationForm)ParentForm;
            mainForm.loadForm(carDetails);
            //var form = new CarDetailsForm(id, loggedUser);
            //form.Show();
        }

        private void DataGridViewVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;

            if (e.RowIndex < 0) return; //Run if header column was clicked

            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                var clickHandler = (Action<int>)grid.Columns[e.ColumnIndex].Tag;
                var vehicleID = (int)grid[1, e.RowIndex].Value;

                clickHandler(vehicleID);
            }
        }

        private void DataGridViewVehicles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.Value == null) return;

                if (DataGridViewVehicles.Columns[e.ColumnIndex].Name == "Status")
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

                if (DataGridViewVehicles.Columns[e.ColumnIndex].Name == "NextInspection")
                {
                    var inspectionDate = (DateTime)e.Value;
                    if (inspectionDate <= DateTime.Now.AddDays(14))
                        DataGridViewVehicles.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
                }

                if (DataGridViewVehicles.Columns[e.ColumnIndex].Name == "Insurence")
                {
                    var insurenceDate = (DateTime)e.Value;
                    if (insurenceDate <= DateTime.Now.AddDays(14))
                        DataGridViewVehicles.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.IndianRed;
                }
            }
            catch (Exception ex)
            {
                e.Value = "No data";
            }
        }

        private void BtnAddNewVehicle_Click_1(object sender, EventArgs e)
        {
            var addNewVehicleForm = new AddNewVehicleForm(loggedUser); // create instance of AddEmployeeForm
            var mainForm = (MainAdministrationForm)ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the mainpanel of the parent form
            mainForm.loadForm(addNewVehicleForm);
            //var form = new AddNewVehicleForm(loggedUser);
            //form.Show();
        }
    }
}