using System;

namespace ServicioTecnicoCelular.CS
{
    public class Tecnico : Persona
    {
        private string especialidad;
        private int anios_experiencia;


        public string Especialidad
        {
            get { return especialidad; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    especialidad = value;
                }
                else
                {
                    throw new ArgumentException("La cédula no puede ser nulo o vacío.");
                }
            }
        }

        public int AniosExperiencia
        {
            get { return anios_experiencia; }
            set
            {
                if (value > 0)
                {
                    anios_experiencia = value;
                }
                else
                {
                    throw new ArgumentException("Los años de experiencia deben ser mayor que cero");
                }
            }
        }        
    }
}
