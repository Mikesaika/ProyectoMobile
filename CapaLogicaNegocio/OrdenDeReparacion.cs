using System;
using System.Collections.Generic;

namespace ServicioTecnicoCelular.CS
{
    public class OrdenDeReparacion
    {
        private int codigo;
        public Celular celular { get; set; }
        public string estadoOrden { get; set; }
        //public string propietario { get; set; }        
        private DateTime fecha;
        public string TipoServicio {  get; set; }
        //public string tecnico { get; set; }
        public Tecnico tecnico { get; set; }
        public string motivo { get; set; }
        public string diagnostico { get; set; }
        public string TrabajoRealizado { get; set; }
        public bool autorizado { get; set; }
        public List<OrdenReparacionDetalle> detalles { get; set; } = new List<OrdenReparacionDetalle>();
        //public OrdenTrabajoDetalle detalles { get; set; }
        public double Subtotal { get; set; }
        public double Iva { get; set;  }
        public double Total { get; set; }

        public bool estado { get; set; }

        //private Cliente cliente_mantenimiento;
        //public Vehiculo Vehiculo { get; set; }
        //public Mecanico mecanico_mantenimiento { get; set; }
        //public TipoMantenimiento TipoMantenimiento { get; set; }
        //public List<Item> Items { get; set; }

        public OrdenDeReparacion()
        {
            //Items = new List<Item>();
            detalles = new List<OrdenReparacionDetalle>();
        }

        public int Codigo
        {
            get { return codigo; }
            set
            {
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

        public DateTime Fecha
        {
            get { return fecha; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(Fecha), "La fecha no puede ser nula.");
                }

                fecha = value;
            }
        }

        /*public string DiagnosticoTrabajoRealizado
        {
            get { return diagnostico_trabajo_realizado; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    diagnostico_trabajo_realizado = value;
                }
                else
                {
                    throw new ArgumentException("El diagnóstico / trabajo realizado no puede ser nulo o vacío.");
                }
            }
        }*/

        /*public string TrabajoRealizado
        {
            get { return trabajo_realizado; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    trabajo_realizado = value;
                }
                else
                {
                    throw new ArgumentException("El trabajo realizado no puede ser nulo o vacío.");
                }
            }
        }*/

        //public string TipoMantenimiento
        //{
        //    get { return tipo_mantenimiento; }
        //    set
        //    {
        //        if (!string.IsNullOrEmpty(value))
        //        {
        //            tipo_mantenimiento = value;
        //        }
        //        else
        //        {
        //            throw new ArgumentException("El tipo de mantenimiento no puede ser nulo o vacío.");
        //        }
        //    }
        //}

        //public List<TipoMantenimiento> Detalles
        //{
        //    get { return detalles; }
        //    set
        //    {
        //        if (value == null)
        //        {
        //            throw new ArgumentNullException(nameof(Detalles), "La lista de detalles no puede ser nula.");
        //        }

        //        foreach (var detalle in value)
        //        {
        //            if (detalle == null)
        //            {
        //                throw new ArgumentException("La lista de detalles no puede contener elementos nulos.", nameof(Detalles));
        //            }
        //        }

        //        detalles = value;
        //    }
        //}

        //public void AgregarDetalle(TipoMantenimiento detalle)
        //{
        //    if (detalle == null)
        //    {
        //        throw new ArgumentNullException(nameof(detalle), "El detalle no puede ser nulo.");
        //    }

        //    Detalles.Add(detalle);
        //}

        //public void MostrarInformacion()
        //{                        
        //    //Console.WriteLine($"Descripción del Mantenimiento: {Descripcion}");

        //    foreach (var detalle in Detalles)
        //    {
        //        detalle.MostrarInformacion();
        //        Console.WriteLine();
        //    }
        //}
    }
}
