using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFleetDomain.Models
{
    public class Users
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public int PersonID { get; set; }
        public int RoleID { get; set; }

        public Persons Person { get; set; }
        public RoleEnum Role { get; set; }
    }

    public enum RoleEnum
    {
        Employee,
        Admin,
    }
}
