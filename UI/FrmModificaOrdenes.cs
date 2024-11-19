using ServicioTecnicoCelular.BD;
using ServicioTecnicoCelular.CS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServicioTecnicoCelular.UI
{
    public partial class FrmModificaOrdenes : Form
    {
        private int codigo;
        private Form childForm;
        public FrmModificaOrdenes(OrdenDeReparacionView ordenDeReparacionView)
        {
            InitializeComponent();
            richTextBox_diagnostico.Select();
            richTextBox_diagnostico.Focus();
            codigo = ordenDeReparacionView.Orden;
            textBoxDispositivo.Text = ordenDeReparacionView.Dispositivo;
            txt_marca.Text = ordenDeReparacionView.Marca;
            txt_so.Text = ordenDeReparacionView.SistemaOperativo;
            txt_propietario.Text = ordenDeReparacionView.Cliente;
            textBoxTipo.Text=ordenDeReparacionView.Tipo;
            textBoxTecnico.Text = ordenDeReparacionView.Tecnico;
            richTextBox_motivo.Text = ordenDeReparacionView.Motivo;
            richTextBox_diagnostico.Text = ordenDeReparacionView.Diagnostico;

            if (ordenDeReparacionView.Autorizado)
            {
                richTextBox_diagnostico.ReadOnly = true;
                richTextBox_diagnostico.BackColor=Color.White;
                checkBoxAutorizado.Checked = ordenDeReparacionView.Autorizado;
                checkBoxAutorizado.Enabled = false;
                btn_guardar.Enabled = false;
            }                        
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new FrmConsultaOrdenes();
                childForm.MdiParent = FrmMenuPrincipal.ActiveForm;
                childForm.Text = "Consulta de órdenes";
                childForm.Show();
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            OrdenDeReparacion ordenDeReparacion = new OrdenDeReparacion();
            try
            {
                ordenDeReparacion.Codigo = codigo;
                ordenDeReparacion.diagnostico = richTextBox_diagnostico.Text;
                
                if (checkBoxAutorizado.Checked)                
                    ordenDeReparacion.estadoOrden = Global.EstadoReparacion.EnReparacion.ToString();                                     
                else
                    ordenDeReparacion.estadoOrden = Global.EstadoReparacion.Diagnostico.ToString();

                ordenDeReparacion.autorizado = checkBoxAutorizado.Checked;

                //Almacenamiento
                OrdenReparacionData.ModificarOrdenReparacion(ordenDeReparacion);
                MessageBox.Show("Registro almacenado correctamente...");
                Global.LimpiarControles(this);
                this.Close();
                
                if (childForm == null || childForm.IsDisposed)
                {
                    childForm = new FrmConsultaOrdenes();
                    childForm.MdiParent = FrmMenuPrincipal.ActiveForm;
                    childForm.Text = "Consulta de órdenes";
                    childForm.Show();
                }
                else
                {
                    // Traer el formulario al frente si ya está abierto
                    childForm.BringToFront();
                    childForm.WindowState = FormWindowState.Normal;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmModificaOrdenes_Load(object sender, EventArgs e)
        {
            richTextBox_diagnostico.Tag = ValidationType.NotEmpty;
            richTextBox_diagnostico.TextChanged += RichTextBox_TextChanged;
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
                RichTextBox richTextBox = control as RichTextBox;
             
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
            }

            btn_guardar.Enabled = isFormValid; // Habilitar o deshabilitar el botón según la validación
            return isFormValid;
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

        private void checkBoxAutorizado_CheckedChanged(object sender, EventArgs e)
        {
            if (!btn_guardar.Enabled && richTextBox_diagnostico.Text != String.Empty)
                btn_guardar.Enabled = true;
        }
    }
}
