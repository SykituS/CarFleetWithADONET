using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CarFleetDomain
{
    public class Context
    {
        public const string ConnectionString = "Data Source=./; Initial Catalog=CarFleetDB";

        public void TestCon()
        {
            var con = new SqlConnection(ConnectionString);
            var cmd = new SqlCommand();

            cmd.CommandText = "Select TOP (10) * from Persons";
            cmd.Connection = con;
            var list = new List<string>();
            con.Open();

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                list.Add($"First name: {dr[1]}, Last name: {dr[2]}, Phone number: {dr[3]}, Email: {dr[4]}" );
            }

            con.Close();
        }

    }
}
