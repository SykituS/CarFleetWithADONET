using CarFleetDomain.Models;
using System.Data;
using System.Data.SqlClient;

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
            var passwordHash = PasswordHasher.EncodePassword(password);

            using (var connection = new SqlConnection(Context.ConnectionString))
            {
                var adapter = new SqlDataAdapter();
                adapter.TableMappings.Add("Table", nameof(Users));

                connection.Open();

                var cmdText = "SELECT TOP(1) * FROM Users WHERE @username = UserName AND @password = PasswordHash";
                var cmd = new SqlCommand
                {
                    CommandText = cmdText,
                    Connection = connection,
                };

                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("password", passwordHash);

                adapter.SelectCommand = cmd;

                var dataSet = new DataSet("Users");
                adapter.Fill(dataSet);


                var personAdapter = new SqlDataAdapter();
                personAdapter.TableMappings.Add("Table", nameof(Persons));

                var cmdTextPerson = "SELECT * FROM Persons";
                var cmdPerson = new SqlCommand
                {
                    CommandText = cmdTextPerson,
                    Connection = connection,
                };

                personAdapter.SelectCommand = cmdPerson;
                personAdapter.Fill(dataSet);

                var parentColumn = dataSet.Tables["Persons"].Columns["ID"];
                var childColumn = dataSet.Tables["Users"].Columns["PersonID"];

                var relation = new DataRelation("UserPerson", parentColumn, childColumn);
                dataSet.Relations.Add(relation);

                var data = dataSet.Tables["Users"].Rows[0];
                reply.ReturnedValue.ID = (int)data["ID"];
                reply.ReturnedValue.UserName = (string)data["UserName"];
            }

            return reply;
        }
    }
}
