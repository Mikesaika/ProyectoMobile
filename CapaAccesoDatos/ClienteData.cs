//USUARIO Y CONTRASEÑA PARA ENTRAR AL SISTEMA TALLER TÉCNICO CELULAR EN VISUAL ESTUDIO: USUARIO: admin CONTRASEÑA: admin
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
    // Clase que maneja las operaciones de acceso a datos para los clientes
    public class ClienteData
    {
        // Método para añadir un nuevo cliente a la base de datos
        public static void AñadirCliente(Cliente cliente)
        {
            // Se utiliza la conexión a la base de datos proporcionada por DatabaseConnection
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                // Comando que ejecuta el procedimiento almacenado para añadir un cliente
                using (SqlCommand cmd = new SqlCommand("spAñadirCliente", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure; // Especifica que se usará un procedimiento almacenado
                    // Se añaden los parámetros necesarios para el procedimiento almacenado
                    cmd.Parameters.AddWithValue("@Cedula", cliente.Cedula);                    
                    cmd.Parameters.AddWithValue("@Nombres", cliente.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", cliente.Apellidos);
                    cmd.Parameters.AddWithValue("@TipoCliente", cliente.TipoCliente);
                    cmd.Parameters.AddWithValue("@Email", cliente.Email);
                    cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    
                    // Abrimos la conexión y ejecutamos el comando
                    connection.Open();
                    cmd.ExecuteNonQuery(); // Ejecuta el comando sin devolver resultados
                }
            }
        }

        // Método para obtener todos los clientes de la base de datos
        public static List<Cliente> ObtenerClientes()
        {
            List<Cliente> clientes = new List<Cliente>(); // Lista para almacenar los clientes obtenidos

            // Se usa la conexión a la base de datos
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                // Se prepara el comando para ejecutar el procedimiento almacenado
                using (SqlCommand cmd = new SqlCommand("spObtenerClientes", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure; // Especifica que se usará un procedimiento almacenado
                    connection.Open(); // Abrimos la conexión a la base de datos

                    // Ejecutamos el comando y obtenemos un lector de datos
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Leemos los datos fila por fila
                        while (reader.Read())
                        {
                            // Creamos una nueva instancia de Cliente
                            Cliente cliente = new Cliente();
                            cliente.Id = Convert.ToInt32(reader["IdCliente"]);
                            cliente.Cedula = reader["Cedula"].ToString();
                            cliente.Nombres = reader["Nombres"].ToString();
                            cliente.Apellidos = reader["Apellidos"].ToString();
                            cliente.Telefono = reader["Telefono"].ToString();
                            cliente.Email = reader["Email"].ToString();
                            cliente.TipoCliente = reader["TipoCliente"].ToString();
                            cliente.Estado = Convert.ToBoolean(reader["Estado"].ToString()); // Convertimos el estado a booleano
                            
                            // Añadimos el cliente a la lista de clientes
                            clientes.Add(cliente);
                        }
                    }
                }
            }
            return clientes; // Devolvemos la lista de clientes
        }
    }
}

