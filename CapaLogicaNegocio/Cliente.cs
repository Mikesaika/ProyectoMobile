//USUARIO Y CONTRASEÑA PARA ENTRAR AL SISTEMA TALLER TÉCNICO CELULAR EN VISUAL ESTUDIO: USUARIO: admin CONTRASEÑA: admin
using ServicioTecnicoCelular.CS;
using System;
using System.Collections.Generic;

namespace ServicioTecnicoCelular.CS
{
    // Clase que representa a un cliente, derivada de la clase base `Persona`
    public class Cliente : Persona
    {
        // Campo privado para almacenar el tipo de cliente
        private string tipo_cliente;

        // Propiedad para acceder y modificar el tipo de cliente con validación
        public string TipoCliente
        {
            get { return tipo_cliente; }
            set
            {
                // Valida que el tipo de cliente no sea nulo o vacío
                if (!string.IsNullOrEmpty(value))
                {
                    tipo_cliente = value;
                }
                else
                {
                    // Lanza una excepción si el valor es inválido
                    throw new ArgumentException("El tipo de cliente no puede ser nulo o vacío.");
                }
            }
        }
    }
}
