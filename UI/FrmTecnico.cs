﻿using ServicioTecnicoCelular.CS;
using ServicioTecnicoCelular;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicioTecnicoCelular.BD;

namespace ServicioTecnicoCelular.UI
{
    public partial class FrmTecnico : Form
    {
        public FrmTecnico()
        {
            InitializeComponent();
        }

        // Enum para los tipos de validación
        public enum ValidationType
        {
            NotEmpty,
            Integer,
            Email
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Tecnico tecnico = new Tecnico();
            try
            {
                tecnico.Cedula = txt_numIdentificacion.Text;
                tecnico.Nombres = txt_nombres.Text;
                tecnico.Apellidos = txt_apellidos.Text;
                tecnico.Email = txt_email.Text;
                tecnico.Telefono = txt_telefono.Text;
                tecnico.Especialidad = txt_especialidad.Text;
                tecnico.AniosExperiencia = int.Parse(txt_aniosExperiencia.Text);

                //Almacenamiento                
                TecnicoData.AñadirTecnico(tecnico);
                MessageBox.Show("Técnico almacenado correctamente...");
                Global.LimpiarControles(this);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmMecanico_Load(object sender, EventArgs e)
        {
            // Asignar eventos de validación a los TextBox
            txt_numIdentificacion.Tag = ValidationType.NotEmpty;
            txt_nombres.Tag = ValidationType.NotEmpty;
            txt_apellidos.Tag = ValidationType.NotEmpty;
            txt_telefono.Tag = ValidationType.NotEmpty;
            txt_email.Tag = ValidationType.Email;
            txt_especialidad.Tag = ValidationType.NotEmpty;
            txt_aniosExperiencia.Tag= ValidationType.Integer;

            txt_numIdentificacion.TextChanged += TextBox_TextChanged;
            txt_nombres.TextChanged += TextBox_TextChanged;
            txt_apellidos.TextChanged += TextBox_TextChanged;
            txt_telefono.TextChanged += TextBox_TextChanged;
            txt_email.TextChanged += TextBox_TextChanged;
            txt_especialidad.TextChanged+= TextBox_TextChanged;
            txt_aniosExperiencia.TextChanged += TextBox_TextChanged;

            btn_guardar.Enabled = false;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private bool ValidateForm()
        {
            bool isFormValid = true;

            // Recorrer todos los controles del formulario de manera recursiva
            foreach (Control control in GetAllControls(this))
            {
                TextBox textBox = control as TextBox;
                if (textBox != null)
                {
                    ValidationType validationType = (ValidationType)textBox.Tag;
                    if (!ValidateTextBox(textBox, validationType))
                    {
                        isFormValid = false;
                    }
                }
            }

            btn_guardar.Enabled = isFormValid; // Habilitar o deshabilitar el botón según la validación
            return isFormValid;
        }

        private IEnumerable<Control> GetAllControls(Control root)
        {
            var controls = root.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllControls(ctrl))
                            .Concat(controls);
        }

        private bool ValidateTextBox(TextBox textBox, ValidationType validationType)
        {
            string text = textBox.Text.Trim();

            switch (validationType)
            {
                case ValidationType.NotEmpty:
                    if (string.IsNullOrWhiteSpace(text))
                    {
                        textBox.BackColor = System.Drawing.Color.LightPink;
                        return false;
                    }
                    break;
                case ValidationType.Integer:
                    if (!int.TryParse(text, out _))
                    {
                        textBox.BackColor = System.Drawing.Color.LightPink;
                        return false;
                    }
                    break;
                case ValidationType.Email:
                    if (!IsValidEmail(text))
                    {
                        textBox.BackColor = System.Drawing.Color.LightPink;
                        return false;
                    }
                    break;
            }

            // Restablecer el color de fondo si es válido
            textBox.BackColor = System.Drawing.Color.White;
            return true;
        }

        private bool IsValidEmail(string email)
        {
            // Patrón para validar el correo electrónico
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void grp_datos_Enter(object sender, EventArgs e)
        {

        }
    }
}