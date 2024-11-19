namespace ServicioTecnicoCelular.UI
{
    partial class FrmCelular
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
            this.lbl_anioFabricacion = new System.Windows.Forms.Label();
            this.txt_anioFabricacion = new System.Windows.Forms.TextBox();
            this.grp_datos = new System.Windows.Forms.GroupBox();
            this.comboBox_propietario = new System.Windows.Forms.ComboBox();
            this.lbl_propietario = new System.Windows.Forms.Label();
            this.txt_pantalla = new System.Windows.Forms.TextBox();
            this.lbl_motor = new System.Windows.Forms.Label();
            this.txt_almacenamiento = new System.Windows.Forms.TextBox();
            this.lbl_placa = new System.Windows.Forms.Label();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.txt_sistema_operativo = new System.Windows.Forms.TextBox();
            this.lbl_fabricante = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.lbl_chasis = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTipoDispositivo = new System.Windows.Forms.ComboBox();
            this.grp_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_anioFabricacion
            // 
            this.lbl_anioFabricacion.AutoSize = true;
            this.lbl_anioFabricacion.Location = new System.Drawing.Point(15, 195);
            this.lbl_anioFabricacion.Name = "lbl_anioFabricacion";
            this.lbl_anioFabricacion.Size = new System.Drawing.Size(99, 13);
            this.lbl_anioFabricacion.TabIndex = 9;
            this.lbl_anioFabricacion.Text = "Año de fabricación:";
            // 
            // txt_anioFabricacion
            // 
            this.txt_anioFabricacion.Location = new System.Drawing.Point(148, 188);
            this.txt_anioFabricacion.Name = "txt_anioFabricacion";
            this.txt_anioFabricacion.Size = new System.Drawing.Size(132, 20);
            this.txt_anioFabricacion.TabIndex = 7;
            // 
            // grp_datos
            // 
            this.grp_datos.Controls.Add(this.comboBoxTipoDispositivo);
            this.grp_datos.Controls.Add(this.comboBox_propietario);
            this.grp_datos.Controls.Add(this.lbl_propietario);
            this.grp_datos.Controls.Add(this.lbl_anioFabricacion);
            this.grp_datos.Controls.Add(this.txt_anioFabricacion);
            this.grp_datos.Controls.Add(this.txt_pantalla);
            this.grp_datos.Controls.Add(this.lbl_motor);
            this.grp_datos.Controls.Add(this.txt_almacenamiento);
            this.grp_datos.Controls.Add(this.lbl_placa);
            this.grp_datos.Controls.Add(this.txt_color);
            this.grp_datos.Controls.Add(this.lbl_color);
            this.grp_datos.Controls.Add(this.txt_modelo);
            this.grp_datos.Controls.Add(this.lbl_modelo);
            this.grp_datos.Controls.Add(this.txt_sistema_operativo);
            this.grp_datos.Controls.Add(this.lbl_fabricante);
            this.grp_datos.Controls.Add(this.txt_marca);
            this.grp_datos.Controls.Add(this.lbl_chasis);
            this.grp_datos.Location = new System.Drawing.Point(12, 12);
            this.grp_datos.Name = "grp_datos";
            this.grp_datos.Size = new System.Drawing.Size(307, 281);
            this.grp_datos.TabIndex = 11;
            this.grp_datos.TabStop = false;
            this.grp_datos.Text = "Información";
            // 
            // comboBox_propietario
            // 
            this.comboBox_propietario.FormattingEnabled = true;
            this.comboBox_propietario.Location = new System.Drawing.Point(148, 243);
            this.comboBox_propietario.Name = "comboBox_propietario";
            this.comboBox_propietario.Size = new System.Drawing.Size(132, 21);
            this.comboBox_propietario.TabIndex = 9;
            // 
            // lbl_propietario
            // 
            this.lbl_propietario.AutoSize = true;
            this.lbl_propietario.Location = new System.Drawing.Point(17, 248);
            this.lbl_propietario.Name = "lbl_propietario";
            this.lbl_propietario.Size = new System.Drawing.Size(60, 13);
            this.lbl_propietario.TabIndex = 10;
            this.lbl_propietario.Text = "Propietario:";
            // 
            // txt_pantalla
            // 
            this.txt_pantalla.Location = new System.Drawing.Point(148, 162);
            this.txt_pantalla.Name = "txt_pantalla";
            this.txt_pantalla.Size = new System.Drawing.Size(132, 20);
            this.txt_pantalla.TabIndex = 6;
            // 
            // lbl_motor
            // 
            this.lbl_motor.AutoSize = true;
            this.lbl_motor.Location = new System.Drawing.Point(15, 165);
            this.lbl_motor.Name = "lbl_motor";
            this.lbl_motor.Size = new System.Drawing.Size(48, 13);
            this.lbl_motor.TabIndex = 2;
            this.lbl_motor.Text = "Pantalla:";
            // 
            // txt_almacenamiento
            // 
            this.txt_almacenamiento.Location = new System.Drawing.Point(148, 136);
            this.txt_almacenamiento.Name = "txt_almacenamiento";
            this.txt_almacenamiento.Size = new System.Drawing.Size(132, 20);
            this.txt_almacenamiento.TabIndex = 5;
            // 
            // lbl_placa
            // 
            this.lbl_placa.AutoSize = true;
            this.lbl_placa.Location = new System.Drawing.Point(15, 139);
            this.lbl_placa.Name = "lbl_placa";
            this.lbl_placa.Size = new System.Drawing.Size(88, 13);
            this.lbl_placa.TabIndex = 2;
            this.lbl_placa.Text = "Almacenamiento:";
            // 
            // txt_color
            // 
            this.txt_color.Location = new System.Drawing.Point(148, 110);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(132, 20);
            this.txt_color.TabIndex = 4;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(15, 113);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(34, 13);
            this.lbl_color.TabIndex = 6;
            this.lbl_color.Text = "Color:";
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(148, 84);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(132, 20);
            this.txt_modelo.TabIndex = 3;
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(15, 87);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(45, 13);
            this.lbl_modelo.TabIndex = 4;
            this.lbl_modelo.Text = "Modelo:";
            // 
            // txt_sistema_operativo
            // 
            this.txt_sistema_operativo.Location = new System.Drawing.Point(148, 58);
            this.txt_sistema_operativo.Name = "txt_sistema_operativo";
            this.txt_sistema_operativo.Size = new System.Drawing.Size(132, 20);
            this.txt_sistema_operativo.TabIndex = 2;
            // 
            // lbl_fabricante
            // 
            this.lbl_fabricante.AutoSize = true;
            this.lbl_fabricante.Location = new System.Drawing.Point(15, 61);
            this.lbl_fabricante.Name = "lbl_fabricante";
            this.lbl_fabricante.Size = new System.Drawing.Size(96, 13);
            this.lbl_fabricante.TabIndex = 2;
            this.lbl_fabricante.Text = "Sistema Operativo:";
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(148, 32);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(132, 20);
            this.txt_marca.TabIndex = 1;
            // 
            // lbl_chasis
            // 
            this.lbl_chasis.AutoSize = true;
            this.lbl_chasis.Location = new System.Drawing.Point(17, 35);
            this.lbl_chasis.Name = "lbl_chasis";
            this.lbl_chasis.Size = new System.Drawing.Size(40, 13);
            this.lbl_chasis.TabIndex = 0;
            this.lbl_chasis.Text = "Marca:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(99, 299);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(108, 33);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "&Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(213, 299);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(108, 33);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo dispositivo:";
            // 
            // comboBoxTipoDispositivo
            // 
            this.comboBoxTipoDispositivo.FormattingEnabled = true;
            this.comboBoxTipoDispositivo.Items.AddRange(new object[] {
            "Celular",
            "Tablet"});
            this.comboBoxTipoDispositivo.Location = new System.Drawing.Point(148, 215);
            this.comboBoxTipoDispositivo.Name = "comboBoxTipoDispositivo";
            this.comboBoxTipoDispositivo.Size = new System.Drawing.Size(132, 21);
            this.comboBoxTipoDispositivo.TabIndex = 8;
            // 
            // FrmCelular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 345);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grp_datos);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.MaximizeBox = false;
            this.Name = "FrmCelular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo celular";
            this.Load += new System.EventHandler(this.FrmVehiculo_Load);
            this.grp_datos.ResumeLayout(false);
            this.grp_datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_anioFabricacion;
        private System.Windows.Forms.TextBox txt_anioFabricacion;
        private System.Windows.Forms.GroupBox grp_datos;
        private System.Windows.Forms.TextBox txt_pantalla;
        private System.Windows.Forms.Label lbl_motor;
        private System.Windows.Forms.TextBox txt_almacenamiento;
        private System.Windows.Forms.Label lbl_placa;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.TextBox txt_sistema_operativo;
        private System.Windows.Forms.Label lbl_fabricante;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Label lbl_chasis;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ComboBox comboBox_propietario;
        private System.Windows.Forms.Label lbl_propietario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTipoDispositivo;
    }
}