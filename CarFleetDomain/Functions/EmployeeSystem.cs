using CarFleetDomain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFleetDomain.Functions
{
    public class EmployeeSystem
    {
        private readonly Context _context;
        public EmployeeSystem()
        {
            _context = Context.Create();
        }

        public CommandResponse<DataSet> GetEmployees()
        {
            var dataSet = new DataSet("Data");

            var cmdTextPerson = "SELECT * FROM Persons";
            var cmdPerson = new SqlCommand(cmdTextPerson);
            _context.GetTable<Persons>(cmdPerson, dataSet);

            var reply = new CommandResponse<DataSet>(dataSet);

            if (dataSet.Tables["Persons"].Rows.Count < 1)
            {
                reply.ReturnedString = "No value returned";
            }

            return reply;
        }
       
    }
    }
