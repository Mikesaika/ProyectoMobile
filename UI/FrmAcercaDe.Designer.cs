namespace ServicioTecnicoCelular.UI
{
    partial class FrmAcercaDe
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
            this.groupBoxDevelopers = new System.Windows.Forms.GroupBox();
            this.richTextBoxDevelopers = new System.Windows.Forms.RichTextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBoxDevelopers.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDevelopers
            // 
            this.groupBoxDevelopers.Controls.Add(this.richTextBoxDevelopers);
            this.groupBoxDevelopers.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDevelopers.Name = "groupBoxDevelopers";
            this.groupBoxDevelopers.Size = new System.Drawing.Size(309, 166);
            this.groupBoxDevelopers.TabIndex = 0;
            this.groupBoxDevelopers.TabStop = false;
            this.groupBoxDevelopers.Text = "Developers";
            // 
            // richTextBoxDevelopers
            // 
            this.richTextBoxDevelopers.Location = new System.Drawing.Point(21, 19);
            this.richTextBoxDevelopers.Name = "richTextBoxDevelopers";
            this.richTextBoxDevelopers.ReadOnly = true;
            this.richTextBoxDevelopers.Size = new System.Drawing.Size(266, 130);
            this.richTextBoxDevelopers.TabIndex = 0;
            this.richTextBoxDevelopers.Text = "- ESPINALES LINO JENIFFER ELIZABETH\n\n- ROBLES ALVARADO EMILY DAYAN\n\n- VELASQUEZ A" +
    "NCHUNDIA LESLY SAMAY\n\n- VILLAO PAREDES CARLOS AARON ";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(111, 184);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(108, 33);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "&Aceptar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // FrmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 222);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.groupBoxDevelopers);
            this.MaximizeBox = false;
            this.Name = "FrmAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca del sistema";
            this.groupBoxDevelopers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDevelopers;
        private System.Windows.Forms.RichTextBox richTextBoxDevelopers;
        private System.Windows.Forms.Button btn_cancelar;
    }
}