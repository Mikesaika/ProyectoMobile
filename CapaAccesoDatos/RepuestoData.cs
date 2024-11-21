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
    // Clase que maneja las operaciones relacionadas con los repuestos en la base de datos
    public class RepuestoData
    {
        // Método para añadir un repuesto a la base de datos
        public static void AñadirRepuesto(ItemRepuesto repuesto)
        {
            // Establece una conexión a la base de datos utilizando la conexión predefinida
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                // Prepara el comando para ejecutar el procedimiento almacenado
                using (SqlCommand cmd = new SqlCommand("spAñadirRepuesto", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Asigna los valores del repuesto a los parámetros del procedimiento almacenado
                    cmd.Parameters.AddWithValue("@Descripcion", repuesto.Nombre);
                    cmd.Parameters.AddWithValue("@TipoItem", repuesto.TipoItem);
                    cmd.Parameters.AddWithValue("@ProveedorOrigen", repuesto.PaisImportacion);
                    cmd.Parameters.AddWithValue("@Costo", repuesto.Costo);
                    cmd.Parameters.AddWithValue("@Precio", repuesto.Precio);                    
                    
                    // Abre la conexión y ejecuta el procedimiento almacenado
                    connection.Open();
                    cmd.ExecuteNonQuery(); // Ejecuta la consulta sin devolver ningún valor
                }
            }
        }

        // Método para obtener una lista de repuestos desde la base de datos
        public static List<ItemRepuesto> ObtenerRepuestos()
        {
            // Lista para almacenar los repuestos recuperados
            List<ItemRepuesto> repuestos = new List<ItemRepuesto>();

            // Establece la conexión con la base de datos
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                // Configura el comando para ejecutar el procedimiento almacenado
                using (SqlCommand cmd = new SqlCommand("spObtenerRepuestos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    // Ejecuta el comando y usa un lector para procesar los resultados de la consulta
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Itera sobre cada registro devuelto por la consulta
                        while (reader.Read())
                        {
                            // Crea un nuevo objeto `ItemRepuesto` por cada registro
                            ItemRepuesto repuesto = new ItemRepuesto();
                            repuesto.Id = Convert.ToInt32(reader["IdItem"]);
                            repuesto.Nombre = reader["Descripcion"].ToString();
                            repuesto.PaisImportacion = reader["ProveedorOrigen"].ToString();
                            repuesto.TipoItem = reader["TipoItem"].ToString();
                            repuesto.Costo = Convert.ToDouble(reader["Costo"]);
                            repuesto.Precio = Convert.ToDouble(reader["Precio"]);
                            repuesto.Estado = Convert.ToBoolean(reader["Estado"].ToString());

                            // Añade el repuesto a la lista
                            repuestos.Add(repuesto);
                        }
                    }
                }
            }

            // Retorna la lista de repuestos
            return repuestos;
        }
    }
}
