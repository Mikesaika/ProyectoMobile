using System;

namespace ServicioTecnicoCelular.CS
{
    // Clase que representa un repuesto como un tipo de ítem
    // Hereda de la clase base `Item`
    public class ItemRepuesto : Item
    {
        // Propiedad que almacena el país de importación del repuesto
        public string PaisImportacion { get; set; }

        // Sobrescribe el método `MostrarInformacion` de la clase base `Item`
        public override void MostrarInformacion()
        {
            // Llama al método base para mostrar información común del ítem
            base.MostrarInformacion();
            // Muestra información específica del país de importación del repuesto
            Console.WriteLine($"País de Importación: {PaisImportacion}");
        }
    }
}
