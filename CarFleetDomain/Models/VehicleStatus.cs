using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFleetDomain.Models
{
    public class VehicleStatus
    {
        public int ID { get; set; }
        public int VehicleID { get; set; }
        public VehicleStatusEnum Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByID { get; set; }

        public Vehicle Vehicle { get; set; }
        public Persons CreatedBy { get; set; }
    }

    public enum VehicleStatusEnum
    {
        Free,
        Reserved,
        InUse,
        InService,
        EoL,
    }
}
