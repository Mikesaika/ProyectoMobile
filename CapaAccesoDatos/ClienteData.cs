using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicioTecnicoCelular.CS;

namespace ServicioTecnicoCelular.BD
{
    public class ClienteData
    {
        public static void AñadirCliente(Cliente cliente)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spAñadirCliente", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Cedula", cliente.Cedula);                    
                    cmd.Parameters.AddWithValue("@Nombres", cliente.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                    cmd.Parameters.AddWithValue("@TipoCliente",cliente.TipoCliente);
                    cmd.Parameters.AddWithValue("@Email", cliente.Email);
                    cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Cliente> ObtenerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerClientes", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente();
                            cliente.Id = Convert.ToInt32(reader["IdCliente"]);
                            cliente.Cedula = reader["Cedula"].ToString();
                            cliente.Nombres = reader["Nombres"].ToString();
                            cliente.Apellidos = reader["Apellidos"].ToString();
                            cliente.Telefono = reader["Telefono"].ToString();
                            cliente.Email = reader["Email"].ToString();
                            cliente.TipoCliente = reader["TipoCliente"].ToString();
                            cliente.Estado = Convert.ToBoolean(reader["Estado"].ToString());                                                    
                            clientes.Add(cliente);
                        }
                    }
                }
            }
            return clientes;
        }
    }
}
