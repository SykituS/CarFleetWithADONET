using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFleetDomain.Models
{
    public class VehicleDescription : ModelExtension
    {
        public int ID { get; set; }
        public int VehicleID { get; set; }
        public string Description { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
