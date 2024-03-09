using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Albergo.Models
{
    public class Db
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["AlbergoDB"].ToString();
        public static SqlConnection conn = new SqlConnection(connectionString);
    }
}