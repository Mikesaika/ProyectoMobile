using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoCelular.CS
{
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
        public DateTime Fecha { get; set; }
    }
}
