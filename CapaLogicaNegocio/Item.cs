using System;

namespace ServicioTecnicoCelular.CS
{
    public abstract class Item
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public double Costo { get; set; }
        public double Precio { get; set; }

        public string TipoItem {  get; set; } 
        public bool Estado {  get; set; }

        /*protected Item(string nombre, double precio)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre no puede estar vacío.", nameof(nombre));
            }

            if (precio <= 0)
            {
                throw new ArgumentException("El precio debe ser mayor que cero.", nameof(precio));
            }

            Nombre = nombre;
            Precio = precio;
        }*/

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Precio: {Precio:C}");
        }
    }
}
