//USUARIO Y CONTRASEÑA PARA ENTRAR AL SISTEMA TALLER TÉCNICO CELULAR EN VISUAL ESTUDIO: USUARIO: admin CONTRASEÑA: admin
using ServicioTecnicoCelular.UI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ServicioTecnicoCelular.UI
{
    public partial class FrmMenuPrincipal : Form
    {
        //private int childFormNumber = 0;
        private Form childForm;
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            /*if (backgroundImage != null)
            {
                e.Graphics.DrawImage(backgroundImage, new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height));
            }*/
        }

        private void nuevoClienteForm(object sender, EventArgs e)
        {

            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new FrmCliente();
                childForm.MdiParent = this;
                childForm.Text = "Nuevo cliente";
                childForm.Show();
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }

        }

        private void nuevoMecanicoForm(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new FrmTecnico();
                childForm.MdiParent = this;
                childForm.Text = "Nuevo técnico";
                childForm.Show();
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        private void itemsMenuItem_Click(object sender, EventArgs e)
        {
            /*SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }*/
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MENU_PRINCIPAL_Load(object sender, EventArgs e)
        {

        }

        private void nuevoRepuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new FrmRepuesto();
                childForm.MdiParent = this;
                childForm.Text = "Nuevo repuesto";
                childForm.Show();
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        private void nuevoVehiculoMenuItem_Click(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new FrmCelular();
                childForm.MdiParent = this;
                childForm.Text = "Nuevo celular";
                childForm.Show();
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        private void nuevaOrdenTrabajoMenuItem_Click(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new FrmConsultaOrdenes();
                childForm.MdiParent = this;
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

        private void nuevoTipoMantenimientoMenuItem_Click(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                //childForm = new FrmTipoMantenimiento();
                childForm.MdiParent = this;
                childForm.Text = "Nueva tipo de mantenimiento";
                childForm.Show();
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        private void nuevoVehiculoToolStripButton_Click(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new FrmCelular();
                childForm.MdiParent = this;
                childForm.Text = "Nuevo Celular";
                childForm.Show();
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        private void nuevoRepuestoToolStripButton_Click(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new FrmRepuesto();
                childForm.MdiParent = this;
                childForm.Text = "Nuevo repuesto";
                childForm.Show();
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        private void nuevoServicioToolStripButton_Click(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new FrmServicio();
                childForm.MdiParent = this;
                childForm.Text = "Nuevo servicio";
                childForm.Show();
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        private void nuevoTipoMantenimientoToolStripButton_Click(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                //childForm = new FrmTipoMantenimiento();
                childForm.MdiParent = this;
                childForm.Text = "Nueva tipo de mantenimiento";
                childForm.Show();
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        private void nuevaOrdenTrabajotoolStripButton_Click(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new FrmConsultaOrdenes();
                childForm.MdiParent = this;
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

        private void consultaOrdenesTrabajotoolStripButton_Click(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new FrmConsultaEstadosReparacion(null, "FrmMenuPrincipal");
                childForm.MdiParent = this;
                childForm.Text = "Consulta de órdenes de Reparación";
                childForm.Show();
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        private void nuevoServicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new FrmServicio();
                childForm.MdiParent = this;
                childForm.Text = "Nuevo servicio";
                childForm.Show();
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        private void ordenesDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new FrmConsultaEstadosReparacion(null,"FrmMenuPrincipal");
                childForm.MdiParent = this;
                childForm.Text = "Consulta de órdenes de Reparación";
                childForm.Show();
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new FrmAcercaDe();
                childForm.MdiParent = this;
                childForm.Text = "Acerca del sistema";
                childForm.Show();
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new FrmAcercaDe();
                childForm.MdiParent = this;
                childForm.Text = "Acerca del sistema";
                childForm.Show();
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void editMenu_Click(object sender, EventArgs e)
        {

        }

        private void nuevoIngresoMenuItem_Click(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new FrmIngresoOrdenes();
                childForm.MdiParent = this;
                childForm.Text = "Nuevo ingreso";
                childForm.Show();
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {                
                var login = new FrmLogin();
                var usuarioValido = login.ShowDialog() == DialogResult.Yes;

                if (usuarioValido)
                {
                    conectarToolStripMenuItem.Enabled = false;
                    nuevoClienteMenuItem.Enabled = true;
                    nuevoMecanicoMenuItem.Enabled = true;
                    nuevoVehiculoMenuItem.Enabled = true;
                    itemsMenuItem.Enabled = true;
                    consultasToolStripMenuItem.Enabled = true;

                    nuevoIngresoMenuItem.Enabled=true;
                    nuevaOrdenTrabajoMenuItem.Enabled=true;
                    conectarToolStripMenuItem.Enabled = true;

                    nuevoClienteToolStripButton.Enabled = true;
                    nuevoMecanicoToolStripButton.Enabled=true;
                    nuevoVehiculoToolStripButton.Enabled=true;
                    nuevoRepuestoToolStripButton.Enabled=true;
                    nuevoServicioToolStripButton.Enabled=true;
                    nuevaOrdenTrabajotoolStripButton.Enabled=true;
                    consultaOrdenesTrabajotoolStripButton.Enabled= true;
                    toolStripButtonIngresoOrden.Enabled = true;

                    conectarToolStripMenuItem.Enabled = false;
                }                
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        private void toolStripButtonIngresoOrden_Click(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new FrmIngresoOrdenes();
                childForm.MdiParent = this;
                childForm.Text = "Nuevo ingreso";
                childForm.Show();
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }
    }
}
