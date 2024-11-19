using ServicioTecnicoCelular.BD;
using ServicioTecnicoCelular.CS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ServicioTecnicoCelular.Global;

namespace ServicioTecnicoCelular.UI
{
    public partial class FrmIngresoOrdenes : Form
    {
        public FrmIngresoOrdenes()
        {
            InitializeComponent();         
        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            comboBox_celulares.DataSource =CelularData.ObtenerDispositivos();
            comboBox_celulares.DisplayMember = "modelo";
            comboBox_celulares.ValueMember = "Id";

            // Asignar evento y tipo de validación al ComboBox
            comboBox_celulares.Tag = ValidationType.ComboBoxNotEmpty;           
            comboBox_celulares.SelectedIndexChanged += ComboBox_SelectedIndexChanged; ;

            comboBoxTecnico.DataSource = TecnicoData.ObtenerTecnicos();
            comboBoxTecnico.DisplayMember = "NombreCompleto";
            comboBoxTecnico.ValueMember ="id";

            // Asignar evento y tipo de validación al ComboBox
            comboBoxTecnico.Tag = ValidationType.ComboBoxNotEmpty;
            comboBoxTecnico.SelectedIndexChanged += ComboBox_SelectedIndexChanged; ;

            richTextBox_motivo.Tag = ValidationType.NotEmpty;
            richTextBox_motivo.TextChanged += RichTextBox_TextChanged;

            comboBox_celulares.SelectedIndex = -1;
            comboBoxTecnico.SelectedIndex = -1;
            Global.LimpiarControles(this);
        }

        private void comboBoxTecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        public enum ValidationType
        {
            NotEmpty,
            Integer,
            Double,
            Email,
            ComboBoxNotEmpty,
            RadioButtonGroupNotEmpty,
            DataGridViewNotEmpty
        }

        private bool ValidateForm()
        {
            bool isFormValid = true;

            // Recorrer todos los controles del formulario de manera recursiva
            foreach (Control control in GetAllControls(this))
            {
                TextBox textBox = control as TextBox;
                RichTextBox richTextBox = control as RichTextBox;
                ComboBox comboBox = control as ComboBox;
                GroupBox groupBox = control as GroupBox;
                DataGridView dataGridView = control as DataGridView;
               
                if (richTextBox != null)
                {
                    if (richTextBox.Tag != null)
                    {
                        ValidationType validationType = (ValidationType)richTextBox.Tag;
                        if (!ValidateRichTextBox(richTextBox, validationType))
                        {
                            isFormValid = false;
                        }
                    }
                }
                
                if (comboBox != null)
                {
                    // Verificar si Tag es null para evitar NullReferenceException
                    if (comboBox.Tag != null)
                    {
                        ValidationType validationType = (ValidationType)comboBox.Tag;
                        if (!ValidateComboBox(comboBox, validationType))
                        {
                            isFormValid = false;
                        }
                    }
                    else
                    {
                        // Manejar el caso cuando Tag es null
                        // Puedes lanzar una excepción, mostrar un mensaje o simplemente ignorarlo
                        Console.WriteLine("Tag del ComboBox es null");
                    }
                }               
            }

            btn_guardar.Enabled = isFormValid; // Habilitar o deshabilitar el botón según la validación
            return isFormValid;
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

        private bool ValidateRichTextBox(RichTextBox richTextBox, ValidationType validationType)
        {
            string text = richTextBox.Text.Trim();

            switch (validationType)
            {
                case ValidationType.NotEmpty:
                    if (string.IsNullOrWhiteSpace(text))
                    {
                        richTextBox.BackColor = System.Drawing.Color.LightPink;
                        return false;
                    }
                    break;
            }
            // Restablecer el color de fondo si es válido
            richTextBox.BackColor = System.Drawing.Color.White;
            return true;
        }

        private IEnumerable<Control> GetAllControls(Control root)
        {
            var controls = root.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllControls(ctrl))
                            .Concat(controls);
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateForm();
            Celular celularSeleccionado = (Celular)comboBox_celulares.SelectedItem;
            if (celularSeleccionado != null)
            {
                txt_marca.Text = celularSeleccionado.Marca;
                txt_so.Text = celularSeleccionado.SistemaOperativo;
                textBoxTipo.Text = celularSeleccionado.TipoCelular;
                txt_propietario.Text = celularSeleccionado.Propietario.NombreCompleto;                
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            OrdenDeReparacion ordenTrabajo = new OrdenDeReparacion();
            try
            {
                ordenTrabajo.celular = (Celular)comboBox_celulares.SelectedItem;
                ordenTrabajo.estadoOrden = EstadoReparacion.Recibido.ToString();
                ordenTrabajo.tecnico = (Tecnico)comboBoxTecnico.SelectedItem;                
                ordenTrabajo.motivo = richTextBox_motivo.Text;

                //Almacenamiento
                OrdenReparacionData.AñadirOrdenReparacion(ordenTrabajo);
                MessageBox.Show("Registro almacenado correctamente...");
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
    }
}
