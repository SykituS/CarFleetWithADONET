using CarFleetDomain.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;

namespace CarFleetDomain.Functions
{
    public class LoginSystem
    {
        private readonly Context _context;
        public LoginSystem()
        {
            _context = Context.Create();
        }

        public CommandResponse<Users> LoginUser(string username, string password)
        {
            var reply = new CommandResponse<Users>(new Users());
            var passwordHash = PasswordHasher.EncodePassword(password);

            var dataSet = new DataSet();
            var response = Users.GetUsersQuery(dataSet);
            
            if (!response.Success)
            {
                reply.Message = response.Message;
                reply.Success = response.Success;
                return reply;
            }

            var userRow = dataSet.Tables[nameof(Users)].AsEnumerable().FirstOrDefault(e =>
                e.Field<string>(nameof(Users.UserName)) == username &&
                e.Field<string>(nameof(Users.PasswordHash)) == passwordHash);

            if (userRow == null)
            {
                reply.Message = "There was an error while login to system. Please contact with IT support team!";
                reply.Success = false;
                return reply;
            }

            response = Persons.GetPersonsQuery(dataSet);

            if (!response.Success)
            {
                reply.Message = response.Message;
                reply.Success = response.Success;
                return reply;
            }

            var personID = (int)userRow.ItemArray[3];

            var personRow = dataSet.Tables[nameof(Persons)].AsEnumerable()
                .FirstOrDefault(e => e.Field<int>(nameof(Persons.ID)) == personID);

            if (personRow == null)
            {
                reply.Message = "There was an error while login to system. Please contact with IT support team!";
                reply.Success = false;
                return reply;
            }

            if ((bool)personRow[5])
            {
                reply.Message = "Account was disabled! Please contact with IT support team!";
                reply.Success = false;
                return reply;
            }

            reply.ReturnedValue = CastObject.CreateItemFromRow<Users>(userRow);
            reply.ReturnedValue.Person = CastObject.CreateItemFromRow<Persons>(personRow);
            reply.Success = true;

            return reply;
        }
    }
}
