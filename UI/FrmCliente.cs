using ServicioTecnicoCelular.CS;
using ServicioTecnicoCelular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using ServicioTecnicoCelular.BD;

namespace ServicioTecnicoCelular
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();            
        }



        // Enum para los tipos de validación
        public enum ValidationType
        {
            NotEmpty,
            Integer,
            Email,
            ComboBoxNotEmpty,
            RadioButtonGroupNotEmpty
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            try
            {
                cliente.Cedula = txt_numIdentificacion.Text;
                cliente.Nombres = txt_nombres.Text;
                cliente.Apellidos = txt_apellidos.Text;
                if (radio_personaNatural.Checked)
                    cliente.TipoCliente = radio_personaNatural.Text;
                else
                    cliente.TipoCliente = radio_juridica.Text;

                cliente.Email = txt_email.Text;
                cliente.Telefono = txt_telefono.Text;

                //Almacenamiento
                ClienteData.AñadirCliente(cliente);
                MessageBox.Show("Cliente almacenado correctamente...");
                Global.LimpiarControles(this);
                this.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_numIdentificacion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
          ValidateForm();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
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
                ComboBox comboBox = control as ComboBox;
                GroupBox groupBox = control as GroupBox;

                if (textBox != null)
                {
                    ValidationType validationType = (ValidationType)textBox.Tag;
                    if (!ValidateTextBox(textBox, validationType))
                    {
                        isFormValid = false;
                    }
                }

                if (comboBox != null)
                {
                    ValidationType validationType = (ValidationType)comboBox.Tag;
                    if (!ValidateComboBox(comboBox, validationType))
                    {
                        isFormValid = false;
                    }
                }

                if (groupBox != null)
                {
                    ValidationType validationType = (ValidationType)groupBox.Tag;
                    if (!ValidateRadioButtonGroup(groupBox, validationType))
                    {
                        isFormValid = false;
                    }
                }
            }

            btn_guardar.Enabled = isFormValid; // Habilitar o deshabilitar el botón según la validación
            return isFormValid;
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

        private bool ValidateComboBox(ComboBox comboBox, ValidationType validationType)
        {
            switch (validationType)
            {
                case ValidationType.ComboBoxNotEmpty:
                    if (comboBox.SelectedIndex == -1)
                    {
                        comboBox.BackColor = System.Drawing.Color.LightPink;
                        return false;
                    }
                    break;
            }

            // Restablecer el color de fondo si es válido
            comboBox.BackColor = System.Drawing.Color.White;
            return true;
        }

        private bool ValidateRadioButtonGroup(GroupBox groupBox, ValidationType validationType)
        {
            if (validationType == ValidationType.RadioButtonGroupNotEmpty)
            {
                bool isChecked = groupBox.Controls.OfType<RadioButton>().Any(rb => rb.Checked);
                foreach (RadioButton radioButton in groupBox.Controls.OfType<RadioButton>())
                {
                    if (!isChecked)
                    {
                        radioButton.BackColor = System.Drawing.Color.LightPink;
                    }
                    else
                    {
                        radioButton.BackColor = System.Drawing.Color.Transparent;
                    }
                }
                return isChecked;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            // Patrón para validar el correo electrónico
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private IEnumerable<Control> GetAllControls(Control root)
        {
            var controls = root.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllControls(ctrl))
                            .Concat(controls);
        }

        /*private bool ValidateForm()
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
        }*/

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // Asignar eventos de validación a los TextBox
            txt_numIdentificacion.Tag = ValidationType.NotEmpty;
            txt_nombres.Tag = ValidationType.NotEmpty;
            txt_apellidos.Tag = ValidationType.NotEmpty;
            txt_telefono.Tag = ValidationType.NotEmpty;
            txt_email.Tag = ValidationType.Email;

            // Asignar evento y tipo de validación al GroupBox que contiene los RadioButton
            grp_datos.Tag = ValidationType.RadioButtonGroupNotEmpty;
            foreach (Control control in grp_datos.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.CheckedChanged += RadioButton_CheckedChanged;
                }
            }

            txt_numIdentificacion.TextChanged += TextBox_TextChanged;
            txt_nombres.TextChanged += TextBox_TextChanged;
            txt_apellidos.TextChanged += TextBox_TextChanged;
            txt_telefono.TextChanged += TextBox_TextChanged;
            txt_email.TextChanged += TextBox_TextChanged;

            btn_guardar.Enabled = false;
        }
    }
}
