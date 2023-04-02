using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using CarFleet.Views.MainForms;
using CarFleetDomain.Models;

namespace CarFleet.Views.VehicleForms
{
    public partial class CarListForm : Form
    {
        private readonly Users _loggedUser;

        public CarListForm(Users loggedUser)
        {
            _loggedUser = loggedUser;
            InitializeComponent();
        }

        private void CarListForm_Load(object sender, EventArgs e)
        {
            var dataSet = new DataSet();
            const string cmd = @"SELECT veh.id, veh.Manufacturer, veh.Model, (Select top(1) vehStatus.Status FROM [VehicleStatus] as vehStatus where vehStatus.VehicleID = veh.ID order by CreatedOn desc) as Status,
                            (SELECT top(1) p.FirstName + ' ' + p.LastName FROM VehiclePersonHistory as vehPerson JOIN Persons as p on p.ID = vehPerson.PersonID WHERE vehPerson.VehicleID = veh.ID ORDER BY vehPerson.CreatedOn desc) as 'Used by',
                            veh.ProductionYear as 'Production Year', veh.LicensePlate as 'License Plate', veh.VinNumber as 'Vin Number', (Select top(1) vehInspection.DateOfnextInspection from VehicleInspection as vehInspection where vehInspection.VehicleID = veh.ID Order by vehInspection.CreatedOn desc) as NextInspection, 
                            (Select top(1) vehInsurer.EndDateOfInsurence from VehicleInsurer as vehInsurer where vehInsurer.VehicleID = veh.ID Order by vehInsurer.CreatedOn desc) as Insurence FROM Vehicle as veh";

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

        private void BtnViewVehicleDetailsHandler(int id)
        {
            var carDetails = new CarDetailsForm(id, _loggedUser);
            var mainForm = (MainAdministrationForm)ParentForm;
            mainForm?.loadForm(carDetails);
            //var form = new CarDetailsForm(id, loggedUser);
            //form.Show();
        }

        private void DataGridViewVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var grid = (DataGridView)sender;

                if (e.RowIndex < 0) return; //Run if header column was clicked

                if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
                {
                    var clickHandler = (Action<int>)grid.Columns[e.ColumnIndex].Tag;
                    var vehicleID = (int)grid["ID", e.RowIndex].Value;

                    clickHandler(vehicleID);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessageBox.Show("Something went wrong! Please try again or contact with IT support team!", "Error",
                    MessageBoxButtons.OK);
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
                    var enumString = "No data";
                    switch (enumValue)
                    {
                        case VehicleStatusEnum.Free:
                            enumString = "Free";
                            e.CellStyle.BackColor = Color.Chartreuse;
                            break;
                        case VehicleStatusEnum.Reserved:
                            enumString = "Reserved";
                            e.CellStyle.BackColor = Color.Gray;
                            break;
                        case VehicleStatusEnum.InUse:
                            enumString = "InUse";
                            e.CellStyle.BackColor = Color.MediumVioletRed;
                            break;
                        case VehicleStatusEnum.InService:
                            enumString = "InService";
                            e.CellStyle.BackColor = Color.CadetBlue;
                            break;
                        case VehicleStatusEnum.EoL:
                            enumString = "EoL";
                            e.CellStyle.BackColor = Color.DimGray;
                            break;
                    }

                    e.Value = enumString;
                }

                if (DataGridViewVehicles.Columns[e.ColumnIndex].Name == "Used by")
                {
                    var status = (VehicleStatusEnum)DataGridViewVehicles.Rows[e.RowIndex].Cells[e.ColumnIndex-1].Value;

                    switch (status)
                    {
                        case VehicleStatusEnum.Free:
                            e.Value = " ---- ";
                            break;
                        case VehicleStatusEnum.EoL:
                            e.Value = " ---- ";
                            break;
                    }

                    var value = (string)e.Value;
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        e.Value = "----";
                    }
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

        private void BtnAddNewVehicle_Click(object sender, EventArgs e)
        {
            var addNewVehicleForm = new AddNewVehicleForm(_loggedUser); // create instance of AddEmployeeForm
            var mainForm = (MainAdministrationForm)ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm?.loadForm(addNewVehicleForm);
        }
    }
}