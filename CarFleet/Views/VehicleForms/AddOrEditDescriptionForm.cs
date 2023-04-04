using CarFleetDomain.Functions;
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
using CarFleet.Views.MainForms;

namespace CarFleet.Views.VehicleForms
{
    public partial class AddOrEditDescriptionForm : Form
    {
        private readonly int _descriptionID;
        private readonly int _vehicleID;
        private readonly Users _loggedUser;
        private string DescriptionText { get; set; }

        public AddOrEditDescriptionForm(int descriptionID, int vehicleID, Users loggedUser)
        {
            _descriptionID = descriptionID;
            _vehicleID = vehicleID;
            _loggedUser = loggedUser;
            InitializeComponent();
        }

        private void AddOrEditDescriptionForm_Load(object sender, EventArgs e)
        {
            LabelWarning.Text = "";

            try
            {
                if (_descriptionID != 0)
                {
                    var dataSet = new DataSet();
                    var response = VehicleDescription.GetVehicleDescriptionQuery(dataSet);
                    if (response.Success)
                    {
                        DescriptionText = dataSet.Tables[nameof(VehicleDescription)].AsEnumerable().FirstOrDefault(_ => _.Field<int>(nameof(VehicleDescription.ID)) == _descriptionID)["Description"] as string;
                    }

                    RichTextBoxDescription.Text = DescriptionText;
                    BtnAddOrEditDescritpion.Text = "Edit";
                }
            }
            catch (Exception ex)
            {
                LabelWarning.Text = "Something went wrong while loading a description for edit! Please contact with IT support team";
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

            if (string.IsNullOrWhiteSpace(RichTextBoxDescription.Text))
            {
                sb.AppendLine("You need to provide a description");
                response.Success = false;
            }

            if (RichTextBoxDescription.Text.Length > 500)
            {
                sb.AppendLine("Given description is too long!");
                response.Success = false;
            }

            response.Message = sb.ToString();
            return response;
        }

        private void BtnAddOrEditDescription_Click(object sender, EventArgs e)
        {
            var returnedCheck = CheckGivenData();
            if (!returnedCheck.Success)
            {
                LabelWarning.Text = returnedCheck.Message;
                LabelWarning.ForeColor = Color.Red;
                return;
            }

            var dataSet = new DataSet();
            DataResponse response;
            if (_descriptionID != 0)
            {
                try
                {
                    response = VehicleDescription.GetVehicleDescriptionQuery(dataSet);
                    if (response.Success)
                    {
                        var row = dataSet.Tables[nameof(VehicleDescription)].AsEnumerable().FirstOrDefault(_ =>
                            _.Field<int>(nameof(VehicleDescription.ID)) == _descriptionID);

                        row["Description"] = RichTextBoxDescription.Text;
                        row["UpdatedOn"] = DateTime.Now;
                        row["UpdatedByID"] = _loggedUser.PersonID;

                        response = VehicleDescription.UpdateVehicleDescriptionCommand(dataSet);
                    }
                }
                catch (Exception ex)
                {
                    LabelWarning.Text = "Something went wrong! Please try again";
                    LabelWarning.ForeColor = Color.Red;
                    return;
                }
            }
            else
            {
                response = VehicleSystem.InsertNewVehicleDescription(dataSet,
                                                                        _vehicleID,
                                                                        _loggedUser,
                                                                        RichTextBoxDescription.Text);
            }
            if (response.Success)
            {
                LabelWarning.Text = "Description successfully added!";
                LabelWarning.ForeColor = Color.GreenYellow;
                GoBackToDetails();
            }
            else
            {
                LabelWarning.Text = response.Message;
                LabelWarning.ForeColor = Color.Red;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            GoBackToDetails();
        }

        private void GoBackToDetails()
        {
            var carDetails = new CarDetailsForm(_vehicleID, _loggedUser); // create instance of AddEmployeeForm
            var mainForm = (MainAdministrationForm)this.ParentForm; // get reference to the parent form

            // load AddEmployeeForm in the main panel of the parent form
            mainForm?.loadForm(carDetails);
        }
    }
}
