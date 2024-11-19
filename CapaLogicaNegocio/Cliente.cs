using ServicioTecnicoCelular.CS;
using System;
using System.Collections.Generic;

namespace ServicioTecnicoCelular.CS
{
    public class Cliente : Persona
    {
        private string tipo_cliente;

        //private List<Celular> celulares = new List<Celular>(); //{ get; set; } = new List<Vehiculo>();

        //public List<Vehiculo> Vehiculos { get; set; }

        //public Cliente()
        //{
        //    Vehiculos = new List<Vehiculo>();
        //}
        
        public string TipoCliente
        {
            get { return tipo_cliente; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    tipo_cliente = value;
                }
                else
                {
                    throw new ArgumentException("El tipo de cliente no puede ser nulo o vacío.");
                }
            }
        }

        /*public List<Celular> Celulares
        {
            get { return celulares; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(celulares), "La lista de celulares no puede ser nula.");
                }

                foreach (var detalle in value)
                {
                    if (detalle == null)
                    {
                        throw new ArgumentException("La lista de celulares no puede contener elementos nulos.", nameof(celulares));
                    }
                }

                celulares = value;
            }
        }*/

        /*public void AgregarCelular(Celular detalle)
        {
            if (detalle == null)
            {
                throw new ArgumentNullException(nameof(detalle), "El detalle no puede ser nulo.");
            }

            celulares.Add(detalle);
        }*/

        /*public void MostrarInformacion()
        {
            //Console.WriteLine($"Descripción del Mantenimiento: {Descripcion}");

            foreach (var detalle in celulares)
            {
                detalle.MostrarInformacion();
                Console.WriteLine();
            }
        }*/

        //public Vehiculo VehiculoCliente
        //{
        //    get { return vehiculo_cliente; }
        //    set
        //    {
        //        if (value!=null)
        //        {
        //            vehiculo_cliente = value;
        //        }
        //        else
        //        {
        //            throw new ArgumentException("La asignación de un vehículo al cliente no puede ser nulo o vacío.");
        //        }
        //    }
        //}        
    }
}
