//USUARIO Y CONTRASEÑA PARA ENTRAR AL SISTEMA TALLER TÉCNICO CELULAR EN VISUAL ESTUDIO: USUARIO: admin CONTRASEÑA: admin
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
    // Clase estática que maneja las conexiones a la base de datos
    public static class DatabaseConnection // Cadena de conexión hardcodeada, especifica el servidor, base de datos y las credenciales
    {
        
        private static string connectionString = "Server=DESKTOP-UEH10A0\\SQLEXPRESS;Database=SISCel;User Id=sa;Password=zamayloka11;";
        // PARA QUE FUNCIONE EN SU BASE DE DATOS DEBE IMPORTAR LA BASE DE DATOS (SISCel) ADJUNTO EN EL ZIP Y CAMBIAR EN ESTE CODIGO SU USUARIO Y CONTRASEÑO DE SU BASE DE DATOS
       
       
        public static SqlConnection GetConnection()  // Método que devuelve una nueva instancia de SqlConnection usando la cadena de conexión
        {
            return new SqlConnection(connectionString); // Se retorna la conexión configurada

        }
    }
}
