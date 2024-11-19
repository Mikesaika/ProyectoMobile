namespace ServicioTecnicoCelular.UI
{
    partial class FrmTecnico
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
            this.grp_datos = new System.Windows.Forms.GroupBox();
            this.lbl_aniosExperiencia = new System.Windows.Forms.Label();
            this.txt_aniosExperiencia = new System.Windows.Forms.TextBox();
            this.txt_especialidad = new System.Windows.Forms.TextBox();
            this.lbl_especialidad = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.lbl_apellidos = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.lbl_nombres = new System.Windows.Forms.Label();
            this.txt_numIdentificacion = new System.Windows.Forms.TextBox();
            this.lbl_numIdentificacion = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.grp_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_datos
            // 
            this.grp_datos.Controls.Add(this.lbl_aniosExperiencia);
            this.grp_datos.Controls.Add(this.txt_aniosExperiencia);
            this.grp_datos.Controls.Add(this.txt_especialidad);
            this.grp_datos.Controls.Add(this.lbl_especialidad);
            this.grp_datos.Controls.Add(this.txt_email);
            this.grp_datos.Controls.Add(this.lbl_email);
            this.grp_datos.Controls.Add(this.txt_telefono);
            this.grp_datos.Controls.Add(this.lbl_telefono);
            this.grp_datos.Controls.Add(this.txt_apellidos);
            this.grp_datos.Controls.Add(this.lbl_apellidos);
            this.grp_datos.Controls.Add(this.txt_nombres);
            this.grp_datos.Controls.Add(this.lbl_nombres);
            this.grp_datos.Controls.Add(this.txt_numIdentificacion);
            this.grp_datos.Controls.Add(this.lbl_numIdentificacion);
            this.grp_datos.Location = new System.Drawing.Point(16, 15);
            this.grp_datos.Name = "grp_datos";
            this.grp_datos.Size = new System.Drawing.Size(307, 223);
            this.grp_datos.TabIndex = 14;
            this.grp_datos.TabStop = false;
            this.grp_datos.Text = "Información";
            this.grp_datos.Enter += new System.EventHandler(this.grp_datos_Enter);
            // 
            // lbl_aniosExperiencia
            // 
            this.lbl_aniosExperiencia.AutoSize = true;
            this.lbl_aniosExperiencia.Location = new System.Drawing.Point(15, 195);
            this.lbl_aniosExperiencia.Name = "lbl_aniosExperiencia";
            this.lbl_aniosExperiencia.Size = new System.Drawing.Size(106, 13);
            this.lbl_aniosExperiencia.TabIndex = 9;
            this.lbl_aniosExperiencia.Text = "Años de experiencia:";
            // 
            // txt_aniosExperiencia
            // 
            this.txt_aniosExperiencia.Location = new System.Drawing.Point(148, 188);
            this.txt_aniosExperiencia.Name = "txt_aniosExperiencia";
            this.txt_aniosExperiencia.Size = new System.Drawing.Size(132, 20);
            this.txt_aniosExperiencia.TabIndex = 7;
            // 
            // txt_especialidad
            // 
            this.txt_especialidad.Location = new System.Drawing.Point(148, 162);
            this.txt_especialidad.Name = "txt_especialidad";
            this.txt_especialidad.Size = new System.Drawing.Size(132, 20);
            this.txt_especialidad.TabIndex = 6;
            // 
            // lbl_especialidad
            // 
            this.lbl_especialidad.AutoSize = true;
            this.lbl_especialidad.Location = new System.Drawing.Point(15, 165);
            this.lbl_especialidad.Name = "lbl_especialidad";
            this.lbl_especialidad.Size = new System.Drawing.Size(70, 13);
            this.lbl_especialidad.TabIndex = 2;
            this.lbl_especialidad.Text = "Especialidad:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(148, 136);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(132, 20);
            this.txt_email.TabIndex = 5;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(15, 139);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email:";
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(148, 110);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(132, 20);
            this.txt_telefono.TabIndex = 4;
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(15, 113);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(52, 13);
            this.lbl_telefono.TabIndex = 6;
            this.lbl_telefono.Text = "Teléfono:";
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(148, 84);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(132, 20);
            this.txt_apellidos.TabIndex = 3;
            // 
            // lbl_apellidos
            // 
            this.lbl_apellidos.AutoSize = true;
            this.lbl_apellidos.Location = new System.Drawing.Point(15, 87);
            this.lbl_apellidos.Name = "lbl_apellidos";
            this.lbl_apellidos.Size = new System.Drawing.Size(52, 13);
            this.lbl_apellidos.TabIndex = 4;
            this.lbl_apellidos.Text = "Apellidos:";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(148, 58);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(132, 20);
            this.txt_nombres.TabIndex = 2;
            // 
            // lbl_nombres
            // 
            this.lbl_nombres.AutoSize = true;
            this.lbl_nombres.Location = new System.Drawing.Point(15, 61);
            this.lbl_nombres.Name = "lbl_nombres";
            this.lbl_nombres.Size = new System.Drawing.Size(52, 13);
            this.lbl_nombres.TabIndex = 2;
            this.lbl_nombres.Text = "Nombres:";
            // 
            // txt_numIdentificacion
            // 
            this.txt_numIdentificacion.Location = new System.Drawing.Point(148, 32);
            this.txt_numIdentificacion.Name = "txt_numIdentificacion";
            this.txt_numIdentificacion.Size = new System.Drawing.Size(132, 20);
            this.txt_numIdentificacion.TabIndex = 1;
            // 
            // lbl_numIdentificacion
            // 
            this.lbl_numIdentificacion.AutoSize = true;
            this.lbl_numIdentificacion.Location = new System.Drawing.Point(15, 35);
            this.lbl_numIdentificacion.Name = "lbl_numIdentificacion";
            this.lbl_numIdentificacion.Size = new System.Drawing.Size(127, 13);
            this.lbl_numIdentificacion.TabIndex = 0;
            this.lbl_numIdentificacion.Text = "Número de identificación:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(101, 244);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(108, 33);
            this.btn_guardar.TabIndex = 15;
            this.btn_guardar.Text = "&Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(215, 244);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(108, 33);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FrmTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 292);
            this.Controls.Add(this.grp_datos);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.MaximizeBox = false;
            this.Name = "FrmTecnico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo técnico";
            this.Load += new System.EventHandler(this.FrmMecanico_Load);
            this.grp_datos.ResumeLayout(false);
            this.grp_datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_datos;
        private System.Windows.Forms.Label lbl_aniosExperiencia;
        private System.Windows.Forms.TextBox txt_aniosExperiencia;
        private System.Windows.Forms.TextBox txt_especialidad;
        private System.Windows.Forms.Label lbl_especialidad;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label lbl_apellidos;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.Label lbl_nombres;
        private System.Windows.Forms.TextBox txt_numIdentificacion;
        private System.Windows.Forms.Label lbl_numIdentificacion;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}