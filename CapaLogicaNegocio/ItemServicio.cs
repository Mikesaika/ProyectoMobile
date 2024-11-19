using System;

namespace ServicioTecnicoCelular.CS
{
    public class ItemServicio : Item
    {
        public int Horas { get; set; }

        /*public ItemServicio(string nombre, double precio, int horas) : base(nombre, precio)
        {
            if (horas <= 0)
            {
                throw new ArgumentException("Las horas deben ser mayores que cero.", nameof(horas));
            }

            Horas = horas;
        }*/

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Horas de Servicio: {Horas}");
        }
    }
}
