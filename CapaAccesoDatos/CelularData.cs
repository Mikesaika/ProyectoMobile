using ServicioTecnicoCelular.CS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ServicioTecnicoCelular.BD
{
    public class CelularData
    {
        public static void AñadirDispositivo(Celular celular)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spAñadirDispositivo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Marca", celular.Marca);
                    cmd.Parameters.AddWithValue("@Modelo", celular.Modelo);
                    cmd.Parameters.AddWithValue("@SistemaOperativo", celular.SistemaOperativo);
                    cmd.Parameters.AddWithValue("@CapacidadAlmacenamiento", celular.Almacenamiento);
                    cmd.Parameters.AddWithValue("@TamanioPantalla", celular.Pantalla);
                    cmd.Parameters.AddWithValue("@AnioFabricacion", celular.anio_fabricacion);
                    cmd.Parameters.AddWithValue("@TipoDispositivo", celular.TipoCelular);
                    cmd.Parameters.AddWithValue("@IdCliente", celular.Propietario.Id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Celular> ObtenerDispositivos()
        {
            List<Celular> celulares = new List<Celular>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerDispositivos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Celular celular = new Celular
                            {
                                Id = Convert.ToInt32(reader["IdDispositivo"]),
                                Marca = reader["Marca"].ToString(),
                                Modelo = reader["Modelo"].ToString(),
                                SistemaOperativo = reader["SistemaOperativo"].ToString(),
                                Almacenamiento = reader["CapacidadAlmacenamiento"].ToString(),
                                Pantalla = reader["TamanioPantalla"].ToString(),
                                anio_fabricacion = Convert.ToInt32(reader["AnioFabricacion"]),
                                TipoCelular = reader["TipoDispositivo"].ToString(),                                                                
                                Propietario = new Cliente
                                {
                                    Id = Convert.ToInt32(reader["IdCliente"]),
                                    Cedula = reader["Cedula"].ToString(),
                                    Nombres = reader["Nombres"].ToString(),
                                    Apellidos = reader["Apellidos"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    TipoCliente = reader["TipoCliente"].ToString(),
                                    Estado = Convert.ToBoolean(reader["Estado"].ToString())
                                },
                                Estado = Convert.ToBoolean(reader["Estado"].ToString())
                            };                                                                                    
                            celulares.Add(celular);
                        }
                    }
                }
            }
            return celulares;
        }
    }
}
