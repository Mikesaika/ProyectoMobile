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
    public class TecnicoData
    {
        public static void AñadirTecnico(Tecnico tecnico)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spAñadirTecnico", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Cedula", tecnico.Cedula);
                    cmd.Parameters.AddWithValue("@Nombres", tecnico.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", tecnico.Apellidos);
                    cmd.Parameters.AddWithValue("@Telefono", tecnico.Telefono);
                    cmd.Parameters.AddWithValue("@Email", tecnico.Email);                    
                    cmd.Parameters.AddWithValue("@Especialidad", tecnico.Especialidad);
                    cmd.Parameters.AddWithValue("@AniosExperiencia", tecnico.AniosExperiencia);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Tecnico> ObtenerTecnicos()
        {
            List<Tecnico> tecnicos = new List<Tecnico>();

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spObtenerTecnicos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
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
                            tecnicos.Add(tecnico);
                        }
                    }
                }
            }
            return tecnicos;
        }
    }
}
