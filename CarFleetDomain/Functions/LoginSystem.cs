using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFleetDomain.Models;

namespace CarFleetDomain.Functions
{
    public class LoginSystem
    {
        public LoginSystem()
        {
            
        }

        public CommandResponse<Users> LoginUser(string username, string password)
        {
            var reply = new CommandResponse<Users>(new Users());


            reply.ReturnedValue.UserName = username;
            reply.ReturnedValue.PasswordHash = password;

            reply.ReturnedString = "test string";

            return reply;
        }
    }
}
