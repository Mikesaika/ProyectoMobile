using ServicioTecnicoCelular.BD;
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
    public partial class FrmLogin : Form
    {        
        public FrmLogin()
        {            
            InitializeComponent();     
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text != "" && textBoxClave.Text != "")
            {
                DialogResult = AccesoData.ObtenerAcceso(textBoxUsuario.Text, textBoxClave.Text)
                ? DialogResult.Yes
                : DialogResult.No;
                Close();                
            }            
        }
    }
}
