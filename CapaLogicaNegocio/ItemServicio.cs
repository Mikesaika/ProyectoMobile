using System;

namespace ServicioTecnicoCelular.CS
{
    //Clase que representa un servicio como un tipo de item
    // Hereda de la clase base "Item"
    public class ItemServicio : Item
    {
        //Propiedad que almacena las horas de servicio
        public int Horas { get; set; }

        //Sobrescribe el metodo "MostrarInformacion" de la clase base "Item"
        public override void MostrarInformacion()
        {
            //LLama al metodo base para mostrar informacion común del item 
            base.MostrarInformacion();
            //Muestra informacion especifica de las horas del servicio
            Console.WriteLine($"Horas de Servicio: {Horas}");
        }
    }
}
