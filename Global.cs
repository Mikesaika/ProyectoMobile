using System.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using ServicioTecnicoCelular.BD;


namespace ServicioTecnicoCelular
{
    public static class Global
    {
        //private static string connectionString = ConfigurationManager.ConnectionStrings["SISCelDB"].ConnectionString;        
        public const double IVA = 0.15;
        
        public enum EstadoReparacion
        {
            Recibido,
            Diagnostico,
            EnReparacion,
            Reparado        
        }

        public static void LimpiarControles(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
                else if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
                else if (control is ListBox)
                {
                    ((ListBox)control).ClearSelected();
                }
                else if (control is RichTextBox)
                {
                    ((RichTextBox)control).Text = string.Empty;
                }
                else if (control is DataGridView)
                {
                    ((DataGridView)control).Rows.Clear();
                }
                // Llamada recursiva para limpiar controles dentro de contenedores
                if (control.HasChildren)
                {
                    LimpiarControles(control);
                }
            }
        }
        
        /*public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }*/
    }
}
