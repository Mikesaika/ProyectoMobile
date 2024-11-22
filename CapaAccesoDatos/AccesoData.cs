//USUARIO Y CONTRASEÑA PARA ENTRAR AL SISTEMA TALLER TÉCNICO CELULAR EN VISUAL ESTUDIO: USUARIO: admin CONTRASEÑA: admin
using ServicioTecnicoCelular.CS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;

namespace ServicioTecnicoCelular.BD
{
    // Clase que maneja el acceso de usuarios en el sistema
    public class AccesoData
    {
        // Método que verifica si el usuario y la clave proporcionados son válidos
        public static bool ObtenerAcceso(string usuario, string clave)
        {
            bool acceso = false; // Variable para almacenar el estado de acceso (por defecto es false)

            // Se obtiene la conexión a la base de datos
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                // Comando que ejecuta el procedimiento almacenado para obtener el acceso
                using (SqlCommand cmd = new SqlCommand("spObtenerAcceso", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure; // Especificamos que se utilizará un procedimiento almacenado
                    // Se añaden los parámetros del usuario y la clave al comando
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Clave", clave);
                    // Abrimos la conexión a la base de datos
                    connection.Open();

                    // Ejecutamos el comando y obtenemos un lector de datos
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Leemos los resultados devueltos por el procedimiento almacenado
                        while (reader.Read())
                        {
                            // Si existe un registro, obtenemos el valor de la columna "acceso"
                            acceso = Convert.ToBoolean(reader["acceso"]);
                        }
                    }
                }
            }
            return acceso; 
        }
    }
}

