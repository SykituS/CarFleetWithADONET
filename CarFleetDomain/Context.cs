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
using CarFleetDomain.Models;
using System.Reflection;

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
        public DataResponse GetTable<T>(SqlCommand command, DataSet dataSet)
        {
            using (var connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    var adapter = new SqlDataAdapter();
                    adapter.TableMappings.Add("Table", typeof(T).Name);

                    command.Connection = connection;
                    adapter.SelectCommand = command;
                    
                    adapter.Fill(dataSet);

                    return new DataResponse() { Success = true, Message = "Data was read successfully!" };
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                    return new DataResponse() { Success = false, Message = "There was error while updating data: " + ex };
                }
            }
        }
    }
}
