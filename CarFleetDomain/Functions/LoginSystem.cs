using CarFleetDomain.Models;
using System.Data;
using System.Data.SqlClient;

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

            var cmdText = "SELECT TOP(1) * FROM Users WHERE @username = UserName AND @password = PasswordHash";
            var cmd = new SqlCommand(cmdText);

            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", passwordHash);

            var dataSet = new DataSet("Data");
            _context.GetTable<Users>(cmd, dataSet);


            var cmdTextPerson = "SELECT * FROM Persons";
            var cmdPerson = new SqlCommand(cmdTextPerson);
            _context.GetTable<Persons>(cmdPerson, dataSet);


            var parentColumn = dataSet.Tables["Persons"].Columns["ID"];
            var childColumn = dataSet.Tables["Users"].Columns["PersonID"];

            var relation = new DataRelation("UserPerson", parentColumn, childColumn);
            dataSet.Relations.Add(relation);

            var data = dataSet.Tables["Users"].Rows[0];
            reply.ReturnedValue.ID = (int)data["ID"];
            reply.ReturnedValue.UserName = (string)data["UserName"];


            return reply;
        }
    }
}
