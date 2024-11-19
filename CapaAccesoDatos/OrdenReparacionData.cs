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
    public class OrdenReparacionData
    {
        public static void AñadirOrdenReparacion(OrdenDeReparacion ordenDeReparacion)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spAñadirOrdenReparacion", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdDispositivo", ordenDeReparacion.celular.Id);
                    cmd.Parameters.AddWithValue("@EstadoOrden", ordenDeReparacion.estadoOrden);                    
                    cmd.Parameters.AddWithValue("@IdTecnico", ordenDeReparacion.tecnico.Id);
                    cmd.Parameters.AddWithValue("@Motivo", ordenDeReparacion.motivo);                    
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void ModificarOrdenReparacion(OrdenDeReparacion ordenDeReparacion)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spModificarOrdenReparacion", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdOrdenReparacion", ordenDeReparacion.Codigo);
                    cmd.Parameters.AddWithValue("@EstadoOrden", ordenDeReparacion.estadoOrden);                    
                    cmd.Parameters.AddWithValue("@Diagnostico", ordenDeReparacion.diagnostico);
                    cmd.Parameters.AddWithValue("@Autorizado", ordenDeReparacion.autorizado);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void CerrarOrdenReparacion(OrdenDeReparacion ordenDeReparacion)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("spCerrarOrdenReparacionCabecera", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdOrdenReparacion", ordenDeReparacion.Codigo);
                    cmd.Parameters.AddWithValue("@EstadoOrden", ordenDeReparacion.estadoOrden);
                    cmd.Parameters.AddWithValue("@TrabajoRealizado", ordenDeReparacion.TrabajoRealizado);
                    cmd.Parameters.AddWithValue("@TipoServicio", ordenDeReparacion.TipoServicio);
                    cmd.Parameters.AddWithValue("@Subtotal", ordenDeReparacion.Subtotal);
                    cmd.Parameters.AddWithValue("@Iva", ordenDeReparacion.Iva);
                    cmd.Parameters.AddWithValue("@Total", ordenDeReparacion.Total);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            foreach (OrdenReparacionDetalle ordenReparacionDetalle in ordenDeReparacion.detalles)
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand("spCerrarOrdenReparacionDetalle", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdOrdenReparacion", ordenDeReparacion.Codigo);
                        cmd.Parameters.AddWithValue("@IdItem", ordenReparacionDetalle.IdItem);
                        cmd.Parameters.AddWithValue("@Precio", ordenReparacionDetalle.Precio);
                        cmd.Parameters.AddWithValue("@Cantidad", ordenReparacionDetalle.Cantidad);
                        cmd.Parameters.AddWithValue("@Total", ordenReparacionDetalle.Total);                        
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public static List<OrdenDeReparacion> ObtenerOrdenesDeReparacion()
        {
            List<OrdenDeReparacion> ordenDeReparaciones = new List<OrdenDeReparacion>();

            using (SqlConnection connection1 = DatabaseConnection.GetConnection())
            {
                using (SqlCommand cmd1 = new SqlCommand("spObtenerOrdenReparacionCabecera", connection1))
                {
                    cmd1.CommandType = CommandType.StoredProcedure;
                    connection1.Open();

                    using (SqlDataReader reader1 = cmd1.ExecuteReader())
                    {
                        while (reader1.Read())
                        {
                            OrdenDeReparacion ordenDeReparacion = new OrdenDeReparacion
                            {
                                Codigo = Convert.ToInt32(reader1["IdOrdenReparacion"]),
                                celular = new Celular
                                {
                                    Id = Convert.ToInt32(reader1["IdDispositivo"]),
                                    Marca = reader1["Marca"].ToString(),
                                    Modelo = reader1["Modelo"].ToString(),
                                    SistemaOperativo = reader1["SistemaOperativo"].ToString(),
                                    Almacenamiento = reader1["CapacidadAlmacenamiento"].ToString(),
                                    Pantalla = reader1["TamanioPantalla"].ToString(),
                                    anio_fabricacion = Convert.ToInt32(reader1["AnioFabricacion"]),
                                    TipoCelular = reader1["TipoDispositivo"].ToString(),
                                    Propietario = new Cliente
                                    {
                                        Id = Convert.ToInt32(reader1["IdCliente"]),
                                        Cedula = reader1["Cedula"].ToString(),
                                        Nombres = reader1["Nombres"].ToString(),
                                        Apellidos = reader1["Apellidos"].ToString(),
                                        Telefono = reader1["Telefono"].ToString(),
                                        Email = reader1["Email"].ToString(),
                                        TipoCliente = reader1["TipoCliente"].ToString(),
                                        Estado = Convert.ToBoolean(reader1["EstadoC"].ToString())
                                    },
                                    Estado = Convert.ToBoolean(reader1["EstadoD"].ToString())
                                },
                                estadoOrden = reader1["EstadoOrden"].ToString(),
                                TipoServicio = reader1["TipoServicio"].ToString(),
                                tecnico = new Tecnico
                                {
                                    Id = Convert.ToInt32(reader1["IdTecnico"]),
                                    Cedula = reader1["CedulaT"].ToString(),
                                    Nombres = reader1["NombresT"].ToString(),
                                    Apellidos = reader1["ApellidosT"].ToString(),
                                    Telefono = reader1["TelefonoT"].ToString(),
                                    Email = reader1["EmailT"].ToString(),
                                    Especialidad = reader1["Especialidad"].ToString(),
                                    AniosExperiencia = Convert.ToInt32(reader1["AniosExperiencia"]),
                                    Estado = Convert.ToBoolean(reader1["EstadoT"].ToString())
                                },
                                motivo = reader1["Motivo"].ToString(),
                                diagnostico = reader1["Diagnostico"].ToString(),
                                TrabajoRealizado = reader1["TrabajoRealizado"].ToString(),
                                autorizado = Convert.ToBoolean(reader1["Autorizado"]),
                                Subtotal = Convert.ToDouble(reader1["Subtotal"]),
                                Iva = Convert.ToDouble(reader1["Impuesto"]),
                                Total = Convert.ToDouble(reader1["Total"]),
                                Fecha=Convert.ToDateTime(reader1["FechaEmision"]),
                                estado = Convert.ToBoolean(reader1["Estado"].ToString()),                                
                             };                            
                            
                            using (SqlConnection connection2 = DatabaseConnection.GetConnection())
                            {
                                using (SqlCommand cmd2 = new SqlCommand("spObtenerOrdenReparacionDetalle", connection2))
                                {
                                    cmd2.CommandType = CommandType.StoredProcedure;
                                    cmd2.Parameters.AddWithValue("@IdOrdenReparacion", ordenDeReparacion.Codigo);
                                    connection2.Open();

                                    using (SqlDataReader reader2 = cmd2.ExecuteReader())
                                    {
                                        while (reader2.Read())
                                        {
                                            OrdenReparacionDetalle ordenReparacionDetalle = new OrdenReparacionDetalle
                                            {
                                                id = Convert.ToInt32(reader2["IdOrdenReparacionDetalle"]),
                                                codigo= Convert.ToInt32(reader2["IdOrdenReparacion"]),
                                                Item= reader2["Descripcion"].ToString(),
                                                Precio= Convert.ToDouble(reader2["Precio"]),
                                                Cantidad= Convert.ToInt32(reader2["Cantidad"]),
                                                Total = Convert.ToDouble(reader2["Total"])
                                            };                                                                                                                                    
                                            ordenDeReparacion.detalles.Add(ordenReparacionDetalle);
                                        }
                                    }

                                }
                            }
                            ordenDeReparaciones.Add(ordenDeReparacion);
                        }
                    }
                }
            }
            return ordenDeReparaciones;
        }
    }
}
