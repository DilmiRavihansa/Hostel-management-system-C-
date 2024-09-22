using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostalMngm_System
{
    internal class Connection
    {
        //Connection string for the database
        string connstring = @"Data Source=DESKTOP-DD80ACK;Initial Catalog=Hostel_Management_System;Integrated Security=True";

        //Method to get a Connection object
        public SqlConnection GetDBCon()
        {
            SqlConnection conobj=new SqlConnection(connstring);
            conobj.Open();
            return conobj;
        }
    }
}
