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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ServicioTecnicoCelular.UI
{
    public partial class FrmCelular : Form
    {
        Celular celular = new Celular();
        public FrmCelular()
        {
            InitializeComponent();            
            comboBox_propietario.DataSource = ClienteData.ObtenerClientes();
            comboBox_propietario.DisplayMember = "NombreCompleto";
            comboBox_propietario.ValueMember = "id";
            Global.LimpiarControles(this);
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

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateForm();
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
                //GroupBox groupBox = control as GroupBox;

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

                /*if (groupBox != null)
                {
                    ValidationType validationType = (ValidationType)groupBox.Tag;
                    if (!ValidateRadioButtonGroup(groupBox, validationType))
                    {
                        isFormValid = false;
                    }
                }*/
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

        /*private bool ValidateRadioButtonGroup(GroupBox groupBox, ValidationType validationType)
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
        }*/

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


        private void btn_guardar_Click(object sender, EventArgs e)
        {            
            try
            {
                celular.Marca = txt_marca.Text;
                celular.SistemaOperativo = txt_sistema_operativo.Text;
                celular.Modelo = txt_modelo.Text;
                celular.Color=txt_color.Text;
                celular.Almacenamiento= txt_almacenamiento.Text;
                celular.Pantalla= txt_pantalla.Text;
                celular.anio_fabricacion = int.Parse(txt_anioFabricacion.Text);
                celular.TipoCelular = comboBoxTipoDispositivo.SelectedItem.ToString();
                celular.Propietario = (Cliente)comboBox_propietario.SelectedItem;
                /*List<Vehiculo> vehiculos = new List<Vehiculo>();
                vehiculos= Global.Taller.Vehiculos.ObtenerVehiculos();*/

                //Almacenamiento                
                CelularData.AñadirDispositivo(celular);
                MessageBox.Show("Celular almacenado correctamente...");
                Global.LimpiarControles(this);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            // Asignar eventos de validación a los TextBox
            txt_marca.Tag = ValidationType.NotEmpty;
            txt_sistema_operativo.Tag = ValidationType.NotEmpty;
            txt_modelo.Tag = ValidationType.NotEmpty;
            txt_color.Tag = ValidationType.NotEmpty;
            txt_almacenamiento.Tag = ValidationType.NotEmpty;
            txt_pantalla.Tag= ValidationType.NotEmpty; 
            txt_anioFabricacion.Tag= ValidationType.Integer;

            // Asignar evento y tipo de validación al ComboBox
            comboBoxTipoDispositivo.Tag = ValidationType.ComboBoxNotEmpty;
            comboBoxTipoDispositivo.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

            comboBox_propietario.Tag = ValidationType.ComboBoxNotEmpty;
            comboBox_propietario.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

            txt_marca.TextChanged += TextBox_TextChanged;
            txt_sistema_operativo.TextChanged += TextBox_TextChanged;
            txt_modelo.TextChanged += TextBox_TextChanged;
            txt_color.TextChanged += TextBox_TextChanged;
            txt_almacenamiento.TextChanged += TextBox_TextChanged;
            txt_pantalla.TextChanged += TextBox_TextChanged;
            txt_anioFabricacion.TextChanged += TextBox_TextChanged;

            btn_guardar.Enabled = false;
        }

        /*private void Txt_motor_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }*/
    }
}
