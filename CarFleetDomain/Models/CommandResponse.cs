using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFleetDomain.Models
{
    /// <summary>
    /// Response for given command
    /// </summary>
    /// <typeparam name="T">Model to use</typeparam>
    public class CommandResponse<T> : DataResponse where T : class
    {
        public CommandResponse(T returnedValue)
        {
            ReturnedValue = returnedValue;
        }

        public T ReturnedValue { get; set; }
    }
    public class DataResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
