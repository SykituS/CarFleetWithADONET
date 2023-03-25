using CarFleetDomain.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CarFleet.Views.VehicleForms;
using CarFleetDomain.Functions;

namespace CarFleet.Views
{
    public partial class CarDetailsForm : Form
    {
        private readonly int _vehicleID;
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


            SetUpVehicleStatusData(cmd, dataSet);

            SetUpVehicleDescriptionData(cmd, dataSet);

            SetUpVehicleInspectionData(cmd, dataSet);

            SetUpVehicleInsurerData(cmd, dataSet);

            SetUpVehicleMileageData(cmd, dataSet);

            SetUpVehiclePersonHistoryData(cmd, dataSet);

            SetUpVehicleData(cmd, dataSet);
        }

        private void SetUpVehicleData(SqlCommand cmd, DataSet dataSet)
        {
            try
            {
                cmd.CommandText = "Select * from Vehicle where ID = @vid";
                var response = Vehicle.GetVehicleQuery(dataSet, cmd);
                if (response.Success)
                {
                    var sb = new StringBuilder();
                    var vehicle = CastObject.CreateItemFromRow<Vehicle>(dataSet.Tables[nameof(Vehicle)].Rows[0]);
                    sb.AppendLine($"Manufacturer: {vehicle.Manufacturer}");
                    sb.AppendLine($"Model: {vehicle.Model}");
                    sb.AppendLine($"License plate: {vehicle.LicensePlate}");
                    sb.AppendLine($"Vin number: {vehicle.VinNumber}");
                    sb.AppendLine($"Production year: {vehicle.ProductionYear}");

                    label7.Text = sb.ToString();
                }
                else
                    LaberWarning.Text += response.Message;
            }
            catch (Exception e)
            {
                LaberWarning.Text += "Something went wrong while loading vehicle data! Please try again";
            }
        }

        private void SetUpVehiclePersonHistoryData(SqlCommand cmd, DataSet dataSet)
        {
            try
            {
                cmd.CommandText = "SELECT veh.ID, Person.FirstName + ' ' + Person.LastName as 'Person', CreatedOn, CreatedBy.FirstName + ' ' + CreatedBy.LastName as 'Created By', UpdatedOn, UpdatedBy.FirstName + ' ' + UpdatedBy.LastName as 'Updated By' FROM VehiclePersonHistory as veh join Persons as Person on veh.PersonID = Person.ID join Persons as CreatedBy on veh.CreatedByID = CreatedBy.ID join Persons as UpdatedBy on veh.UpdatedByID = UpdatedBy.ID where VehicleID = @vid order by CreatedOn desc";
                var response = VehiclePersonHistory.GetVehiclePersonHistoryQuery(dataSet, cmd);

                if (response.Success)
                {
                    DataGridViewPersonHistory.DataSource = dataSet.Tables[nameof(VehiclePersonHistory)];
                    var btnRemove = new DataGridViewButtonColumn();
                    btnRemove.Text = "Edit";
                    btnRemove.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    btnRemove.UseColumnTextForButtonValue = true;
                    //btnDetails.Tag = (Action<int>)BtnViewVehicleDetailsHandler;
                    DataGridViewPersonHistory.Columns.Add(btnRemove);
                    DataGridViewPersonHistory.Columns[0].Visible = false;
                }
                else
                    LaberWarning.Text += response.Message;
            }
            catch (Exception e)
            {
                LaberWarning.Text += "Something went wrong while loading persons history! Please try again";
            }
        }

        private void SetUpVehicleMileageData(SqlCommand cmd, DataSet dataSet)
        {
            try
            {
                cmd.CommandText = "SELECT Mileage, CreatedOn, CreatedBy.FirstName + ' ' + CreatedBy.LastName as 'Created By', UpdatedOn, UpdatedBy.FirstName + ' ' + UpdatedBy.LastName as 'Updated By' FROM VehicleMileage as veh join Persons as CreatedBy on veh.CreatedByID = CreatedBy.ID join Persons as UpdatedBy on veh.UpdatedByID = UpdatedBy.ID where VehicleID = @vid order by CreatedOn desc";
                var response = VehicleMileage.GetVehicleMileageQuery(dataSet, cmd);

                if (response.Success)
                    DataGridViewMileageHistory.DataSource = dataSet.Tables[nameof(VehicleMileage)];
                else
                    LaberWarning.Text += response.Message;
            }
            catch (Exception e)
            {
                LaberWarning.Text += "Something went wrong while loading mileage! Please try again";
            }
        }

        private void SetUpVehicleInsurerData(SqlCommand cmd, DataSet dataSet)
        {
            try
            {
                cmd.CommandText = "SELECT Insurer, StartDateOfInsurence, EndDateOfInsurence, CreatedOn, CreatedBy.FirstName + ' ' + CreatedBy.LastName as 'Created By', UpdatedOn, UpdatedBy.FirstName + ' ' + UpdatedBy.LastName as 'Updated By' FROM VehicleInsurer as veh join Persons as CreatedBy on veh.CreatedByID = CreatedBy.ID join Persons as UpdatedBy on veh.UpdatedByID = UpdatedBy.ID where VehicleID = @vid order by CreatedOn desc";
                var response = VehicleInsurer.GetVehicleInsurerQuery(dataSet, cmd);

                if (response.Success)
                    DataGridViewInsurerHistory.DataSource = dataSet.Tables[nameof(VehicleInsurer)];
                else
                    LaberWarning.Text += response.Message;
            }
            catch (Exception e)
            {
                LaberWarning.Text += "Something went wrong while loading insurence! Please try again";
            }
        }

        private void SetUpVehicleInspectionData(SqlCommand cmd, DataSet dataSet)
        {
            try
            {
                cmd.CommandText = "SELECT DateOfInspection, DateOfNextInspection, CreatedOn, CreatedBy.FirstName + ' ' + CreatedBy.LastName as 'Created By', UpdatedOn, UpdatedBy.FirstName + ' ' + UpdatedBy.LastName as 'Updated By' FROM VehicleInspection as veh join Persons as CreatedBy on veh.CreatedByID = CreatedBy.ID join Persons as UpdatedBy on veh.UpdatedByID = UpdatedBy.ID where VehicleID = @vid order by CreatedOn desc";
                var response = VehicleInspection.GetVehicleInspectionQuery(dataSet, cmd);

                if (response.Success)
                    DataGridViewInspectionHistory.DataSource = dataSet.Tables[nameof(VehicleInspection)];
                else
                    LaberWarning.Text += response.Message;
            }
            catch (Exception e)
            {
                LaberWarning.Text += "Something went wrong while loading inspection! Please try again";
            }
        }

        private void SetUpVehicleDescriptionData(SqlCommand cmd, DataSet dataSet)
        {
            try
            {
                cmd.CommandText = "SELECT veh.ID, veh.Description, veh.CreatedOn, CreatedBy.FirstName + ' ' + CreatedBy.LastName as 'Created By', veh.UpdatedOn, UpdatedBy.FirstName + ' ' + UpdatedBy.LastName as 'Updated By' FROM VehicleDescription as veh join Persons as CreatedBy on veh.CreatedByID = CreatedBy.ID join Persons as UpdatedBy on veh.UpdatedByID = UpdatedBy.ID where VehicleID = @vid order by CreatedOn desc";
                var response = VehicleDescription.GetVehicleDescriptionQuery(dataSet, cmd);

                if (response.Success)
                {
                    DataGridViewDescriptionHistory.DataSource = dataSet.Tables[nameof(VehicleDescription)];
                    var btnEdit = new DataGridViewButtonColumn();
                    btnEdit.Text = "Edit";
                    btnEdit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    btnEdit.UseColumnTextForButtonValue = true;
                    //btnDetails.Tag = (Action<int>)BtnViewVehicleDetailsHandler;
                    DataGridViewDescriptionHistory.Columns.Add(btnEdit);

                    var btnDelete = new DataGridViewButtonColumn();
                    btnDelete.Text = "Remove";
                    btnDelete.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    btnDelete.UseColumnTextForButtonValue = true;
                    //btnDetails.Tag = (Action<int>)BtnViewVehicleDetailsHandler;
                    DataGridViewDescriptionHistory.Columns.Add(btnDelete);
                    DataGridViewDescriptionHistory.Columns[0].Visible = false;
                    DataGridViewDescriptionHistory.Columns["Description"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }
                else
                    LaberWarning.Text += response.Message;
            }
            catch (Exception e)
            {
                LaberWarning.Text += "Something went wrong while loading description! Please try again";
            }
        }

        private void SetUpVehicleStatusData(SqlCommand cmd, DataSet dataSet)
        {
            try
            {
                cmd.CommandText = "Select veh.Status, CreatedOn, CreatedBy.FirstName + ' ' + CreatedBy.LastName as 'Created By' from VehicleStatus as veh join Persons as CreatedBy on veh.CreatedByID = CreatedBy.ID where VehicleID = @vid order by CreatedOn desc";
                var response = VehicleStatus.GetVehicleStatusQuery(dataSet, cmd);

                if (response.Success)
                    DataGridViewStatusHistory.DataSource = dataSet.Tables[nameof(VehicleStatus)];
                else
                    LaberWarning.Text += response.Message;
            }
            catch (Exception e)
            {
                LaberWarning.Text += "Something went wrong while loading status! Please try again";
            }
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

        private void BtnOpenEmployeeToVehicleForm_Click(object sender, EventArgs e)
        {
            var form = new AddNewPersonToVehicleForm();
            form.Show();
        }

        private void BtnOpenStatusForm_Click(object sender, EventArgs e)
        {
            var form = new ChangeVehicleStatusForm();
            form.Show();
        }

        private void BtnOpenMileageCheckForm_Click(object sender, EventArgs e)
        {
            var form = new AddNewMileageCheckForm();
            form.Show();
        }

        private void BtnOpenInspectionForm_Click(object sender, EventArgs e)
        {
            var form = new AddNewInspectionForm();
            form.Show();
        }

        private void BtnOpenInsurenceForm_Click(object sender, EventArgs e)
        {
            var form = new AddOrEditInsurenceForm(0);
            form.Show();
        }

        private void BtnOpenDescriptionForm_Click(object sender, EventArgs e)
        {
            var form = new AddOrEditDescriptionForm(0);
            form.Show();
        }
    }
}
