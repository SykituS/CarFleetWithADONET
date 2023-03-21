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
using CarFleetDomain.Models;

namespace CarFleet.Views
{
    public partial class AddNewVehicleForm : Form
    {
        private Users loggedUser;

        public AddNewVehicleForm(Users user)
        {
            this.loggedUser = user;
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var dataSet = new DataSet();
                Vehicle.GetVehicleQuery(dataSet);
                var row = dataSet.Tables[nameof(Vehicle)].NewRow();

                row[nameof(Vehicle.LicensePlate)] = TBLicensePlate.Text;
                row[nameof(Vehicle.Manufacturer)] = TBManufacturer.Text;
                row[nameof(Vehicle.Model)] = TBModel.Text;
                row[nameof(Vehicle.VinNumber)] = TBVinNumber.Text;
                row[nameof(Vehicle.ProductionYear)] = DateTimePickerProductionYear.Value.Year;
                row[nameof(Vehicle.CreatedByID)] = loggedUser.ID;
                row[nameof(Vehicle.CreatedOn)] = DateTime.Now;
                row[nameof(Vehicle.UpdatedByID)] = loggedUser.ID;
                row[nameof(Vehicle.UpdatedOn)] = DateTime.Now;

                dataSet.Tables[nameof(Vehicle)].Rows.Add(row);
                Vehicle.InsertVehicleCommand(dataSet);
                var vehicleID = (int)dataSet.Tables[nameof(Vehicle)].AsEnumerable().Last().ItemArray[0];
                dataSet.Tables.Clear();

                VehicleMileage.GetVehicleMileageQuery(dataSet);
                row = dataSet.Tables[nameof(VehicleMileage)].NewRow();

                row[nameof(VehicleMileage.Mileage)] = (int)NumericUDMileage.Value;
                row[nameof(VehicleMileage.VehicleID)] = vehicleID;
                row[nameof(VehicleMileage.CreatedByID)] = loggedUser.ID;
                row[nameof(VehicleMileage.CreatedOn)] = DateTime.Now;
                row[nameof(VehicleMileage.UpdatedByID)] = loggedUser.ID;
                row[nameof(VehicleMileage.UpdatedOn)] = DateTime.Now;

                dataSet.Tables[nameof(VehicleMileage)].Rows.Add(row);
                VehicleMileage.InsertVehicleMileageCommand(dataSet);
                dataSet.Tables.Clear();

                VehicleInspection.GetVehicleInspectionQuery(dataSet);
                row = dataSet.Tables[nameof(VehicleInspection)].NewRow();

                row[nameof(VehicleInspection.DateOfInspection)] = DateTimePickerInsurenceStart.Value;
                row[nameof(VehicleInspection.DateOfNextInspection)] = DateTimePickerInsurenceEnd.Value;
                row[nameof(VehicleInspection.VehicleID)] = vehicleID;
                row[nameof(VehicleInspection.CreatedByID)] = loggedUser.ID;
                row[nameof(VehicleInspection.CreatedOn)] = DateTime.Now;
                row[nameof(VehicleInspection.UpdatedByID)] = loggedUser.ID;
                row[nameof(VehicleInspection.UpdatedOn)] = DateTime.Now;

                dataSet.Tables[nameof(VehicleInspection)].Rows.Add(row);
                VehicleInspection.InsertVehicleInspectionCommand(dataSet);
                dataSet.Tables.Clear();

                VehicleInsurer.GetVehicleInsurerQuery(dataSet);
                row = dataSet.Tables[nameof(VehicleInsurer)].NewRow();

                row[nameof(VehicleInsurer.Insurer)] = TBInsurer.Text;
                row[nameof(VehicleInsurer.StartDateOfInsurence)] = DateTimePickerInsurenceStart.Value;
                row[nameof(VehicleInsurer.EndDateOfInsurence)] = DateTimePickerInsurenceEnd.Value;
                row[nameof(VehicleInsurer.VehicleID)] = vehicleID;
                row[nameof(VehicleInsurer.CreatedByID)] = loggedUser.ID;
                row[nameof(VehicleInsurer.CreatedOn)] = DateTime.Now;
                row[nameof(VehicleInsurer.UpdatedByID)] = loggedUser.ID;
                row[nameof(VehicleInsurer.UpdatedOn)] = DateTime.Now;

                dataSet.Tables[nameof(VehicleInsurer)].Rows.Add(row);
                VehicleInsurer.InsertVehicleInsurerCommand(dataSet);
                dataSet.Tables.Clear();

                VehicleStatus.GetVehicleStatusQuery(dataSet);
                row = dataSet.Tables[nameof(VehicleStatus)].NewRow();

                row[nameof(VehicleStatus.Status)] = VehicleStatusEnum.Free;
                row[nameof(VehicleStatus.VehicleID)] = vehicleID;
                row[nameof(VehicleStatus.CreatedByID)] = loggedUser.ID;
                row[nameof(VehicleStatus.CreatedOn)] = DateTime.Now;

                dataSet.Tables[nameof(VehicleStatus)].Rows.Add(row);
                VehicleStatus.InsertVehicleStatusCommand(dataSet);
                dataSet.Tables.Clear();

                if (RichTextBoxDescription.TextLength > 0)
                {
                    VehicleDescription.GetVehicleDescriptionQuery(dataSet);
                    row = dataSet.Tables[nameof(VehicleDescription)].NewRow();

                    row[nameof(VehicleDescription.Description)] = RichTextBoxDescription.Text;
                    row[nameof(VehicleDescription.VehicleID)] = vehicleID;
                    row[nameof(VehicleDescription.CreatedByID)] = loggedUser.ID;
                    row[nameof(VehicleDescription.CreatedOn)] = DateTime.Now;
                    row[nameof(VehicleDescription.UpdatedByID)] = loggedUser.ID;
                    row[nameof(VehicleDescription.UpdatedOn)] = DateTime.Now; 
                   
                    dataSet.Tables[nameof(VehicleDescription)].Rows.Add(row);
                    VehicleDescription.InsertVehicleDescriptionCommand(dataSet);
                    dataSet.Tables.Clear();
                }


            }
            catch (Exception exception)
            {
                LabelWarning.Visible = true;
                LabelWarning.Text = "Something went wrong!";
            }
        }
    }
}
