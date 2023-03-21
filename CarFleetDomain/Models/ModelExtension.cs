using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFleetDomain.Models
{
    public class ModelExtension
    {
        public DateTime CreatedOn { get; set; }
        public int CreatedByID { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int UpdatedByID { get; set; }

        public Persons CreatedBy { get; set; }
        public Persons UpdatedBy { get; set;  }
    }
}
