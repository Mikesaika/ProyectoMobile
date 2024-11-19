using System;

namespace ServicioTecnicoCelular.CS
{
    public abstract class Persona
    {
        private int id;
        private string cedula;
        private string nombres;
        private string apellidos;
        private string telefono;
        private string email;        
        private bool estado;

        public int Id 
        {
            get { return id; }

            set { id = value; }
        }
        
        public string Cedula
        {
            get { return cedula; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    cedula = value;
                }
                else
                {
                    throw new ArgumentException("La cédula no puede ser nulo o vacío.");
                }
            }
        }

        public string Nombres
        {
            get { return nombres; }
            set
            {
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

        public string Apellidos
        {
            get { return apellidos; }
            set
            {
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

        public string Telefono
        {
            get { return telefono; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    telefono = value;
                }
                else
                {
                    throw new ArgumentException("El telefono no puede ser nulo o vacío.");
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
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
        
        public bool Estado
        {
            get { return estado; }
            set {  estado = value; }
        }

        public string NombreCompleto
        {
            get
            {
                return $"{nombres} {apellidos}";
            }
        }               
    }
}
