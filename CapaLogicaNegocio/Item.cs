using System;

namespace ServicioTecnicoCelular.CS
{
    // Clase base abstracta que representa un ítem genérico
    public abstract class Item
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        // Propiedades para los valores económicos del ítem
        public double Costo { get; set; } // Costo de adquisición o producción
        public double Precio { get; set; } // Precio de venta al cliente

        // Propiedad que describe el tipo de ítem (ej. Repuesto, Servicio)
        public string TipoItem { get; set; }

        public bool Estado { get; set; }

        // Método virtual para mostrar información del ítem
        // Puede ser sobrescrito en clases derivadas
        public virtual void MostrarInformacion()
        {
            // Muestra el nombre y el precio del ítem
            Console.WriteLine($"Nombre: {Nombre}, Precio: {Precio:C}");
        }
    }
}
