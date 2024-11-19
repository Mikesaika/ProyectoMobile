using ServicioTecnicoCelular.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicioTecnicoCelular
{
    public static class Program
    {        
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMenuPrincipal());

            #region Cliente-Celular           
            //Prueba cliente y vehiculo             
            // Crear un cliente
            /*Cliente cliente = new Cliente();

            cliente.Cedula = "0917580300";
            cliente.Nombres = "Juan Carlos";
            cliente.Apellidos = "Cedeño";
            cliente.TipoCliente = "Persona natural";
            cliente.Email = "juan.cedeñoalv@ug.edu.ec";
            cliente.Telefono = "0967099199";

            // Crear un vehículo y asociarlo al cliente
            Vehiculo vehiculo = new Vehiculo();

            vehiculo.NumeroChasis = "FFFGHHTT33";
            vehiculo.Fabricante = "Toyota";
            vehiculo.Modelo = "Corolla";
            vehiculo.TipoVehiculo = "SUV";
            vehiculo.Color = "Negro";
            vehiculo.Placa = "GST4421";
            vehiculo.anio_fabricacion = 2020;
            vehiculo.Propietario = cliente;

            // Añadir el vehículo a la lista de vehículos del cliente
            cliente.AgregarVehiculo(vehiculo);

            // Crear un vehículo y asociarlo al cliente
            Vehiculo vehiculo2 = new Vehiculo();

            vehiculo2.NumeroChasis = "FFFGHHTT55";
            vehiculo2.Fabricante = "KIA";
            vehiculo2.Modelo = "Sportage R";
            vehiculo2.TipoVehiculo = "Auto";
            vehiculo2.Color = "Negro";
            vehiculo2.Placa = "GST4421";
            vehiculo2.anio_fabricacion = 2021;
            vehiculo2.Propietario = cliente;

            // Añadir el vehículo a la lista de vehículos del cliente
            cliente.AgregarVehiculo(vehiculo2);

            MessageBox.Show(cliente.Nombres);
            foreach (var detalle in cliente.Vehiculos)
            {
                MessageBox.Show(detalle.TipoVehiculo);                
                //detalle.MostrarInformacion();
                //Console.WriteLine();
            }*/
            #endregion

            #region Técnico
            /*Tecnico tecnico = new Mecanico();

            mecanico.Cedula = "0917580301";
            mecanico.Nombres = "JuanCalrlos";
            mecanico.Apellidos = "Cedeño";
            mecanico.Especialidad = "Electromecánica";
            mecanico.AniosExperiencia = 10;
            mecanico.Email = "juan.cedeñoalv@ug.edu.ec";
            mecanico.Telefono = "0967099188";

            MessageBox.Show(tecnico.Especialidad);
            #endregion

            #region Tipo-Mantenimiento
            TipoMantenimiento tipoMantenimiento1 = new TipoMantenimiento();
            TipoMantenimiento tipoMantenimiento2 = new TipoMantenimiento();

            tipoMantenimiento1.Id = 1;
            tipoMantenimiento1.Descripcion = "Preventivo";

            tipoMantenimiento2.Id = 2;
            tipoMantenimiento2.Descripcion = "Correctivo";

            MessageBox.Show(tipoMantenimiento1.Descripcion);

            #endregion

            #region Item-repuestos-servicios
            ItemRepuesto itemRepuesto1 = new ItemRepuesto("Barras link",25.5,"Suspensión");
            ItemRepuesto itemRepuesto2 = new ItemRepuesto("Amortiguadores", 135.8, "Suspensión");
            ItemRepuesto itemRepuesto3 = new ItemRepuesto("Bateria Bosh", 175.5, "Electricidad");
            MessageBox.Show(itemRepuesto1.Nombre);
            MessageBox.Show(itemRepuesto2.Nombre);
            MessageBox.Show(itemRepuesto3.Nombre);

            ItemServicio itemServicio1 = new ItemServicio("Lavado completo", 10, 1);
            ItemServicio itemServicio2 = new ItemServicio("Alineación", 30, 1);
            ItemServicio itemServicio3 = new ItemServicio("Balanceo", 15, 1);
            MessageBox.Show(itemServicio1.Nombre);
            MessageBox.Show(itemServicio2.Nombre);
            MessageBox.Show(itemServicio3.Nombre);*/
            #endregion


            #region Orden-Trabajo            
            /*OrdenDeTrabajo ordenDeTrabajo = new OrdenDeTrabajo();
            ordenDeTrabajo.Codigo = 1;
            ordenDeTrabajo.Vehiculo = vehiculo;
            ordenDeTrabajo.mecanico_mantenimiento = mecanico;
            ordenDeTrabajo.Fecha = DateTime.Now;
            ordenDeTrabajo.Diagnostico = "Falta alineación y cambio de batería";
            ordenDeTrabajo.TrabajoRealizado = "Se realizó la alineación y cambio de batería";
            ordenDeTrabajo.TipoMantenimiento = tipoMantenimiento2;
            ordenDeTrabajo.Items.Add(itemServicio2);
            ordenDeTrabajo.Items.Add(itemRepuesto3);*/
            #endregion
        }
    }
}
