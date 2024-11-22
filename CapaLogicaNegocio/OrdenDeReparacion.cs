//USUARIO Y CONTRASEÑA PARA ENTRAR AL SISTEMA TALLER TÉCNICO CELULAR EN VISUAL ESTUDIO: USUARIO: admin CONTRASEÑA: admin
using System;
using System.Collections.Generic;

namespace ServicioTecnicoCelular.CS
{
    // Clase que representa una orden de reparación completa
    public class OrdenDeReparacion
    {
        // Campo privado para el código único de la orden
        private int codigo;

        // Propiedad que representa el celular asociado a la orden
        public Celular celular { get; set; }

        // Estado actual de la orden (ej. En proceso, Completada)
        public string estadoOrden { get; set; }

        // Campo privado para almacenar la fecha de la orden
        private DateTime fecha;

        // Tipo de servicio solicitado (ej. Reparación, Mantenimiento)
        public string TipoServicio { get; set; }

        // Técnico asignado a la orden, representado como un objeto
        public Tecnico tecnico { get; set; }

        // Detalles específicos sobre la razón de la reparación
        public string motivo { get; set; }

        // Diagnóstico proporcionado para el problema del dispositivo
        public string diagnostico { get; set; }

        // Descripción del trabajo realizado en el dispositivo
        public string TrabajoRealizado { get; set; }

        // Indica si el cliente autorizó la reparación
        public bool autorizado { get; set; }

        // Lista de detalles de la orden, como piezas o servicios utilizados
        public List<OrdenReparacionDetalle> detalles { get; set; } = new List<OrdenReparacionDetalle>();

        // Subtotal calculado de los costos de la orden
        public double Subtotal { get; set; }

        // Valor del IVA aplicado a la orden
        public double Iva { get; set; }

        // Total de la orden (Subtotal + IVA)
        public double Total { get; set; }

        // Indica si la orden está activa o cerrada
        public bool estado { get; set; }

        // Constructor que inicializa la lista de detalles
        public OrdenDeReparacion()
        {
            detalles = new List<OrdenReparacionDetalle>();
        }

        // Propiedad para el código único, con validación
        public int Codigo
        {
            get { return codigo; }
            set
            {
                // Valida que el código sea mayor a cero
                if (value > 0)
                {
                    codigo = value;
                }
                else
                {
                    throw new ArgumentException("El código no puede ser cero, nulo o vacío.");
                }
            }
        }

        // Propiedad para la fecha de la orden, con validación
        public DateTime Fecha
        {
            get { return fecha; }
            set
            {
                // Valida que la fecha no sea nula
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(Fecha), "La fecha no puede ser nula.");
                }

                fecha = value;
            }
        }

    }
}
