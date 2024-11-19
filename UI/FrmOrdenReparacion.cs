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
    public partial class FrmOrdenReparacion : Form
    {
        private int NumeroOrden;
        private int IdItem;
        private string ItemNombre;
        private double ItemPrecio;
        private int ItemHoras;
        private Form childForm;

        public FrmOrdenReparacion(OrdenDeReparacionView ordenDeReparacionView)
        {
            InitializeComponent();
            lbl_codigo.Text = "N° " + ordenDeReparacionView.Orden;
            NumeroOrden= ordenDeReparacionView.Orden;
            textBoxDispositivo.Text = ordenDeReparacionView.Dispositivo;
            textBoxMarca.Text = ordenDeReparacionView.Marca;
            textBoxSO.Text = ordenDeReparacionView.SistemaOperativo;
            textBoxPropietario.Text = ordenDeReparacionView.Cliente;
            textBoxTecnico.Text = ordenDeReparacionView.Tecnico;
            textBoxEstado.Text = ordenDeReparacionView.EstadoOrden;
            textBoxFecha.Text = ordenDeReparacionView.Fecha.ToString();
            richTextBoxMotivo.Text = ordenDeReparacionView.Motivo;
            richTextBoxDiagnostico.Text = ordenDeReparacionView.Diagnostico;
        }

        // Enum para los tipos de validación
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
        

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }
        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void DataGridView_RowsChanged(object sender, EventArgs e)
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
                RichTextBox richTextBox = control as RichTextBox;
                ComboBox comboBox = control as ComboBox;
                GroupBox groupBox = control as GroupBox;
                DataGridView dataGridView = control as DataGridView;

                /*if (textBox != null)
                {
                    ValidationType validationType = (ValidationType)textBox.Tag;
                    if (!ValidateTextBox(textBox, validationType))
                    {
                        isFormValid = false;
                    }
                }*/
              
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

                if (groupBox != null)
                {
                    if (groupBox.Tag != null)
                    {
                        ValidationType validationType = (ValidationType)groupBox.Tag;
                        if (!ValidateRadioButtonGroup(groupBox, validationType))
                        {
                            isFormValid = false;
                        }
                    }
                    else
                    {
                        // Manejar el caso cuando Tag es null
                        // Puedes lanzar una excepción, mostrar un mensaje o simplemente ignorarlo
                        Console.WriteLine("Tag del GroupBox es null");
                    }
                }

                if (dataGridView != null)
                {
                    ValidationType validationType = (ValidationType)dataGridView.Tag;
                    if (!ValidateDataGridView(dataGridView, validationType))
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
            }

            // Restablecer el color de fondo si es válido
            textBox.BackColor = System.Drawing.Color.White;
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

        private bool ValidateDataGridView(DataGridView dataGridView, ValidationType validationType)
        {
            if (validationType == ValidationType.DataGridViewNotEmpty)
            {
                if (dataGridView.Rows.Count == 0)
                {
                    dataGridView.BackgroundColor = System.Drawing.Color.LightPink;
                    return false;
                }
            }

            // Restablecer el color de fondo si es válido
            dataGridView.BackgroundColor = System.Drawing.Color.White;
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
        
        private IEnumerable<Control> GetAllControls(Control root)
        {
            var controls = root.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllControls(ctrl))
                            .Concat(controls);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_vehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {            
            /*Celular celularSeleccionado = (Celular)comboBox_celulares.SelectedItem;
            if (celularSeleccionado != null)
            {
                textBoxMarca.Text = celularSeleccionado.Marca;
                textBoxModelo.Text = celularSeleccionado.Modelo;                
                textBoxPropietario.Text = celularSeleccionado.Propietario.NombreCompleto;
            } */           
        }

        private void comboBox_tipoMantenimiento_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
            if (!(txt_cantidad.Text == String.Empty) && !(comboBox_items.Text==String.Empty))
            {
                dataGridView_detalleOrden.Rows.Add(IdItem, ItemNombre, ItemPrecio, int.Parse(txt_cantidad.Text));
                comboBox_items.SelectedIndex = -1;
                txt_cantidad.Text = string.Empty;
                txt_cantidad.ReadOnly = false;
            }
        }

        private void comboBox_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item itemSeleccionado = (Item)comboBox_items.SelectedItem;
            if (itemSeleccionado != null)
            {
                if(itemSeleccionado.TipoItem=="Repuesto")
                {
                    ItemRepuesto itemRepuesto = (ItemRepuesto)comboBox_items.SelectedItem;
                    txt_cantidad.ReadOnly = false;
                    IdItem = itemRepuesto.Id;
                    ItemNombre = itemRepuesto.Nombre;
                    ItemPrecio = itemRepuesto.Precio;
                }

                if (itemSeleccionado.TipoItem == "Servicio")
                {
                    ItemServicio itemServicio = (ItemServicio)comboBox_items.SelectedItem;                   
                    txt_cantidad.ReadOnly = true;   
                    txt_cantidad.BackColor=Color.White;
                    IdItem = itemServicio.Id;
                    ItemNombre = itemServicio.Nombre;
                    ItemPrecio = itemServicio.Precio;  
                    ItemHoras = itemServicio.Horas;
                    txt_cantidad.Text = ItemHoras.ToString();
                }                
            }
        }

        private void CalcularFila(int rowIndex)
        {           
            if (rowIndex < 0 || rowIndex >= dataGridView_detalleOrden.Rows.Count) return;

            var row = dataGridView_detalleOrden.Rows[rowIndex];
            if (row.Cells["Precio"].Value != null && row.Cells["Cantidad"].Value != null)
            {
                decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                row.Cells["Total"].Value = precio * cantidad;
            }
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView_detalleOrden.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }
            txt_subtotal.Text = total.ToString("C");

            // Calcular el IVA
            decimal iva = total * (decimal)Global.IVA;
            txt_iva.Text = iva.ToString("C");

            // Calcular el total con IVA
            decimal totalConIVA = total + iva;
            txt_total.Text = totalConIVA.ToString("C");
        }

        private void dataGridView_detalleOrden_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalcularFila(e.RowIndex);
            CalcularTotal();
        }

        private void dataGridView_detalleOrden_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcularFila(e.RowIndex);
            CalcularTotal();
        }

        private void dataGridView_detalleOrden_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {            
            // Verificar que el índice de la fila sea válido
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_detalleOrden.Rows.Count)
            {
                if (e.ColumnIndex == 0 || e.ColumnIndex == 1) // Precio o Cantidad cambiado
                {
                    CalcularFila(e.RowIndex);
                    CalcularTotal();
                }
            }
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {            
            if (dataGridView_detalleOrden.SelectedRows.Count > 0)
            {
                // Recolectar las filas seleccionadas para eliminar
                foreach (DataGridViewRow row in dataGridView_detalleOrden.SelectedRows)
                {
                    // Verificar que la fila no sea nueva (porque las nuevas filas no deben ser eliminadas)
                    if (!row.IsNewRow)
                    {
                        dataGridView_detalleOrden.Rows.Remove(row);
                    }
                }
                // Recalcular los totales después de eliminar las filas
                CalcularTotal();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Eliminar Fila", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            OrdenDeReparacion ordenTrabajo = new OrdenDeReparacion();
            try
            {
                ordenTrabajo.Codigo = NumeroOrden;
                
                if (radioButtonPreventivo.Checked)                
                    ordenTrabajo.TipoServicio = radioButtonPreventivo.Text;                                     
                
                if (radioButtonCorrectivo.Checked)                     
                    ordenTrabajo.TipoServicio = radioButtonCorrectivo.Text;                                                                
                                                
                ordenTrabajo.TrabajoRealizado=richTextBoxTrabajos.Text;
                ordenTrabajo.estadoOrden = Global.EstadoReparacion.Reparado.ToString();                                 
                    
                    //if(estadoSeleccionado==Global.EstadoReparacion.Reparado)
                    //{
                        List<OrdenReparacionDetalle> ordenTrabajoDetalles = new List<OrdenReparacionDetalle>();

                        // Recorrer el DataGridView
                        foreach (DataGridViewRow row in dataGridView_detalleOrden.Rows)
                        {
                            if (!row.IsNewRow) // Excluir la fila nueva, si la hay
                            {
                                OrdenReparacionDetalle ordenTrabajoDetalle = new OrdenReparacionDetalle();
                                // Obtener los valores de las celdas
                                ordenTrabajoDetalle.codigo = NumeroOrden;
                                ordenTrabajoDetalle.IdItem= Convert.ToInt32(row.Cells["Codigo"].Value);
                                ordenTrabajoDetalle.Item = (string)row.Cells["Descripcion"].Value;
                                ordenTrabajoDetalle.Precio = Convert.ToDouble(row.Cells["Precio"].Value);
                                ordenTrabajoDetalle.Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                                ordenTrabajoDetalle.Total = Convert.ToDouble(row.Cells["Total"].Value);

                                // Guardar el detalle de la órden de trabajo
                                ordenTrabajoDetalles.Add(ordenTrabajoDetalle);
                            }
                        }

                        ordenTrabajo.detalles = ordenTrabajoDetalles;

                        // Obtener el texto de la caja de texto
                        string textoSubtotal = txt_subtotal.Text;

                        // Remover cualquier caracter que no sea numérico, el punto decimal o coma
                        textoSubtotal = textoSubtotal.Replace("$", "").Replace(",", "").Trim();

                        // Convertir el texto a double
                        double subtotal;
                        if (double.TryParse(textoSubtotal, out subtotal))
                        {
                            // Asignar el subtotal convertido a la propiedad Subtotal de la orden de trabajo
                            ordenTrabajo.Subtotal = subtotal;
                        }
                        else
                        {
                            // Manejar el caso en que la conversión falle
                            MessageBox.Show("El valor en la caja de texto no es válido.", "Error de Conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // Obtener el texto de la caja de texto
                        string textoIva = txt_iva.Text;

                        // Remover cualquier caracter que no sea numérico, el punto decimal o coma
                        textoIva = textoIva.Replace("$", "").Replace(",", "").Trim();

                        // Convertir el texto a double
                        double iva;
                        if (double.TryParse(textoIva, out iva))
                        {
                            // Asignar el subtotal convertido a la propiedad Subtotal de la orden de trabajo
                            ordenTrabajo.Iva = iva;
                        }
                        else
                        {
                            // Manejar el caso en que la conversión falle
                            MessageBox.Show("El valor en la caja de texto no es válido.", "Error de Conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // Obtener el texto de la caja de texto
                        string textoTotal = txt_total.Text;

                        // Remover cualquier caracter que no sea numérico, el punto decimal o coma
                        textoTotal = textoTotal.Replace("$", "").Replace(",", "").Trim();

                        // Convertir el texto a double
                        double total;
                        if (double.TryParse(textoTotal, out total))
                        {
                            // Asignar el subtotal convertido a la propiedad Subtotal de la orden de trabajo
                            ordenTrabajo.Total = total;
                        }
                        else
                        {
                            // Manejar el caso en que la conversión falle
                            MessageBox.Show("El valor en la caja de texto no es válido.", "Error de Conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    //}                                                
                
                               
                //Almacenamiento
                OrdenReparacionData.CerrarOrdenReparacion(ordenTrabajo);
                MessageBox.Show("Órden de Reparación almacenada correctamente...");
                Global.LimpiarControles(this);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonPreventivo_CheckedChanged(object sender, EventArgs e)
        {
            comboBox_items.DataSource = ServicioData.ObtenerServicios();
            comboBox_items.DisplayMember = "Nombre";
            comboBox_items.ValueMember = "Id";
            comboBox_items.SelectedIndex = -1;
            txt_cantidad.Text = string.Empty;            
        }

        private void radioButtonCorrectivo_CheckedChanged(object sender, EventArgs e)
        {
            List<Item> items = new List<Item>();
            items.AddRange(RepuestoData.ObtenerRepuestos());
            items.AddRange(ServicioData.ObtenerServicios());
            comboBox_items.DataSource = items;
            comboBox_items.DisplayMember = "Nombre";
            comboBox_items.ValueMember = "Id";
            comboBox_items.SelectedIndex = -1;            
        }

        private void FrmOrdenTrabajo_Load(object sender, EventArgs e)
        {            
            /*comboBox_celulares.DataSource = Global.Taller.Celulares.ObtenerVehiculos();
            comboBox_celulares.DisplayMember = "marca";
            comboBox_celulares.ValueMember = "marca";*/

            /*comboBox_tecnicos.DataSource = Global.Taller.Tecnicos.ObtenerMecanicos();
            comboBox_tecnicos.DisplayMember = "NombreCompleto";
            comboBox_tecnicos.ValueMember = "Cedula";*/
            //Global.LimpiarControles(this);
                        
            richTextBoxTrabajos.Tag = ValidationType.NotEmpty;

            // Asignar evento y tipo de validación al ComboBox
            //comboBox_celulares.Tag = ValidationType.ComboBoxNotEmpty;
            //comboBox_celulares.SelectedIndexChanged += ComboBox_SelectedIndexChanged;

            //comboBox_tecnicos.Tag = ValidationType.ComboBoxNotEmpty;
            //comboBox_tecnicos.SelectedIndexChanged+= ComboBox_SelectedIndexChanged;

            // Asignar evento y tipo de validación al GroupBox que contiene los RadioButton
            groupBox_informacion.Tag = ValidationType.RadioButtonGroupNotEmpty;
            foreach (Control control in groupBox_informacion.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.CheckedChanged += RadioButton_CheckedChanged;
                }
            }

            // Asignar tipo de validación al DataGridView
            dataGridView_detalleOrden.Tag = ValidationType.DataGridViewNotEmpty;
            dataGridView_detalleOrden.RowsAdded += DataGridView_RowsChanged;
            dataGridView_detalleOrden.RowsRemoved += DataGridView_RowsChanged;
          
            richTextBoxTrabajos.TextChanged += RichTextBox_TextChanged;

            btn_guardar.Enabled = false;            
        }

        private void lbl_codigo_Click(object sender, EventArgs e)
        {

        }      
    }    
}
