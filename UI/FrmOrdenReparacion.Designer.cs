namespace ServicioTecnicoCelular.UI
{
    partial class FrmOrdenReparacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdenReparacion));
            this.groupBox_informacion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTecnico = new System.Windows.Forms.TextBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.textBoxEstado = new System.Windows.Forms.TextBox();
            this.textBoxDispositivo = new System.Windows.Forms.TextBox();
            this.radioButtonCorrectivo = new System.Windows.Forms.RadioButton();
            this.radioButtonPreventivo = new System.Windows.Forms.RadioButton();
            this.lbl_mecanico = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_propietario = new System.Windows.Forms.Label();
            this.textBoxPropietario = new System.Windows.Forms.TextBox();
            this.lbl_motor = new System.Windows.Forms.Label();
            this.lbl_fabricante = new System.Windows.Forms.Label();
            this.textBoxSO = new System.Windows.Forms.TextBox();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.lbl_vehiculo = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.groupBox_diagnostico = new System.Windows.Forms.GroupBox();
            this.richTextBoxTrabajos = new System.Windows.Forms.RichTextBox();
            this.groupBox_detalleOrden = new System.Windows.Forms.GroupBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.dataGridView_detalleOrden = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox_itemCantidad = new System.Windows.Forms.GroupBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_agregar = new System.Windows.Forms.Button();
            this.comboBox_items = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxMotivo = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxDiagnostico = new System.Windows.Forms.RichTextBox();
            this.groupBox_informacion.SuspendLayout();
            this.groupBox_diagnostico.SuspendLayout();
            this.groupBox_detalleOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detalleOrden)).BeginInit();
            this.groupBox_itemCantidad.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_informacion
            // 
            this.groupBox_informacion.Controls.Add(this.label1);
            this.groupBox_informacion.Controls.Add(this.textBoxTecnico);
            this.groupBox_informacion.Controls.Add(this.textBoxFecha);
            this.groupBox_informacion.Controls.Add(this.textBoxEstado);
            this.groupBox_informacion.Controls.Add(this.textBoxDispositivo);
            this.groupBox_informacion.Controls.Add(this.radioButtonCorrectivo);
            this.groupBox_informacion.Controls.Add(this.radioButtonPreventivo);
            this.groupBox_informacion.Controls.Add(this.lbl_mecanico);
            this.groupBox_informacion.Controls.Add(this.lbl_fecha);
            this.groupBox_informacion.Controls.Add(this.lbl_propietario);
            this.groupBox_informacion.Controls.Add(this.textBoxPropietario);
            this.groupBox_informacion.Controls.Add(this.lbl_motor);
            this.groupBox_informacion.Controls.Add(this.lbl_fabricante);
            this.groupBox_informacion.Controls.Add(this.textBoxSO);
            this.groupBox_informacion.Controls.Add(this.lbl_placa);
            this.groupBox_informacion.Controls.Add(this.textBoxMarca);
            this.groupBox_informacion.Controls.Add(this.lbl_vehiculo);
            this.groupBox_informacion.Controls.Add(this.lbl_codigo);
            this.groupBox_informacion.Location = new System.Drawing.Point(14, 6);
            this.groupBox_informacion.Name = "groupBox_informacion";
            this.groupBox_informacion.Size = new System.Drawing.Size(1148, 135);
            this.groupBox_informacion.TabIndex = 0;
            this.groupBox_informacion.TabStop = false;
            this.groupBox_informacion.Text = "Información general";
            this.groupBox_informacion.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tipo de trabajo:";
            // 
            // textBoxTecnico
            // 
            this.textBoxTecnico.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTecnico.Location = new System.Drawing.Point(389, 91);
            this.textBoxTecnico.Name = "textBoxTecnico";
            this.textBoxTecnico.ReadOnly = true;
            this.textBoxTecnico.Size = new System.Drawing.Size(165, 20);
            this.textBoxTecnico.TabIndex = 24;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxFecha.Location = new System.Drawing.Point(899, 91);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.ReadOnly = true;
            this.textBoxFecha.Size = new System.Drawing.Size(185, 20);
            this.textBoxFecha.TabIndex = 23;
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxEstado.Location = new System.Drawing.Point(620, 91);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.ReadOnly = true;
            this.textBoxEstado.Size = new System.Drawing.Size(185, 20);
            this.textBoxEstado.TabIndex = 22;
            // 
            // textBoxDispositivo
            // 
            this.textBoxDispositivo.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDispositivo.Location = new System.Drawing.Point(97, 56);
            this.textBoxDispositivo.Name = "textBoxDispositivo";
            this.textBoxDispositivo.ReadOnly = true;
            this.textBoxDispositivo.Size = new System.Drawing.Size(216, 20);
            this.textBoxDispositivo.TabIndex = 21;
            // 
            // radioButtonCorrectivo
            // 
            this.radioButtonCorrectivo.AutoSize = true;
            this.radioButtonCorrectivo.Location = new System.Drawing.Point(233, 92);
            this.radioButtonCorrectivo.Name = "radioButtonCorrectivo";
            this.radioButtonCorrectivo.Size = new System.Drawing.Size(80, 17);
            this.radioButtonCorrectivo.TabIndex = 2;
            this.radioButtonCorrectivo.Text = "Reparación";
            this.radioButtonCorrectivo.UseVisualStyleBackColor = true;
            this.radioButtonCorrectivo.CheckedChanged += new System.EventHandler(this.radioButtonCorrectivo_CheckedChanged);
            // 
            // radioButtonPreventivo
            // 
            this.radioButtonPreventivo.AutoSize = true;
            this.radioButtonPreventivo.Location = new System.Drawing.Point(133, 92);
            this.radioButtonPreventivo.Name = "radioButtonPreventivo";
            this.radioButtonPreventivo.Size = new System.Drawing.Size(94, 17);
            this.radioButtonPreventivo.TabIndex = 1;
            this.radioButtonPreventivo.Text = "Mantenimiento";
            this.radioButtonPreventivo.UseVisualStyleBackColor = true;
            this.radioButtonPreventivo.CheckedChanged += new System.EventHandler(this.radioButtonPreventivo_CheckedChanged);
            // 
            // lbl_mecanico
            // 
            this.lbl_mecanico.AutoSize = true;
            this.lbl_mecanico.Location = new System.Drawing.Point(331, 94);
            this.lbl_mecanico.Name = "lbl_mecanico";
            this.lbl_mecanico.Size = new System.Drawing.Size(49, 13);
            this.lbl_mecanico.TabIndex = 15;
            this.lbl_mecanico.Text = "Técnico:";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(820, 96);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(40, 13);
            this.lbl_fecha.TabIndex = 13;
            this.lbl_fecha.Text = "Fecha:";
            this.lbl_fecha.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbl_propietario
            // 
            this.lbl_propietario.AutoSize = true;
            this.lbl_propietario.Location = new System.Drawing.Point(820, 63);
            this.lbl_propietario.Name = "lbl_propietario";
            this.lbl_propietario.Size = new System.Drawing.Size(60, 13);
            this.lbl_propietario.TabIndex = 11;
            this.lbl_propietario.Text = "Propietario:";
            // 
            // textBoxPropietario
            // 
            this.textBoxPropietario.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPropietario.Location = new System.Drawing.Point(899, 59);
            this.textBoxPropietario.Name = "textBoxPropietario";
            this.textBoxPropietario.ReadOnly = true;
            this.textBoxPropietario.Size = new System.Drawing.Size(185, 20);
            this.textBoxPropietario.TabIndex = 10;
            // 
            // lbl_motor
            // 
            this.lbl_motor.AutoSize = true;
            this.lbl_motor.Location = new System.Drawing.Point(564, 96);
            this.lbl_motor.Name = "lbl_motor";
            this.lbl_motor.Size = new System.Drawing.Size(43, 13);
            this.lbl_motor.TabIndex = 9;
            this.lbl_motor.Text = "Estado:";
            // 
            // lbl_fabricante
            // 
            this.lbl_fabricante.AutoSize = true;
            this.lbl_fabricante.Location = new System.Drawing.Point(569, 62);
            this.lbl_fabricante.Name = "lbl_fabricante";
            this.lbl_fabricante.Size = new System.Drawing.Size(28, 13);
            this.lbl_fabricante.TabIndex = 7;
            this.lbl_fabricante.Text = "S.O:";
            // 
            // textBoxSO
            // 
            this.textBoxSO.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSO.Location = new System.Drawing.Point(620, 59);
            this.textBoxSO.Name = "textBoxSO";
            this.textBoxSO.ReadOnly = true;
            this.textBoxSO.Size = new System.Drawing.Size(185, 20);
            this.textBoxSO.TabIndex = 6;
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(334, 63);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(40, 13);
            this.lbl_placa.TabIndex = 5;
            this.lbl_placa.Text = "Marca:";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxMarca.Location = new System.Drawing.Point(389, 57);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.ReadOnly = true;
            this.textBoxMarca.Size = new System.Drawing.Size(165, 20);
            this.textBoxMarca.TabIndex = 4;
            // 
            // lbl_vehiculo
            // 
            this.lbl_vehiculo.AutoSize = true;
            this.lbl_vehiculo.Location = new System.Drawing.Point(49, 59);
            this.lbl_vehiculo.Name = "lbl_vehiculo";
            this.lbl_vehiculo.Size = new System.Drawing.Size(42, 13);
            this.lbl_vehiculo.TabIndex = 3;
            this.lbl_vehiculo.Text = "Celular:";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_codigo.Location = new System.Drawing.Point(50, 19);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(102, 25);
            this.lbl_codigo.TabIndex = 0;
            this.lbl_codigo.Text = "N° órden:";
            this.lbl_codigo.Click += new System.EventHandler(this.lbl_codigo_Click);
            // 
            // groupBox_diagnostico
            // 
            this.groupBox_diagnostico.Controls.Add(this.richTextBoxTrabajos);
            this.groupBox_diagnostico.Location = new System.Drawing.Point(789, 147);
            this.groupBox_diagnostico.Name = "groupBox_diagnostico";
            this.groupBox_diagnostico.Size = new System.Drawing.Size(373, 107);
            this.groupBox_diagnostico.TabIndex = 18;
            this.groupBox_diagnostico.TabStop = false;
            this.groupBox_diagnostico.Text = "Trabajos realizados";
            // 
            // richTextBoxTrabajos
            // 
            this.richTextBoxTrabajos.Location = new System.Drawing.Point(11, 20);
            this.richTextBoxTrabajos.Name = "richTextBoxTrabajos";
            this.richTextBoxTrabajos.Size = new System.Drawing.Size(352, 76);
            this.richTextBoxTrabajos.TabIndex = 3;
            this.richTextBoxTrabajos.Text = "";
            // 
            // groupBox_detalleOrden
            // 
            this.groupBox_detalleOrden.Controls.Add(this.lbl_total);
            this.groupBox_detalleOrden.Controls.Add(this.lbl_iva);
            this.groupBox_detalleOrden.Controls.Add(this.lbl_subtotal);
            this.groupBox_detalleOrden.Controls.Add(this.txt_total);
            this.groupBox_detalleOrden.Controls.Add(this.dataGridView_detalleOrden);
            this.groupBox_detalleOrden.Controls.Add(this.txt_iva);
            this.groupBox_detalleOrden.Controls.Add(this.txt_subtotal);
            this.groupBox_detalleOrden.Location = new System.Drawing.Point(14, 334);
            this.groupBox_detalleOrden.Name = "groupBox_detalleOrden";
            this.groupBox_detalleOrden.Size = new System.Drawing.Size(1148, 248);
            this.groupBox_detalleOrden.TabIndex = 1;
            this.groupBox_detalleOrden.TabStop = false;
            this.groupBox_detalleOrden.Text = "Detalle de órden";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(981, 216);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(34, 13);
            this.lbl_total.TabIndex = 16;
            this.lbl_total.Text = "Total:";
            // 
            // lbl_iva
            // 
            this.lbl_iva.AutoSize = true;
            this.lbl_iva.Location = new System.Drawing.Point(981, 194);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(27, 13);
            this.lbl_iva.TabIndex = 2;
            this.lbl_iva.Text = "IVA:";
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Location = new System.Drawing.Point(981, 168);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(49, 13);
            this.lbl_subtotal.TabIndex = 1;
            this.lbl_subtotal.Text = "Subtotal:";
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.Window;
            this.txt_total.Location = new System.Drawing.Point(1037, 213);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(102, 20);
            this.txt_total.TabIndex = 15;
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dataGridView_detalleOrden
            // 
            this.dataGridView_detalleOrden.AllowUserToAddRows = false;
            this.dataGridView_detalleOrden.AllowUserToDeleteRows = false;
            this.dataGridView_detalleOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_detalleOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.Total});
            this.dataGridView_detalleOrden.Location = new System.Drawing.Point(12, 19);
            this.dataGridView_detalleOrden.Name = "dataGridView_detalleOrden";
            this.dataGridView_detalleOrden.ReadOnly = true;
            this.dataGridView_detalleOrden.Size = new System.Drawing.Size(1126, 137);
            this.dataGridView_detalleOrden.TabIndex = 10;
            this.dataGridView_detalleOrden.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_detalleOrden_CellValueChanged);
            this.dataGridView_detalleOrden.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_detalleOrden_RowsAdded);
            this.dataGridView_detalleOrden.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView_detalleOrden_RowsRemoved);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo producto";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 550;
            // 
            // Precio
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle1;
            this.Precio.HeaderText = "Precio unitario";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 160;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 160;
            // 
            // Total
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle3;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 160;
            // 
            // txt_iva
            // 
            this.txt_iva.BackColor = System.Drawing.SystemColors.Window;
            this.txt_iva.Location = new System.Drawing.Point(1036, 187);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.ReadOnly = true;
            this.txt_iva.Size = new System.Drawing.Size(102, 20);
            this.txt_iva.TabIndex = 14;
            this.txt_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.BackColor = System.Drawing.SystemColors.Window;
            this.txt_subtotal.Location = new System.Drawing.Point(1036, 161);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.ReadOnly = true;
            this.txt_subtotal.Size = new System.Drawing.Size(102, 20);
            this.txt_subtotal.TabIndex = 13;
            this.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(1054, 588);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(108, 33);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(940, 588);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(108, 33);
            this.btn_guardar.TabIndex = 11;
            this.btn_guardar.Text = "&Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // groupBox_itemCantidad
            // 
            this.groupBox_itemCantidad.Controls.Add(this.txt_cantidad);
            this.groupBox_itemCantidad.Controls.Add(this.button_eliminar);
            this.groupBox_itemCantidad.Controls.Add(this.button_agregar);
            this.groupBox_itemCantidad.Controls.Add(this.comboBox_items);
            this.groupBox_itemCantidad.Location = new System.Drawing.Point(12, 260);
            this.groupBox_itemCantidad.Name = "groupBox_itemCantidad";
            this.groupBox_itemCantidad.Size = new System.Drawing.Size(1150, 68);
            this.groupBox_itemCantidad.TabIndex = 12;
            this.groupBox_itemCantidad.TabStop = false;
            this.groupBox_itemCantidad.Text = "Seleccione un ítem e indique la cantidad";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(371, 30);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(68, 20);
            this.txt_cantidad.TabIndex = 7;
            // 
            // button_eliminar
            // 
            this.button_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("button_eliminar.Image")));
            this.button_eliminar.Location = new System.Drawing.Point(498, 19);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(47, 40);
            this.button_eliminar.TabIndex = 9;
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_agregar
            // 
            this.button_agregar.Image = ((System.Drawing.Image)(resources.GetObject("button_agregar.Image")));
            this.button_agregar.Location = new System.Drawing.Point(445, 19);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(47, 40);
            this.button_agregar.TabIndex = 8;
            this.button_agregar.UseVisualStyleBackColor = true;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // comboBox_items
            // 
            this.comboBox_items.FormattingEnabled = true;
            this.comboBox_items.Location = new System.Drawing.Point(15, 29);
            this.comboBox_items.Name = "comboBox_items";
            this.comboBox_items.Size = new System.Drawing.Size(350, 21);
            this.comboBox_items.TabIndex = 6;
            this.comboBox_items.SelectedIndexChanged += new System.EventHandler(this.comboBox_items_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxMotivo);
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 107);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descripción del problema";
            // 
            // richTextBoxMotivo
            // 
            this.richTextBoxMotivo.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxMotivo.Location = new System.Drawing.Point(13, 20);
            this.richTextBoxMotivo.Name = "richTextBoxMotivo";
            this.richTextBoxMotivo.ReadOnly = true;
            this.richTextBoxMotivo.Size = new System.Drawing.Size(352, 76);
            this.richTextBoxMotivo.TabIndex = 4;
            this.richTextBoxMotivo.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxDiagnostico);
            this.groupBox2.Location = new System.Drawing.Point(394, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 107);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diagnóstico";
            // 
            // richTextBoxDiagnostico
            // 
            this.richTextBoxDiagnostico.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxDiagnostico.Location = new System.Drawing.Point(13, 20);
            this.richTextBoxDiagnostico.Name = "richTextBoxDiagnostico";
            this.richTextBoxDiagnostico.ReadOnly = true;
            this.richTextBoxDiagnostico.Size = new System.Drawing.Size(352, 76);
            this.richTextBoxDiagnostico.TabIndex = 4;
            this.richTextBoxDiagnostico.Text = "";
            // 
            // FrmOrdenReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 628);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_diagnostico);
            this.Controls.Add(this.groupBox_itemCantidad);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox_detalleOrden);
            this.Controls.Add(this.groupBox_informacion);
            this.MaximizeBox = false;
            this.Name = "FrmOrdenReparacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación de órden de servicio";
            this.Load += new System.EventHandler(this.FrmOrdenTrabajo_Load);
            this.groupBox_informacion.ResumeLayout(false);
            this.groupBox_informacion.PerformLayout();
            this.groupBox_diagnostico.ResumeLayout(false);
            this.groupBox_detalleOrden.ResumeLayout(false);
            this.groupBox_detalleOrden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detalleOrden)).EndInit();
            this.groupBox_itemCantidad.ResumeLayout(false);
            this.groupBox_itemCantidad.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_informacion;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.GroupBox groupBox_detalleOrden;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label lbl_vehiculo;
        private System.Windows.Forms.Label lbl_fabricante;
        private System.Windows.Forms.TextBox textBoxSO;
        private System.Windows.Forms.Label lbl_propietario;
        private System.Windows.Forms.TextBox textBoxPropietario;
        private System.Windows.Forms.Label lbl_motor;
        private System.Windows.Forms.Label lbl_mecanico;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.GroupBox groupBox_diagnostico;
        private System.Windows.Forms.RichTextBox richTextBoxTrabajos;
        private System.Windows.Forms.DataGridView dataGridView_detalleOrden;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox groupBox_itemCantidad;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.ComboBox comboBox_items;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label lbl_iva;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.RadioButton radioButtonCorrectivo;
        private System.Windows.Forms.RadioButton radioButtonPreventivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxMotivo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxDiagnostico;
        private System.Windows.Forms.TextBox textBoxDispositivo;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.TextBox textBoxEstado;
        private System.Windows.Forms.TextBox textBoxTecnico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}