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
    // Clase que gestiona las operaciones relacionadas con técnicos en la base de datos
    public class TecnicoData
    {
        // Método para añadir un técnico a la base de datos
        public static void AñadirTecnico(Tecnico tecnico)
        {
            // Abre una conexión a la base de datos usando un método de conexión predefinido
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                // Configura el comando para ejecutar un procedimiento almacenado
                using (SqlCommand cmd = new SqlCommand("spAñadirTecnico", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Añade parámetros al comando para pasar los datos del técnico
                    cmd.Parameters.AddWithValue("@Cedula", tecnico.Cedula);
                    cmd.Parameters.AddWithValue("@Nombres", tecnico.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", tecnico.Apellidos);
                    cmd.Parameters.AddWithValue("@Telefono", tecnico.Telefono);
                    cmd.Parameters.AddWithValue("@Email", tecnico.Email);                    
                    cmd.Parameters.AddWithValue("@Especialidad", tecnico.Especialidad);
                    cmd.Parameters.AddWithValue("@AniosExperiencia", tecnico.AniosExperiencia);
                    connection.Open();    // Abre la conexión, ejecuta el comando y luego cierra la conexión automáticamente
                    cmd.ExecuteNonQuery();    // Ejecuta el procedimiento almacenado sin retorno de datos
                }
            }
        }
        // Método para obtener la lista de técnicos desde la base de datos
        public static List<Tecnico> ObtenerTecnicos()
        {
            // Crea una lista para almacenar los técnicos obtenidos
            List<Tecnico> tecnicos = new List<Tecnico>();

            // Abre una conexión a la base de datos
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                // Configura el comando para ejecutar el procedimiento almacenado de obtención
                using (SqlCommand cmd = new SqlCommand("spObtenerTecnicos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    // Ejecuta el comando y utiliza un lector para recorrer los resultados
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Crea un nuevo objeto Técnico por cada registro en los resultados
                            Tecnico tecnico = new Tecnico();
                            tecnico.Id = Convert.ToInt32(reader["IdTecnico"]);
                            tecnico.Cedula = reader["Cedula"].ToString();
                            tecnico.Nombres = reader["Nombres"].ToString();
                            tecnico.Apellidos = reader["Apellidos"].ToString();
                            tecnico.Telefono = reader["Telefono"].ToString();
                            tecnico.Email = reader["Email"].ToString();
                            tecnico.Especialidad = reader["Especialidad"].ToString();
                            tecnico.AniosExperiencia = Convert.ToInt32(reader["AniosExperiencia"]);
                            tecnico.Estado = Convert.ToBoolean(reader["Estado"].ToString());
                            // Añade el técnico a la lista
                            tecnicos.Add(tecnico);
                        }
                    }
                }
            }
            return tecnicos;
        }
    }
}
