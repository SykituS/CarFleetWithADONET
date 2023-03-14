using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFleetDomain.Models
{
    public class Vehicle : ModelExtension
    {
        public int ID { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public string LicensePlate { get; set; }
        public string VinNumber { get; set; }
    }
}
