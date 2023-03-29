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
        private readonly int vehicleID;
        private readonly Users loggedUser;
        public AddOrEditDescriptionForm(int descriptionID, int vehicleID, Users loggedUser)
        {
            _descriptionID = descriptionID;
            this.vehicleID = vehicleID;
            this.loggedUser = loggedUser;
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

        private void BtnAddOrEditDescritpion_Click(object sender, EventArgs e)
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
                                                                    vehicleID,
                                                                    loggedUser,
                                                                    RichTextBoxDescription.Text);

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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CarDetailsForm carDetails = new CarDetailsForm(vehicleID, loggedUser);  // create instance of AddEmployeeForm
            MainAdministrationForm mainForm = (MainAdministrationForm)this.ParentForm;  // get reference to the parent form

            // load AddEmployeeForm in the mainpanel of the parent form
            mainForm.loadForm(carDetails);
        }
    }
}
