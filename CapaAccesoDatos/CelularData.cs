//USUARIO Y CONTRASEÑA PARA ENTRAR AL SISTEMA TALLER TÉCNICO CELULAR EN VISUAL ESTUDIO: USUARIO: admin CONTRASEÑA: admin
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
    // Clase que maneja las operaciones de acceso a datos para los celulares
    public class CelularData
    {
        // Método para añadir un nuevo dispositivo (celular) a la base de datos
        public static void AñadirDispositivo(Celular celular)
        {
            // Se obtiene la conexión a la base de datos
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                // Comando que ejecuta el procedimiento almacenado para añadir un dispositivo
                using (SqlCommand cmd = new SqlCommand("spAñadirDispositivo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure; // Se especifica que se utilizará un procedimiento almacenado
                    // Se añaden los parámetros necesarios para el procedimiento almacenado
                    cmd.Parameters.AddWithValue("@Marca", celular.Marca);
                    cmd.Parameters.AddWithValue("@Modelo", celular.Modelo);
                    cmd.Parameters.AddWithValue("@SistemaOperativo", celular.SistemaOperativo);
                    cmd.Parameters.AddWithValue("@CapacidadAlmacenamiento", celular.Almacenamiento);
                    cmd.Parameters.AddWithValue("@TamanioPantalla", celular.Pantalla);
                    cmd.Parameters.AddWithValue("@AnioFabricacion", celular.anio_fabricacion);
                    cmd.Parameters.AddWithValue("@TipoDispositivo", celular.TipoCelular);
                    cmd.Parameters.AddWithValue("@IdCliente", celular.Propietario.Id); // Relacionamos el celular con su propietario
                    // Se abre la conexión y ejecuta el comando
                    connection.Open();
                    cmd.ExecuteNonQuery(); // Ejecuta el comando sin devolver resultados
                }
            }
        }

        // Método para obtener todos los dispositivos (celulares) desde la base de datos
        public static List<Celular> ObtenerDispositivos()
        {
            List<Celular> celulares = new List<Celular>(); // Lista para almacenar los celulares obtenidos

            // Se establece la conexión a la base de datos
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                // Comando que ejecuta el procedimiento almacenado para obtener los dispositivos
                using (SqlCommand cmd = new SqlCommand("spObtenerDispositivos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure; // Especificamos que se utilizará un procedimiento almacenado
                    connection.Open(); // Abrimos la conexión

                    // Ejecutamos el comando y obtenemos un lector de datos
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Leemos cada fila de los resultados
                        while (reader.Read())
                        {
                            // Creamos una nueva instancia de Celular con los datos leídos
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
                                // Se obtiene el propietario del celular
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
                                Estado = Convert.ToBoolean(reader["Estado"].ToString()) // Estado del celular
                            }; 
                            // Añadimos el celular a la lista
                            celulares.Add(celular);
                        }
                    }
                }
            }
            return celulares; 
        }
    }
}

