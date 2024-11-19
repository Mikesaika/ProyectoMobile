namespace ServicioTecnicoCelular.UI
{
    partial class FrmRepuesto
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
            this.label1_Pais_importacion = new System.Windows.Forms.Label();
            this.txt_costo = new System.Windows.Forms.TextBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.txt_paisImportacion = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.grp_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_datos
            // 
            this.grp_datos.Controls.Add(this.txt_precio);
            this.grp_datos.Controls.Add(this.label1);
            this.grp_datos.Controls.Add(this.label1_Pais_importacion);
            this.grp_datos.Controls.Add(this.txt_costo);
            this.grp_datos.Controls.Add(this.lbl_precio);
            this.grp_datos.Controls.Add(this.txt_paisImportacion);
            this.grp_datos.Controls.Add(this.txt_nombre);
            this.grp_datos.Controls.Add(this.lbl_nombre);
            this.grp_datos.Location = new System.Drawing.Point(16, 15);
            this.grp_datos.Name = "grp_datos";
            this.grp_datos.Size = new System.Drawing.Size(307, 165);
            this.grp_datos.TabIndex = 14;
            this.grp_datos.TabStop = false;
            this.grp_datos.Text = "Información";
            this.grp_datos.Enter += new System.EventHandler(this.grp_datos_Enter);
            // 
            // label1_Pais_importacion
            // 
            this.label1_Pais_importacion.AutoSize = true;
            this.label1_Pais_importacion.Location = new System.Drawing.Point(15, 61);
            this.label1_Pais_importacion.Name = "label1_Pais_importacion";
            this.label1_Pais_importacion.Size = new System.Drawing.Size(102, 13);
            this.label1_Pais_importacion.TabIndex = 5;
            this.label1_Pais_importacion.Text = "País de Importación";
            this.label1_Pais_importacion.Click += new System.EventHandler(this.label1_Pais_importacion_Click);
            // 
            // txt_costo
            // 
            this.txt_costo.Location = new System.Drawing.Point(148, 87);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(132, 20);
            this.txt_costo.TabIndex = 3;
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(15, 90);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(37, 13);
            this.lbl_precio.TabIndex = 4;
            this.lbl_precio.Text = "Costo:";
            // 
            // txt_paisImportacion
            // 
            this.txt_paisImportacion.Location = new System.Drawing.Point(148, 58);
            this.txt_paisImportacion.Name = "txt_paisImportacion";
            this.txt_paisImportacion.Size = new System.Drawing.Size(132, 20);
            this.txt_paisImportacion.TabIndex = 2;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(148, 32);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(132, 20);
            this.txt_nombre.TabIndex = 1;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(15, 35);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(100, 186);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(108, 33);
            this.btn_guardar.TabIndex = 4;
            this.btn_guardar.Text = "&Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(214, 186);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(108, 33);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Precio:";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(148, 117);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(132, 20);
            this.txt_precio.TabIndex = 7;
            // 
            // FrmRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 230);
            this.Controls.Add(this.grp_datos);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.MaximizeBox = false;
            this.Name = "FrmRepuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo repuesto";
            this.Load += new System.EventHandler(this.FrmRepuesto_Load);
            this.grp_datos.ResumeLayout(false);
            this.grp_datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_datos;
        private System.Windows.Forms.TextBox txt_costo;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.TextBox txt_paisImportacion;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label1_Pais_importacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_precio;
    }
}