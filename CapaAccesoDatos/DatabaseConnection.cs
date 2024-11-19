using System.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoCelular.BD
{
    public static class DatabaseConnection
    {
        private static string connectionString = "Server=DESKTOP-UEH10A0\\SQLEXPRESS;Database=SISCel;User Id=sa;Password=zamayloka11;";
        //private static string connectionString = ConfigurationManager.ConnectionStrings["SISCelDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
