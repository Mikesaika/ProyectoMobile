//USUARIO Y CONTRASEÑA PARA ENTRAR AL SISTEMA TALLER TÉCNICO CELULAR EN VISUAL ESTUDIO: USUARIO: admin CONTRASEÑA: admin
using ServicioTecnicoCelular.CS;
using System;

namespace ServicioTecnicoCelular.CS
{
    // Clase que representa un celular con sus características principales
    public class Celular
    public class Celular
    {
        // Propiedad para identificar el celular de manera única
        public int Id { get; set; }
        // Campos privados para almacenar datos importantes del celular
        private string marca;      // Marca del celular (ej. Samsung, Apple)
        private string sistema_operativo;    // Sistema operativo (ej. Android, iOS)
        private string modelo;     // Modelo del dispositivo (ej. Galaxy S21)
        private string color;     // Color del dispositivo
        private string almacenamiento;    // Capacidad de almacenamiento (ej. 128 GB)
        private string pantalla;    // Características de la pantalla (ej. 6.5")
        public int anio_fabricacion { get; set; }    // Año de fabricación del dispositivo
        
        private string tipo_celular;     // Tipo del celular (ej. Gama alta, Gama media)
        public Cliente Propietario { get; set; }     // Relación: El celular tiene un propietario, representado por un cliente
        public bool Estado {  get; set; }    // Indica si el celular está activo en el sistema

        // Propiedad para acceder y modificar la marca con validación
        public string Marca
        {
            get { return marca; }
            set
            {
                // Valida que la marca no sea nula o vacía
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

        // Propiedad para el sistema operativo con validación
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

        // Propiedad para el modelo con validación
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

        // Propiedad para el color con validación
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

        // Propiedad para el almacenamiento con validación
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

        // Propiedad para la pantalla con validación
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

        // Propiedad para el tipo de celular con validación
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

        // Método para mostrar información del celular
        public void MostrarInformacion()
        {
            //Item.MostrarInformacion();
            //Console.WriteLine($"Cantidad: {Cantidad}");
        }
    }
}
