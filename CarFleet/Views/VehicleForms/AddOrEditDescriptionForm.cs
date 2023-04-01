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
        public AddOrEditDescriptionForm(int descriptionID, int vehicleID, Users loggedUser)
        {
            _descriptionID = descriptionID;
            _vehicleID = vehicleID;
            _loggedUser = loggedUser;
            InitializeComponent();
        }

        private void AddOrEditDescriptionForm_Load(object sender, EventArgs e)
        {

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
            var response = VehicleSystem.InsertNewVehicleDescription(dataSet,
                                                                    _vehicleID,
                                                                    _loggedUser,
                                                                    RichTextBoxDescription.Text);

            if (response.Success)
            {
                LabelWarning.Text = "Mileage successfully added!";
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
