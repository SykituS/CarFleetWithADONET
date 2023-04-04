using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CarFleet.Views.MainForms;
using CarFleetDomain.Functions;
using CarFleetDomain.Models;

namespace CarFleet.Views.VehicleForms
{
    public partial class CarDetailsForm : Form
    {
        private readonly int _vehicleID;
        private readonly Users _loggedUser;

        public CarDetailsForm(int vehicleID, Users loggedUser)
        {
            _vehicleID = vehicleID;
            _loggedUser = loggedUser;
            InitializeComponent();
        }

        private void CarDetailsForm_Load(object sender, EventArgs e)
        {
            LbWarning.Text = "";

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

        #region LoadingDataGridViews

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
                {
                    LbWarning.Text += response.Message;
                }
            }
            catch (Exception e)
            {
                LbWarning.Text += "Something went wrong while loading vehicle data! Please try again";
            }
        }

        private void SetUpVehiclePersonHistoryData(SqlCommand cmd, DataSet dataSet)
        {
            try
            {
                cmd.CommandText =
                    "SELECT veh.ID, Person.FirstName + ' ' + Person.LastName as 'Person', CreatedOn as 'Created On', CreatedBy.FirstName + ' ' + CreatedBy.LastName as 'Created By', UpdatedOn as 'Updated On', UpdatedBy.FirstName + ' ' + UpdatedBy.LastName as 'Updated By' FROM VehiclePersonHistory as veh join Persons as Person on veh.PersonID = Person.ID join Persons as CreatedBy on veh.CreatedByID = CreatedBy.ID join Persons as UpdatedBy on veh.UpdatedByID = UpdatedBy.ID where VehicleID = @vid order by CreatedOn desc";
                var response = VehiclePersonHistory.GetVehiclePersonHistoryQuery(dataSet, cmd);

                if (response.Success)
                {
                    DataGridViewPersonHistory.DataSource = dataSet.Tables[nameof(VehiclePersonHistory)];
                    DataGridViewPersonHistory.Columns[0].Visible = false;
                }
                else
                {
                    LbWarning.Text += response.Message;
                }
            }
            catch (Exception e)
            {
                LbWarning.Text += "Something went wrong while loading persons history! Please try again";
            }
        }

        private void SetUpVehicleMileageData(SqlCommand cmd, DataSet dataSet)
        {
            try
            {
                cmd.CommandText =
                    "SELECT Mileage, CreatedOn as 'Created On', CreatedBy.FirstName + ' ' + CreatedBy.LastName as 'Created By', UpdatedOn as 'Updated On', UpdatedBy.FirstName + ' ' + UpdatedBy.LastName as 'Updated By' FROM VehicleMileage as veh join Persons as CreatedBy on veh.CreatedByID = CreatedBy.ID join Persons as UpdatedBy on veh.UpdatedByID = UpdatedBy.ID where VehicleID = @vid order by CreatedOn desc";
                var response = VehicleMileage.GetVehicleMileageQuery(dataSet, cmd);

                if (response.Success)
                    DataGridViewMileageHistory.DataSource = dataSet.Tables[nameof(VehicleMileage)];
                else
                    LbWarning.Text += response.Message;
            }
            catch (Exception e)
            {
                LbWarning.Text += "Something went wrong while loading mileage! Please try again";
            }
        }

        private void SetUpVehicleInsurerData(SqlCommand cmd, DataSet dataSet)
        {
            try
            {
                cmd.CommandText =
                    "SELECT Insurer, StartDateOfInsurence as 'Start date', EndDateOfInsurence as 'End date', CreatedOn as 'Created On', CreatedBy.FirstName + ' ' + CreatedBy.LastName as 'Created By', UpdatedOn as 'Updated On', UpdatedBy.FirstName + ' ' + UpdatedBy.LastName as 'Updated By' FROM VehicleInsurer as veh join Persons as CreatedBy on veh.CreatedByID = CreatedBy.ID join Persons as UpdatedBy on veh.UpdatedByID = UpdatedBy.ID where VehicleID = @vid order by CreatedOn desc";
                var response = VehicleInsurer.GetVehicleInsurerQuery(dataSet, cmd);

                if (response.Success)
                    DataGridViewInsurerHistory.DataSource = dataSet.Tables[nameof(VehicleInsurer)];
                else
                    LbWarning.Text += response.Message;
            }
            catch (Exception e)
            {
                LbWarning.Text += "Something went wrong while loading insurence! Please try again";
            }
        }

        private void SetUpVehicleInspectionData(SqlCommand cmd, DataSet dataSet)
        {
            try
            {
                cmd.CommandText =
                    "SELECT DateOfInspection as 'Inspection date', DateOfNextInspection as 'Next inspection date', CreatedOn as 'Created On', CreatedBy.FirstName + ' ' + CreatedBy.LastName as 'Created By', UpdatedOn as 'Updated On', UpdatedBy.FirstName + ' ' + UpdatedBy.LastName as 'Updated By' FROM VehicleInspection as veh join Persons as CreatedBy on veh.CreatedByID = CreatedBy.ID join Persons as UpdatedBy on veh.UpdatedByID = UpdatedBy.ID where VehicleID = @vid order by CreatedOn desc";
                var response = VehicleInspection.GetVehicleInspectionQuery(dataSet, cmd);

                if (response.Success)
                    DataGridViewInspectionHistory.DataSource = dataSet.Tables[nameof(VehicleInspection)];
                else
                    LbWarning.Text += response.Message;
            }
            catch (Exception e)
            {
                LbWarning.Text += "Something went wrong while loading inspection! Please try again";
            }
        }

        private void SetUpVehicleDescriptionData(SqlCommand cmd, DataSet dataSet)
        {
            try
            {
                cmd.CommandText =
                    "SELECT veh.ID, veh.Description, veh.CreatedOn as 'Created On', CreatedBy.FirstName + ' ' + CreatedBy.LastName as 'Created By', veh.UpdatedOn as 'Updated On', UpdatedBy.FirstName + ' ' + UpdatedBy.LastName as 'Updated By' FROM VehicleDescription as veh join Persons as CreatedBy on veh.CreatedByID = CreatedBy.ID join Persons as UpdatedBy on veh.UpdatedByID = UpdatedBy.ID where VehicleID = @vid order by CreatedOn desc";
                var response = VehicleDescription.GetVehicleDescriptionQuery(dataSet, cmd);

                if (response.Success)
                {
                    DataGridViewDescriptionHistory.DataSource = dataSet.Tables[nameof(VehicleDescription)];

                    var btnEdit = new DataGridViewButtonColumn();
                    btnEdit.Text = "Edit";
                    btnEdit.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    btnEdit.UseColumnTextForButtonValue = true;
                    btnEdit.Tag = (Action<int>)BtnEditDescriptionHandler;
                    DataGridViewDescriptionHistory.Columns.Add(btnEdit);
                    var btnDelete = new DataGridViewButtonColumn();
                    btnDelete.Text = "Remove";
                    btnDelete.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    btnDelete.UseColumnTextForButtonValue = true;
                    btnDelete.Tag = (Action<int>)BtnDeleteDescriptionHandler;
                    DataGridViewDescriptionHistory.Columns.Add(btnDelete);


                    DataGridViewDescriptionHistory.Columns[0].Visible = false;
                    DataGridViewDescriptionHistory.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                else
                {
                    LbWarning.Text += response.Message;
                }
            }
            catch (Exception e)
            {
                LbWarning.Text += "Something went wrong while loading description! Please try again";
            }
        }

        private void SetUpVehicleStatusData(SqlCommand cmd, DataSet dataSet)
        {
            try
            {
                cmd.CommandText =
                    "Select veh.Status, CreatedOn as 'Created On', CreatedBy.FirstName + ' ' + CreatedBy.LastName as 'Created By' from VehicleStatus as veh join Persons as CreatedBy on veh.CreatedByID = CreatedBy.ID where VehicleID = @vid order by CreatedOn desc";
                var response = VehicleStatus.GetVehicleStatusQuery(dataSet, cmd);

                if (response.Success)
                    DataGridViewStatusHistory.DataSource = dataSet.Tables[nameof(VehicleStatus)];
                else
                    LbWarning.Text += response.Message;
            }
            catch (Exception e)
            {
                LbWarning.Text += "Something went wrong while loading status! Please try again";
            }
        }

        private void DataGridViewStatusHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.Value == null) return;

                if (DataGridViewStatusHistory.Columns[e.ColumnIndex].Name == "Status")
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
            }
            catch (Exception ex)
            {
                e.Value = "No data";
            }
        }
        #endregion

        #region DataGridViewButtonHandlers

        private void DataGridViewDescriptionHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var grid = (DataGridView)sender;

                if (e.RowIndex < 0) return; //Run if header column was clicked

                if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
                {
                    var clickHandler = (Action<int>)grid.Columns[e.ColumnIndex].Tag;
                    var descriptionID = (int)grid["ID", e.RowIndex].Value;

                    clickHandler(descriptionID);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessageBox.Show("Something went wrong! Please try again or contact with IT support team!", "Error",
                    MessageBoxButtons.OK);
            }
        }

        private void BtnEditDescriptionHandler(int descriptionID)
        {
            var addOrEditDescription = new AddOrEditDescriptionForm(descriptionID, _vehicleID, _loggedUser);
            var mainForm = (MainAdministrationForm)ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm?.loadForm(addOrEditDescription);
            //var form = new AddOrEditDescriptionForm(0, _vehicleID, loggedUser);
            //form.Show();
        }

        private void BtnDeleteDescriptionHandler(int descriptionID)
        {
            var result = MessageBox.Show("Do you want to delete this row?", "", MessageBoxButtons.OKCancel);

            if (result != DialogResult.OK) return;

            var response = VehicleDescription.DeleteVehicleCommand(descriptionID);

            var dataSet = new DataSet();
            var cmd = new SqlCommand();
            cmd.CommandText =
                "SELECT veh.ID, veh.Description, veh.CreatedOn as 'Created On', CreatedBy.FirstName + ' ' + CreatedBy.LastName as 'Created By', veh.UpdatedOn as 'Updated On', UpdatedBy.FirstName + ' ' + UpdatedBy.LastName as 'Updated By' FROM VehicleDescription as veh join Persons as CreatedBy on veh.CreatedByID = CreatedBy.ID join Persons as UpdatedBy on veh.UpdatedByID = UpdatedBy.ID where VehicleID = @vid order by CreatedOn desc";
            cmd.Parameters.AddWithValue("@vid", _vehicleID);
            VehicleDescription.GetVehicleDescriptionQuery(dataSet, cmd);
            DataGridViewDescriptionHistory.DataSource = dataSet.Tables[nameof(VehicleDescription)];

            MessageBox.Show(response.Message, "", MessageBoxButtons.OK);
        }

        #endregion

        #region Navigation

        private void BtnOpenEmployeeToVehicleForm_Click(object sender, EventArgs e)
        {
            //var form = new AddNewPersonToVehicleForm();
            //form.Show();
            var newPersonToVehicleForm = new AddNewPersonToVehicleForm(_vehicleID, _loggedUser);
            var mainForm = (MainAdministrationForm)ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm.loadForm(newPersonToVehicleForm);
        }

        private void BtnOpenStatusForm_Click(object sender, EventArgs e)
        {
            //var form = new ChangeVehicleStatusForm();
            //form.Show();
            var changeVehicleStatus = new ChangeVehicleStatusForm(_vehicleID, _loggedUser);
            var mainForm = (MainAdministrationForm)ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm?.loadForm(changeVehicleStatus);
        }

        private void BtnOpenMileageCheckForm_Click(object sender, EventArgs e)
        {
            //var form = new AddNewMileageCheckForm(_vehicleID, loggedUser);
            //form.Show();
            var addNewMileageCheck = new AddNewMileageCheckForm(_vehicleID, _loggedUser);
            var mainForm = (MainAdministrationForm)ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm?.loadForm(addNewMileageCheck);
        }

        private void BtnOpenInspectionForm_Click(object sender, EventArgs e)
        {
            var addNewInspection =
                new AddNewInspectionForm(_vehicleID, _loggedUser); // create instance of AddEmployeeForm
            var mainForm = (MainAdministrationForm)ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm?.loadForm(addNewInspection);
            //var form = new AddNewInspectionForm(_vehicleID, loggedUser);
            //form.Show();
        }

        private void BtnOpenInsurenceForm_Click(object sender, EventArgs e)
        {
            var addOrEditInsurence = new AddNewInsurenceForm(0, _vehicleID, _loggedUser);
            var mainForm = (MainAdministrationForm)ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm?.loadForm(addOrEditInsurence);
            //var form = new AddOrEditInsurenceForm(0, _vehicleID, loggedUser);
            //form.Show();
        }

        private void BtnOpenDescriptionForm_Click(object sender, EventArgs e)
        {
            var addOrEditDescription = new AddOrEditDescriptionForm(0, _vehicleID, _loggedUser);
            var mainForm = (MainAdministrationForm)ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm?.loadForm(addOrEditDescription);
            //var form = new AddOrEditDescriptionForm(0, _vehicleID, loggedUser);
            //form.Show();
        }

        private void BtnOpenEmployeeToVehicleForm_Click_1(object sender, EventArgs e)
        {
            //var form = new AddNewPersonToVehicleForm();
            //form.Show();
            var newPersonToVehicleForm = new AddNewPersonToVehicleForm(_vehicleID, _loggedUser);
            var mainForm = (MainAdministrationForm)ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm?.loadForm(newPersonToVehicleForm);
        }

        private void BtnOpenStatusForm_Click_1(object sender, EventArgs e)
        {
            //var form = new ChangeVehicleStatusForm();
            //form.Show();
            var changeVehicleStatus = new ChangeVehicleStatusForm(_vehicleID, _loggedUser);
            var mainForm = (MainAdministrationForm)ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm?.loadForm(changeVehicleStatus);
        }

        private void BtnOpenMileageCheckForm_Click_1(object sender, EventArgs e)
        {
            //var form = new AddNewMileageCheckForm(_vehicleID, loggedUser);
            //form.Show();
            var addNewMileageCheck = new AddNewMileageCheckForm(_vehicleID, _loggedUser);
            var mainForm = (MainAdministrationForm)ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm?.loadForm(addNewMileageCheck);
        }

        private void BtnOpenInspectionForm_Click_1(object sender, EventArgs e)
        {
            var addNewInspection =
                new AddNewInspectionForm(_vehicleID, _loggedUser); // create instance of AddEmployeeForm
            var mainForm = (MainAdministrationForm)ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm?.loadForm(addNewInspection);
            //var form = new AddNewInspectionForm(_vehicleID, loggedUser);
            //form.Show();
        }

        private void BtnOpenInsurenceForm_Click_1(object sender, EventArgs e)
        {
            var addOrEditInsurence = new AddNewInsurenceForm(0, _vehicleID, _loggedUser);
            var mainForm = (MainAdministrationForm)ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm?.loadForm(addOrEditInsurence);
            //var form = new AddOrEditInsurenceForm(0, _vehicleID, loggedUser);
            //form.Show();
        }

        private void BtnOpenDescriptionForm_Click_1(object sender, EventArgs e)
        {
            var addOrEditDescription = new AddOrEditDescriptionForm(0, _vehicleID, _loggedUser);
            var mainForm = (MainAdministrationForm)ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm?.loadForm(addOrEditDescription);
            //var form = new AddOrEditDescriptionForm(0, _vehicleID, loggedUser);
            //form.Show();
        }

        #endregion
    }
}