using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarFleetDomain;
using CarFleetDomain.Functions;

namespace CarFleet.Views
{
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            var data = new EmployeeSystem().GetEmployees();

            if (data.ReturnedString != null)
            {
                label1.Text = data.ReturnedString;
            }

            DataGridViewEmployeeList.DataSource = data.ReturnedValue.Tables["Persons"];
        }

        private void DataGridViewEmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
