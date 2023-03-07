using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Security.Cryptography;
using CarFleetDomain.Functions;

namespace CarFleetDomain
{
    public class Context
    {
        public const string ConnectionString = "Data Source=./; Initial Catalog=CarFleetDB";

        public Context()
        {
        }

        public static Context Create()
        {
            return new Context();
        }
        
        /// <summary>
        /// Create new table in given DataSet and fill it with data returned with command
        /// </summary>
        /// <typeparam name="T">Model for data table</typeparam>
        /// <param name="command">Query ready to use</param>
        /// <param name="dataSet">Existing dataSet to be filled with new data table</param>
        public void GetTable<T>(SqlCommand command, DataSet dataSet)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var adapter = new SqlDataAdapter();
                    adapter.TableMappings.Add("Table", typeof(T).Name);

                    command.Connection = connection;
                    adapter.SelectCommand = command;

                    connection.Open();

                    adapter.Fill(dataSet);

                    connection.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }

        #region DummyMethodsToBeDeleted
        public void UpdateTable<T>(SqlCommand command, DataSet dataSet)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var adapter = new SqlDataAdapter();
                    
                    command.Connection = connection;
                    adapter.UpdateCommand = command;

                    connection.Open();

                    adapter.Update(dataSet.Tables[typeof(T).Name]);

                    connection.Close();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
        }


        public void TestCon()
        {
            var con = new SqlConnection(ConnectionString);
            var cmd = new SqlCommand();

            cmd.CommandText = "Select TOP (10) * from Persons";
            cmd.Connection = con;
            var list = new List<string>();
            con.Open();
            var c = PasswordHasher.EncodePassword("password");
        }

        #endregion
    }
}
