using System;

namespace ServicioTecnicoCelular.CS
{
    public class ItemRepuesto : Item
    {
        public string PaisImportacion { get; set; }

        /*public ItemRepuesto(string nombre, double precio, string categoria_repuesto) : base(nombre, precio)
        {
            if (string.IsNullOrWhiteSpace(categoria_repuesto))
            {
                throw new ArgumentException("El código no puede estar vacío.", nameof(categoria_repuesto));
            }

            this.categoria_repuesto = categoria_repuesto;
        }*/
        

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Código del Repuesto: {PaisImportacion}");
        }
    }
}
