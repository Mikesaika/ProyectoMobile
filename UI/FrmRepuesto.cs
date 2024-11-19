using ServicioTecnicoCelular.CS;
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
    public partial class FrmRepuesto : Form
    {
        public FrmRepuesto()
        {
            InitializeComponent();
        }

        // Enum para los tipos de validación
        public enum ValidationType
        {
            NotEmpty,
            Integer,
            Double,
            Email,
            ComboBoxNotEmpty,
            RadioButtonGroupNotEmpty
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
                //ComboBox comboBox = control as ComboBox;
                //GroupBox groupBox = control as GroupBox;

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
                case ValidationType.Double:
                    if (!double.TryParse(text, out _))
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

        private IEnumerable<Control> GetAllControls(Control root)
        {
            var controls = root.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllControls(ctrl))
                            .Concat(controls);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ItemRepuesto repuesto = new ItemRepuesto();
            try
            {
                repuesto.Nombre = txt_nombre.Text;
                repuesto.TipoItem = "Repuesto";
                repuesto.PaisImportacion  = txt_paisImportacion.Text;
                repuesto.Costo = double.Parse(txt_costo.Text);
                repuesto.Precio = double.Parse(txt_precio.Text);

                //Almacenamiento
                RepuestoData.AñadirRepuesto(repuesto);                
                MessageBox.Show("Repuesto almacenado correctamente...");
                Global.LimpiarControles(this);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grp_datos_Enter(object sender, EventArgs e)
        {

        }

        private void FrmRepuesto_Load(object sender, EventArgs e)
        {
            // Asignar eventos de validación a los TextBox
            txt_nombre.Tag = ValidationType.NotEmpty;
            txt_paisImportacion.Tag = ValidationType.NotEmpty;
            txt_costo.Tag = ValidationType.Double;
            txt_precio.Tag = ValidationType.Double;

            txt_nombre.TextChanged += TextBox_TextChanged;
            txt_paisImportacion.TextChanged += TextBox_TextChanged;
            txt_costo.TextChanged += TextBox_TextChanged;
            txt_precio.TextChanged += TextBox_TextChanged;

            btn_guardar.Enabled = false;
        }

        private void label1_Pais_importacion_Click(object sender, EventArgs e)
        {

        }
    }
}
