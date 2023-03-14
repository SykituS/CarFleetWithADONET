﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFleetDomain.Models
{
    public class VehicleMileage : ModelExtension
    {
        public int ID { get; set; }
        public int VehicleID { get; set; }
        public int Mileage { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
