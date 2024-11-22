//USUARIO Y CONTRASEÑA PARA ENTRAR AL SISTEMA TALLER TÉCNICO CELULAR EN VISUAL ESTUDIO: USUARIO: admin CONTRASEÑA: admin
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioTecnicoCelular.CS
{
    public class OrdenReparacionDetalle
    {
       // Clase que representa los detalles de una orden de reparación con sus atributos
        public int id {  get; set; }
        public int codigo {  get; set; }

        public int IdItem {  get; set; }
        public string Item { get; set; }

        public double Precio { get; set; }

        public int Cantidad { get; set; }

        public double Total { get; set; }   
    }
}


