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
    public class RepuestoData
    {
        public static void AñadirRepuesto(ItemRepuesto repuesto)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spAñadirRepuesto", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Descripcion", repuesto.Nombre);
                    cmd.Parameters.AddWithValue("@TipoItem", repuesto.TipoItem);
                    cmd.Parameters.AddWithValue("@ProveedorOrigen", repuesto.PaisImportacion);
                    cmd.Parameters.AddWithValue("@Costo", repuesto.Costo);
                    cmd.Parameters.AddWithValue("@Precio", repuesto.Precio);                    
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<ItemRepuesto> ObtenerRepuestos()
        {
            List<ItemRepuesto> repuestos = new List<ItemRepuesto>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerRepuestos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ItemRepuesto repuesto = new ItemRepuesto();
                            repuesto.Id = Convert.ToInt32(reader["IdItem"]);
                            repuesto.Nombre = reader["Descripcion"].ToString();
                            repuesto.PaisImportacion = reader["ProveedorOrigen"].ToString();
                            repuesto.TipoItem = reader["TipoItem"].ToString();
                            repuesto.Costo = Convert.ToDouble(reader["Costo"]);
                            repuesto.Precio = Convert.ToDouble(reader["Precio"]);                            
                            repuesto.Estado = Convert.ToBoolean(reader["Estado"].ToString());
                            repuestos.Add(repuesto);
                        }
                    }
                }
            }
            return repuestos;
        }
    }
}
