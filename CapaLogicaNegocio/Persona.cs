using System;

namespace ServicioTecnicoCelular.CS
{
    // Clase base abstracta que representa a una Persona
    public abstract class Persona
    {
        // Campos privados para almacenar la información básica de una persona
        private int id;
        private string cedula;
        private string nombres;
        private string apellidos;
        private string telefono;
        private string email;        
        private bool estado;

        // Propiedad pública para acceder o modificar el identificador único
        public int Id 
        {
            get { return id; }
            set { id = value; } // No tiene validaciones porque se asume que el sistema controla su unicidad
        }
        
        // Propiedad pública para acceder o modificar la cédula
        public string Cedula
        {
            get { return cedula; }
            set
            {
                // Valida que la cédula no sea nula o vacía antes de asignarla
                if (!string.IsNullOrEmpty(value))
                {
                    cedula = value;
                }
                else
                {
                    // Lanza una excepción si el valor es inválido
                    throw new ArgumentException("La cédula no puede ser nulo o vacío.");
                }
            }
        }

        // Propiedad pública para acceder o modificar el nombre
        public string Nombres
        {
            get { return nombres; }
            set
            {
                // Valida que el nombre no sea nulo o vacío antes de asignarlo
                if (!string.IsNullOrEmpty(value))
                {
                    nombres = value;
                }
                else
                {
                    throw new ArgumentException("El nombre no puede ser nulo o vacío.");
                }
            }
        }

        // Propiedad pública para acceder o modificar el apellido
        public string Apellidos
        {
            get { return apellidos; }
            set
            {
                // Valida que el apellido no sea nulo o vacío antes de asignarlo
                if (!string.IsNullOrEmpty(value))
                {
                    apellidos = value;
                }
                else
                {
                    throw new ArgumentException("El apellido no puede ser nulo o vacío.");
                }
            }
        }

        // Propiedad pública para acceder o modificar el teléfono
        public string Telefono
        {
            get { return telefono; }
            set
            {
                // Valida que el teléfono no sea nulo o vacío antes de asignarlo
                if (!string.IsNullOrEmpty(value))
                {
                    telefono = value;
                }
                else
                {
                    throw new ArgumentException("El teléfono no puede ser nulo o vacío.");
                }
            }
        }

        // Propiedad pública para acceder o modificar el email
        public string Email
        {
            get { return email; }
            set
            {
                // Valida que el email no sea nulo o vacío antes de asignarlo
                if (!string.IsNullOrEmpty(value))
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("El email no puede ser nulo o vacío.");
                }
            }
        }
        
        // Propiedad pública para indicar si la persona está activa (estado)
        public bool Estado
        {
            get { return estado; }
            set { estado = value; } // Controla si la persona está habilitada o no
        }

        // Propiedad de solo lectura que devuelve el nombre completo de la persona
        public string NombreCompleto
        {
            get
            {
                // Concatena los nombres y apellidos para formar el nombre completo
                return $"{nombres} {apellidos}";
            }
        }               
    }
}
