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
    public class ServicioData
    {
        public static void AñadirServicio(ItemServicio servicio)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spAñadirServicio", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Descripcion", servicio.Nombre);
                    cmd.Parameters.AddWithValue("@TipoItem", servicio.TipoItem);
                    cmd.Parameters.AddWithValue("@TiempoDeServicio", servicio.Horas);                    
                    cmd.Parameters.AddWithValue("@Precio", servicio.Precio);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<ItemServicio> ObtenerServicios()
        {
            List<ItemServicio> servicios = new List<ItemServicio>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerServicios", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ItemServicio servicio = new ItemServicio();
                            servicio.Id = Convert.ToInt32(reader["IdItem"]);
                            servicio.Nombre = reader["Descripcion"].ToString();
                            servicio.Horas = Convert.ToInt32(reader["TiempoDeServicio"]);
                            servicio.TipoItem = reader["TipoItem"].ToString();
                            servicio.Costo = Convert.ToDouble(reader["Costo"]);
                            servicio.Precio = Convert.ToDouble(reader["Precio"]);
                            servicio.Estado = Convert.ToBoolean(reader["Estado"].ToString());
                            servicios.Add(servicio);
                        }
                    }
                }
            }
            return servicios;
        }
    }
}
