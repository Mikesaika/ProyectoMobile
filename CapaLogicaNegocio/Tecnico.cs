using System;

namespace ServicioTecnicoCelular.CS
{
    // Clase que representa a un Técnico, hereda de Persona
    public class Tecnico : Persona
    {
        // Campo privado que almacena la especialidad del técnico
        private string especialidad;

        // Campo privado que almacena los años de experiencia del técnico
        private int anios_experiencia;

        // Propiedad pública para acceder o modificar la especialidad
        public string Especialidad
        {
            get { return especialidad; } // Devuelve el valor de la especialidad
            set
            {
                // Valida que la especialidad no sea nula o vacía antes de asignarla
                if (!string.IsNullOrEmpty(value))
                {
                    especialidad = value;
                }
                else
                {
                    // Lanza una excepción si el valor es inválido
                    throw new ArgumentException("La especialidad no puede ser nulo o vacío.");
                }
            }
        }

        // Propiedad pública para acceder o modificar los años de experiencia
        public int AniosExperiencia
        {
            get { return anios_experiencia; } // Devuelve el valor de los años de experiencia
            set
            {
                // Valida que los años de experiencia sean mayores a cero antes de asignarlos
                if (value > 0)
                {
                    anios_experiencia = value;
                }
                else
                {
                    // Lanza una excepción si el valor es inválido
                    throw new ArgumentException("Los años de experiencia deben ser mayor que cero");
                }
            }
        }
    }
}
