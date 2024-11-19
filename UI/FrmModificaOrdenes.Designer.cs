namespace ServicioTecnicoCelular.UI
{
    partial class FrmModificaOrdenes
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox_informacion = new System.Windows.Forms.GroupBox();
            this.textBoxTecnico = new System.Windows.Forms.TextBox();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.textBoxDispositivo = new System.Windows.Forms.TextBox();
            this.checkBoxAutorizado = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox_diagnostico = new System.Windows.Forms.RichTextBox();
            this.groupBox_diagnostico = new System.Windows.Forms.GroupBox();
            this.richTextBox_motivo = new System.Windows.Forms.RichTextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_propietario = new System.Windows.Forms.Label();
            this.txt_propietario = new System.Windows.Forms.TextBox();
            this.lbl_motor = new System.Windows.Forms.Label();
            this.lbl_fabricante = new System.Windows.Forms.Label();
            this.txt_so = new System.Windows.Forms.TextBox();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.lbl_vehiculo = new System.Windows.Forms.Label();
            this.groupBox_informacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_diagnostico.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(437, 411);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(108, 33);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Enabled = false;
            this.btn_guardar.Location = new System.Drawing.Point(323, 411);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(108, 33);
            this.btn_guardar.TabIndex = 3;
            this.btn_guardar.Text = "&Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // groupBox_informacion
            // 
            this.groupBox_informacion.Controls.Add(this.textBoxTecnico);
            this.groupBox_informacion.Controls.Add(this.textBoxTipo);
            this.groupBox_informacion.Controls.Add(this.textBoxDispositivo);
            this.groupBox_informacion.Controls.Add(this.checkBoxAutorizado);
            this.groupBox_informacion.Controls.Add(this.groupBox1);
            this.groupBox_informacion.Controls.Add(this.groupBox_diagnostico);
            this.groupBox_informacion.Controls.Add(this.lbl_fecha);
            this.groupBox_informacion.Controls.Add(this.lbl_propietario);
            this.groupBox_informacion.Controls.Add(this.txt_propietario);
            this.groupBox_informacion.Controls.Add(this.lbl_motor);
            this.groupBox_informacion.Controls.Add(this.lbl_fabricante);
            this.groupBox_informacion.Controls.Add(this.txt_so);
            this.groupBox_informacion.Controls.Add(this.lbl_placa);
            this.groupBox_informacion.Controls.Add(this.txt_marca);
            this.groupBox_informacion.Controls.Add(this.lbl_vehiculo);
            this.groupBox_informacion.Location = new System.Drawing.Point(12, 13);
            this.groupBox_informacion.Name = "groupBox_informacion";
            this.groupBox_informacion.Size = new System.Drawing.Size(552, 392);
            this.groupBox_informacion.TabIndex = 7;
            this.groupBox_informacion.TabStop = false;
            this.groupBox_informacion.Text = "Información general";
            // 
            // textBoxTecnico
            // 
            this.textBoxTecnico.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTecnico.Location = new System.Drawing.Point(366, 80);
            this.textBoxTecnico.Name = "textBoxTecnico";
            this.textBoxTecnico.ReadOnly = true;
            this.textBoxTecnico.Size = new System.Drawing.Size(165, 20);
            this.textBoxTecnico.TabIndex = 24;
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTipo.Location = new System.Drawing.Point(366, 53);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.ReadOnly = true;
            this.textBoxTipo.Size = new System.Drawing.Size(165, 20);
            this.textBoxTipo.TabIndex = 23;
            // 
            // textBoxDispositivo
            // 
            this.textBoxDispositivo.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDispositivo.Location = new System.Drawing.Point(106, 26);
            this.textBoxDispositivo.Name = "textBoxDispositivo";
            this.textBoxDispositivo.ReadOnly = true;
            this.textBoxDispositivo.Size = new System.Drawing.Size(185, 20);
            this.textBoxDispositivo.TabIndex = 21;
            // 
            // checkBoxAutorizado
            // 
            this.checkBoxAutorizado.AutoSize = true;
            this.checkBoxAutorizado.Location = new System.Drawing.Point(19, 354);
            this.checkBoxAutorizado.Name = "checkBoxAutorizado";
            this.checkBoxAutorizado.Size = new System.Drawing.Size(183, 17);
            this.checkBoxAutorizado.TabIndex = 2;
            this.checkBoxAutorizado.Text = "Cliente autoriza trabajos a realizar";
            this.checkBoxAutorizado.UseVisualStyleBackColor = true;
            this.checkBoxAutorizado.CheckedChanged += new System.EventHandler(this.checkBoxAutorizado_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox_diagnostico);
            this.groupBox1.Location = new System.Drawing.Point(19, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 107);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diagnóstico";
            // 
            // richTextBox_diagnostico
            // 
            this.richTextBox_diagnostico.Location = new System.Drawing.Point(13, 20);
            this.richTextBox_diagnostico.Name = "richTextBox_diagnostico";
            this.richTextBox_diagnostico.Size = new System.Drawing.Size(488, 76);
            this.richTextBox_diagnostico.TabIndex = 1;
            this.richTextBox_diagnostico.Text = "";
            // 
            // groupBox_diagnostico
            // 
            this.groupBox_diagnostico.Controls.Add(this.richTextBox_motivo);
            this.groupBox_diagnostico.Location = new System.Drawing.Point(19, 118);
            this.groupBox_diagnostico.Name = "groupBox_diagnostico";
            this.groupBox_diagnostico.Size = new System.Drawing.Size(514, 107);
            this.groupBox_diagnostico.TabIndex = 18;
            this.groupBox_diagnostico.TabStop = false;
            this.groupBox_diagnostico.Text = "Descripción del problema";
            // 
            // richTextBox_motivo
            // 
            this.richTextBox_motivo.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_motivo.Location = new System.Drawing.Point(13, 20);
            this.richTextBox_motivo.Name = "richTextBox_motivo";
            this.richTextBox_motivo.ReadOnly = true;
            this.richTextBox_motivo.Size = new System.Drawing.Size(488, 76);
            this.richTextBox_motivo.TabIndex = 5;
            this.richTextBox_motivo.Text = "";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Location = new System.Drawing.Point(311, 84);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(49, 13);
            this.lbl_fecha.TabIndex = 13;
            this.lbl_fecha.Text = "Técnico:";
            // 
            // lbl_propietario
            // 
            this.lbl_propietario.AutoSize = true;
            this.lbl_propietario.Location = new System.Drawing.Point(27, 84);
            this.lbl_propietario.Name = "lbl_propietario";
            this.lbl_propietario.Size = new System.Drawing.Size(60, 13);
            this.lbl_propietario.TabIndex = 11;
            this.lbl_propietario.Text = "Propietario:";
            // 
            // txt_propietario
            // 
            this.txt_propietario.BackColor = System.Drawing.SystemColors.Window;
            this.txt_propietario.Location = new System.Drawing.Point(106, 80);
            this.txt_propietario.Name = "txt_propietario";
            this.txt_propietario.ReadOnly = true;
            this.txt_propietario.Size = new System.Drawing.Size(185, 20);
            this.txt_propietario.TabIndex = 10;
            // 
            // lbl_motor
            // 
            this.lbl_motor.AutoSize = true;
            this.lbl_motor.Location = new System.Drawing.Point(312, 56);
            this.lbl_motor.Name = "lbl_motor";
            this.lbl_motor.Size = new System.Drawing.Size(31, 13);
            this.lbl_motor.TabIndex = 9;
            this.lbl_motor.Text = "Tipo:";
            // 
            // lbl_fabricante
            // 
            this.lbl_fabricante.AutoSize = true;
            this.lbl_fabricante.Location = new System.Drawing.Point(27, 56);
            this.lbl_fabricante.Name = "lbl_fabricante";
            this.lbl_fabricante.Size = new System.Drawing.Size(28, 13);
            this.lbl_fabricante.TabIndex = 7;
            this.lbl_fabricante.Text = "S.O:";
            // 
            // txt_so
            // 
            this.txt_so.BackColor = System.Drawing.SystemColors.Window;
            this.txt_so.Location = new System.Drawing.Point(106, 52);
            this.txt_so.Name = "txt_so";
            this.txt_so.ReadOnly = true;
            this.txt_so.Size = new System.Drawing.Size(185, 20);
            this.txt_so.TabIndex = 6;
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(313, 33);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(40, 13);
            this.lbl_placa.TabIndex = 5;
            this.lbl_placa.Text = "Marca:";
            // 
            // txt_marca
            // 
            this.txt_marca.BackColor = System.Drawing.SystemColors.Window;
            this.txt_marca.Location = new System.Drawing.Point(368, 27);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.ReadOnly = true;
            this.txt_marca.Size = new System.Drawing.Size(165, 20);
            this.txt_marca.TabIndex = 22;
            // 
            // lbl_vehiculo
            // 
            this.lbl_vehiculo.AutoSize = true;
            this.lbl_vehiculo.Location = new System.Drawing.Point(28, 29);
            this.lbl_vehiculo.Name = "lbl_vehiculo";
            this.lbl_vehiculo.Size = new System.Drawing.Size(42, 13);
            this.lbl_vehiculo.TabIndex = 3;
            this.lbl_vehiculo.Text = "Celular:";
            // 
            // FrmModificaOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 451);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox_informacion);
            this.MaximizeBox = false;
            this.Name = "FrmModificaOrdenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifica órden de servicio";
            this.Load += new System.EventHandler(this.FrmModificaOrdenes_Load);
            this.groupBox_informacion.ResumeLayout(false);
            this.groupBox_informacion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox_diagnostico.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox groupBox_informacion;
        private System.Windows.Forms.GroupBox groupBox_diagnostico;
        private System.Windows.Forms.RichTextBox richTextBox_motivo;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_propietario;
        private System.Windows.Forms.TextBox txt_propietario;
        private System.Windows.Forms.Label lbl_motor;
        private System.Windows.Forms.Label lbl_fabricante;
        private System.Windows.Forms.TextBox txt_so;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label lbl_vehiculo;
        private System.Windows.Forms.CheckBox checkBoxAutorizado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox_diagnostico;
        private System.Windows.Forms.TextBox textBoxDispositivo;
        private System.Windows.Forms.TextBox textBoxTipo;
        private System.Windows.Forms.TextBox textBoxTecnico;
    }
}