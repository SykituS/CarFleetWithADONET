using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using CarFleetDomain.Models;

namespace CarFleet.Views
{
    public partial class CarListForm : Form
    {
        public CarListForm()
        {
            InitializeComponent();
        }

        private void CarListForm_Load(object sender, EventArgs e)
        {
            var dataSet = new DataSet();
            Vehicle.GetVehicleQuery(dataSet);
            Persons.GetPersonsQuery(dataSet);

            var vtable = dataSet.Tables[nameof(Vehicle)];
            var ptable = dataSet.Tables[nameof(Persons)];
            //dataSet.Relations.Add("FK_Vehicle_Person_Created", vtable.Columns["CreatedByID"],
            //    ptable.Columns["ID"]);
            //dataSet.AcceptChanges();

            vtable.Merge(ptable);

            DataGridViewVehicles.DataSource = vtable;
        }
    }
}
