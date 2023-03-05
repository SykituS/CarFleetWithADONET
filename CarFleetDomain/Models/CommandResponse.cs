using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFleetDomain.Models
{
    public class CommandResponse<T> where T : class
    {
        public CommandResponse(T returnedValue)
        {
            ReturnedValue = returnedValue;
        }

        public T ReturnedValue { get; set; }
        public string ReturnedString { get; set; }
    }
}
