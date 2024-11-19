using ServicioTecnicoCelular.CS;
using System;

namespace ServicioTecnicoCelular.CS
{
    public class Celular
    {
        public int Id { get; set; }
        private string marca;
        private string sistema_operativo;
        private string modelo;
        private string color;
        private string almacenamiento;
        private string pantalla;
        public int anio_fabricacion { get; set; }

        private string tipo_celular;
        public Cliente Propietario { get; set; }
        public bool Estado {  get; set; }
        
        public string Marca
        {
            get { return marca; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    marca = value;
                }
                else
                {
                    throw new ArgumentException("El chasis no puede ser nulo o vacío.");
                }
            }
        }

        public string SistemaOperativo
        {
            get { return sistema_operativo; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    sistema_operativo = value;
                }
                else
                {
                    throw new ArgumentException("El fabricante no puede ser nulo o vacío.");
                }
            }
        }

        public string Modelo
        {
            get { return modelo; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    modelo = value;
                }
                else
                {
                    throw new ArgumentException("El modelo no puede ser nulo o vacío.");
                }
            }
        }

        public string Color
        {
            get { return color; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    color = value;
                }
                else
                {
                    throw new ArgumentException("El color no puede ser nulo o vacío.");
                }
            }
        }

        public string Almacenamiento
        {
            get { return almacenamiento; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    almacenamiento = value;
                }
                else
                {
                    throw new ArgumentException("La placa no puede ser nulo o vacío.");
                }
            }
        }

        public string Pantalla
        {
            get { return pantalla; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    pantalla = value;
                }
                else
                {
                    throw new ArgumentException("El cilindraje del motor no puede ser nulo o vacío.");
                }
            }
        }

        public string TipoCelular
        {
            get { return tipo_celular; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    tipo_celular = value;
                }
                else
                {
                    throw new ArgumentException("El tipo de vehículo no puede ser nulo o vacío.");
                }
            }
        }

        public void MostrarInformacion()
        {
            //Item.MostrarInformacion();
            //Console.WriteLine($"Cantidad: {Cantidad}");
        }
    }
}
