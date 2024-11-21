using ServicioTecnicoCelular.CS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoCelular.BD
{
    // Clase para manejar las operaciones relacionadas con servicios en la base de datos
    public class ServicioData
    {
        // Método para añadir un servicio a la base de datos
        public static void AñadirServicio(ItemServicio servicio)
        {
            // Establece una conexión a la base de datos usando una conexión definida previamente
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                // Prepara el comando para ejecutar el procedimiento almacenado
                using (SqlCommand cmd = new SqlCommand("spAñadirServicio", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Asigna los valores del servicio a los parámetros del procedimiento almacenado
                    cmd.Parameters.AddWithValue("@Descripcion", servicio.Nombre);
                    cmd.Parameters.AddWithValue("@TipoItem", servicio.TipoItem);
                    cmd.Parameters.AddWithValue("@TiempoDeServicio", servicio.Horas);                    
                    cmd.Parameters.AddWithValue("@Precio", servicio.Precio);
                    // Abre la conexión y ejecuta el procedimiento
                    connection.Open();
                    cmd.ExecuteNonQuery();    // Ejecuta la consulta sin devolver un resultado
                }
            }
        }
        // Método para obtener una lista de servicios desde la base de datos
        public static List<ItemServicio> ObtenerServicios()
        {
            // Lista para almacenar los servicios recuperados
            List<ItemServicio> servicios = new List<ItemServicio>();

            // Abre una conexión con la base de datos
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                // Configura el comando para ejecutar el procedimiento almacenado
                using (SqlCommand cmd = new SqlCommand("spObtenerServicios", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    // Ejecuta el comando y usa un lector para procesar los resultados
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Construye un objeto `ItemServicio` por cada registro devuelto
                            ItemServicio servicio = new ItemServicio();
                            servicio.Id = Convert.ToInt32(reader["IdItem"]);
                            servicio.Nombre = reader["Descripcion"].ToString();
                            servicio.Horas = Convert.ToInt32(reader["TiempoDeServicio"]);
                            servicio.TipoItem = reader["TipoItem"].ToString();
                            servicio.Costo = Convert.ToDouble(reader["Costo"]);
                            servicio.Precio = Convert.ToDouble(reader["Precio"]);
                            servicio.Estado = Convert.ToBoolean(reader["Estado"].ToString());
                            // Añade el servicio a la lista
                            servicios.Add(servicio);
                        }
                    }
                }
            }
            // Retorna la lista de servicios recuperados
            return servicios;
        }
    }
}
