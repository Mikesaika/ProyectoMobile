using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoCelular.CS
{
    // Clase que representa una vista de la orden de reparación con sus atributos y propiedades
    public class OrdenDeReparacionView
    {
        public int Orden { get; set; }

        public string Dispositivo { get; set; }

        public string Marca { get; set; }

        public string SistemaOperativo { get; set; }

        public string Cliente { get; set; }

        public string Tipo { get; set; }

        public bool Autorizado { get; set; }

        public string Tecnico { get; set; }

        public string Motivo { get; set; }

        public string Diagnostico { get; set; }

        public string EstadoOrden { get; set; }

        // Propiedad que almacena la fecha en la que se generó la orden
        public DateTime Fecha { get; set; }
    }
}
