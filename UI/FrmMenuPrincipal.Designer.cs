namespace ServicioTecnicoCelular.UI
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoMecanicoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevoVehiculoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoRepuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoServicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoIngresoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevaOrdenTrabajoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.nuevoClienteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevoMecanicoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevoVehiculoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevoRepuestoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevoServicioToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonIngresoOrden = new System.Windows.Forms.ToolStripButton();
            this.nuevaOrdenTrabajotoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.consultaOrdenesTrabajotoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(901, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // fileMenu
            // 
            this.fileMenu.BackColor = System.Drawing.Color.Snow;
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.nuevoClienteMenuItem,
            this.nuevoMecanicoMenuItem,
            this.toolStripSeparator3,
            this.nuevoVehiculoMenuItem,
            this.itemsMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(132, 20);
            this.fileMenu.Text = "&Parámetros generales";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("conectarToolStripMenuItem.Image")));
            this.conectarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(228, 56);
            this.conectarToolStripMenuItem.Text = "Conectar";
            this.conectarToolStripMenuItem.Click += new System.EventHandler(this.conectarToolStripMenuItem_Click);
            // 
            // nuevoClienteMenuItem
            // 
            this.nuevoClienteMenuItem.Enabled = false;
            this.nuevoClienteMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoClienteMenuItem.Image")));
            this.nuevoClienteMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevoClienteMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevoClienteMenuItem.Name = "nuevoClienteMenuItem";
            this.nuevoClienteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.nuevoClienteMenuItem.Size = new System.Drawing.Size(228, 56);
            this.nuevoClienteMenuItem.Text = "Nuevo &cliente";
            this.nuevoClienteMenuItem.Click += new System.EventHandler(this.nuevoClienteForm);
            // 
            // nuevoMecanicoMenuItem
            // 
            this.nuevoMecanicoMenuItem.Enabled = false;
            this.nuevoMecanicoMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoMecanicoMenuItem.Image")));
            this.nuevoMecanicoMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevoMecanicoMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevoMecanicoMenuItem.Name = "nuevoMecanicoMenuItem";
            this.nuevoMecanicoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.nuevoMecanicoMenuItem.Size = new System.Drawing.Size(228, 56);
            this.nuevoMecanicoMenuItem.Text = "&Nuevo &técnico";
            this.nuevoMecanicoMenuItem.Click += new System.EventHandler(this.nuevoMecanicoForm);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(225, 6);
            // 
            // nuevoVehiculoMenuItem
            // 
            this.nuevoVehiculoMenuItem.Enabled = false;
            this.nuevoVehiculoMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoVehiculoMenuItem.Image")));
            this.nuevoVehiculoMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevoVehiculoMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevoVehiculoMenuItem.Name = "nuevoVehiculoMenuItem";
            this.nuevoVehiculoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.nuevoVehiculoMenuItem.Size = new System.Drawing.Size(228, 56);
            this.nuevoVehiculoMenuItem.Text = "Nuevo &celular";
            this.nuevoVehiculoMenuItem.Click += new System.EventHandler(this.nuevoVehiculoMenuItem_Click);
            // 
            // itemsMenuItem
            // 
            this.itemsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoRepuestoToolStripMenuItem,
            this.nuevoServicioToolStripMenuItem});
            this.itemsMenuItem.Enabled = false;
            this.itemsMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("itemsMenuItem.Image")));
            this.itemsMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemsMenuItem.Name = "itemsMenuItem";
            this.itemsMenuItem.Size = new System.Drawing.Size(228, 56);
            this.itemsMenuItem.Text = "Ítems";
            this.itemsMenuItem.Click += new System.EventHandler(this.itemsMenuItem_Click);
            // 
            // nuevoRepuestoToolStripMenuItem
            // 
            this.nuevoRepuestoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoRepuestoToolStripMenuItem.Image")));
            this.nuevoRepuestoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevoRepuestoToolStripMenuItem.Name = "nuevoRepuestoToolStripMenuItem";
            this.nuevoRepuestoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.nuevoRepuestoToolStripMenuItem.Size = new System.Drawing.Size(271, 58);
            this.nuevoRepuestoToolStripMenuItem.Text = "Nuevo &repuesto";
            this.nuevoRepuestoToolStripMenuItem.Click += new System.EventHandler(this.nuevoRepuestoToolStripMenuItem_Click);
            // 
            // nuevoServicioToolStripMenuItem
            // 
            this.nuevoServicioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoServicioToolStripMenuItem.Image")));
            this.nuevoServicioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevoServicioToolStripMenuItem.Name = "nuevoServicioToolStripMenuItem";
            this.nuevoServicioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.nuevoServicioToolStripMenuItem.Size = new System.Drawing.Size(271, 58);
            this.nuevoServicioToolStripMenuItem.Text = "Nuevo &servicio";
            this.nuevoServicioToolStripMenuItem.Click += new System.EventHandler(this.nuevoServicioToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(225, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(228, 56);
            this.exitToolStripMenuItem.Text = "&Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.BackColor = System.Drawing.Color.Snow;
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoIngresoMenuItem,
            this.toolStripSeparator7,
            this.nuevaOrdenTrabajoMenuItem,
            this.toolStripSeparator6,
            this.consultasToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(66, 20);
            this.editMenu.Text = "&Procesos";
            this.editMenu.Click += new System.EventHandler(this.editMenu_Click);
            // 
            // nuevoIngresoMenuItem
            // 
            this.nuevoIngresoMenuItem.Enabled = false;
            this.nuevoIngresoMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoIngresoMenuItem.Image")));
            this.nuevoIngresoMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevoIngresoMenuItem.Name = "nuevoIngresoMenuItem";
            this.nuevoIngresoMenuItem.Size = new System.Drawing.Size(273, 70);
            this.nuevoIngresoMenuItem.Text = "Ingresos órdenes";
            this.nuevoIngresoMenuItem.Click += new System.EventHandler(this.nuevoIngresoMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(270, 6);
            // 
            // nuevaOrdenTrabajoMenuItem
            // 
            this.nuevaOrdenTrabajoMenuItem.Enabled = false;
            this.nuevaOrdenTrabajoMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevaOrdenTrabajoMenuItem.Image")));
            this.nuevaOrdenTrabajoMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevaOrdenTrabajoMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevaOrdenTrabajoMenuItem.Name = "nuevaOrdenTrabajoMenuItem";
            this.nuevaOrdenTrabajoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevaOrdenTrabajoMenuItem.Size = new System.Drawing.Size(273, 70);
            this.nuevaOrdenTrabajoMenuItem.Text = "&Consulta de órdenes";
            this.nuevaOrdenTrabajoMenuItem.Click += new System.EventHandler(this.nuevaOrdenTrabajoMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(270, 6);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesDeTrabajoToolStripMenuItem});
            this.consultasToolStripMenuItem.Enabled = false;
            this.consultasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultasToolStripMenuItem.Image")));
            this.consultasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.consultasToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(273, 70);
            this.consultasToolStripMenuItem.Text = "&Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // ordenesDeTrabajoToolStripMenuItem
            // 
            this.ordenesDeTrabajoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ordenesDeTrabajoToolStripMenuItem.Image")));
            this.ordenesDeTrabajoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ordenesDeTrabajoToolStripMenuItem.Name = "ordenesDeTrabajoToolStripMenuItem";
            this.ordenesDeTrabajoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ordenesDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(267, 70);
            this.ordenesDeTrabajoToolStripMenuItem.Text = "Órdenes facturadas";
            this.ordenesDeTrabajoToolStripMenuItem.Click += new System.EventHandler(this.ordenesDeTrabajoToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(53, 20);
            this.helpMenu.Text = "Ay&uda";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(163, 38);
            this.aboutToolStripMenuItem.Text = "&Acerca de... ...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripButton,
            this.toolStripSeparator1,
            this.nuevoMecanicoToolStripButton,
            this.toolStripSeparator2,
            this.nuevoVehiculoToolStripButton,
            this.toolStripSeparator8,
            this.nuevoRepuestoToolStripButton,
            this.toolStripSeparator9,
            this.nuevoServicioToolStripButton,
            this.toolStripSeparator10,
            this.toolStripButtonIngresoOrden,
            this.nuevaOrdenTrabajotoolStripButton,
            this.toolStripSeparator12,
            this.consultaOrdenesTrabajotoolStripButton,
            this.toolStripSeparator4,
            this.toolStripButton1});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(901, 71);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // nuevoClienteToolStripButton
            // 
            this.nuevoClienteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevoClienteToolStripButton.Enabled = false;
            this.nuevoClienteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nuevoClienteToolStripButton.Image")));
            this.nuevoClienteToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevoClienteToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevoClienteToolStripButton.Name = "nuevoClienteToolStripButton";
            this.nuevoClienteToolStripButton.Size = new System.Drawing.Size(52, 68);
            this.nuevoClienteToolStripButton.Text = "Nuevo cliente";
            this.nuevoClienteToolStripButton.Click += new System.EventHandler(this.nuevoClienteForm);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // nuevoMecanicoToolStripButton
            // 
            this.nuevoMecanicoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevoMecanicoToolStripButton.Enabled = false;
            this.nuevoMecanicoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nuevoMecanicoToolStripButton.Image")));
            this.nuevoMecanicoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevoMecanicoToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevoMecanicoToolStripButton.Name = "nuevoMecanicoToolStripButton";
            this.nuevoMecanicoToolStripButton.Size = new System.Drawing.Size(63, 68);
            this.nuevoMecanicoToolStripButton.Text = "Nuevo técnico";
            this.nuevoMecanicoToolStripButton.Click += new System.EventHandler(this.nuevoMecanicoForm);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 71);
            // 
            // nuevoVehiculoToolStripButton
            // 
            this.nuevoVehiculoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevoVehiculoToolStripButton.Enabled = false;
            this.nuevoVehiculoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nuevoVehiculoToolStripButton.Image")));
            this.nuevoVehiculoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevoVehiculoToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevoVehiculoToolStripButton.Name = "nuevoVehiculoToolStripButton";
            this.nuevoVehiculoToolStripButton.Size = new System.Drawing.Size(68, 68);
            this.nuevoVehiculoToolStripButton.Text = "Nuevo Celular";
            this.nuevoVehiculoToolStripButton.Click += new System.EventHandler(this.nuevoVehiculoToolStripButton_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 71);
            // 
            // nuevoRepuestoToolStripButton
            // 
            this.nuevoRepuestoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevoRepuestoToolStripButton.Enabled = false;
            this.nuevoRepuestoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nuevoRepuestoToolStripButton.Image")));
            this.nuevoRepuestoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevoRepuestoToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevoRepuestoToolStripButton.Name = "nuevoRepuestoToolStripButton";
            this.nuevoRepuestoToolStripButton.Size = new System.Drawing.Size(82, 68);
            this.nuevoRepuestoToolStripButton.Text = "Agregar Repuesto Celular";
            this.nuevoRepuestoToolStripButton.Click += new System.EventHandler(this.nuevoRepuestoToolStripButton_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 71);
            // 
            // nuevoServicioToolStripButton
            // 
            this.nuevoServicioToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevoServicioToolStripButton.Enabled = false;
            this.nuevoServicioToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nuevoServicioToolStripButton.Image")));
            this.nuevoServicioToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevoServicioToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.nuevoServicioToolStripButton.Name = "nuevoServicioToolStripButton";
            this.nuevoServicioToolStripButton.Size = new System.Drawing.Size(92, 68);
            this.nuevoServicioToolStripButton.Text = "Agregar Servicio Celular";
            this.nuevoServicioToolStripButton.Click += new System.EventHandler(this.nuevoServicioToolStripButton_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripButtonIngresoOrden
            // 
            this.toolStripButtonIngresoOrden.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonIngresoOrden.Enabled = false;
            this.toolStripButtonIngresoOrden.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIngresoOrden.Image")));
            this.toolStripButtonIngresoOrden.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonIngresoOrden.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIngresoOrden.Name = "toolStripButtonIngresoOrden";
            this.toolStripButtonIngresoOrden.Size = new System.Drawing.Size(68, 68);
            this.toolStripButtonIngresoOrden.Text = "Ingreso de órden";
            this.toolStripButtonIngresoOrden.Click += new System.EventHandler(this.toolStripButtonIngresoOrden_Click);
            // 
            // nuevaOrdenTrabajotoolStripButton
            // 
            this.nuevaOrdenTrabajotoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevaOrdenTrabajotoolStripButton.Enabled = false;
            this.nuevaOrdenTrabajotoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("nuevaOrdenTrabajotoolStripButton.Image")));
            this.nuevaOrdenTrabajotoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevaOrdenTrabajotoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevaOrdenTrabajotoolStripButton.Name = "nuevaOrdenTrabajotoolStripButton";
            this.nuevaOrdenTrabajotoolStripButton.Size = new System.Drawing.Size(58, 68);
            this.nuevaOrdenTrabajotoolStripButton.Text = "Consultas de órden de reparación";
            this.nuevaOrdenTrabajotoolStripButton.Click += new System.EventHandler(this.nuevaOrdenTrabajotoolStripButton_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 71);
            // 
            // consultaOrdenesTrabajotoolStripButton
            // 
            this.consultaOrdenesTrabajotoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultaOrdenesTrabajotoolStripButton.Enabled = false;
            this.consultaOrdenesTrabajotoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("consultaOrdenesTrabajotoolStripButton.Image")));
            this.consultaOrdenesTrabajotoolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.consultaOrdenesTrabajotoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.consultaOrdenesTrabajotoolStripButton.Name = "consultaOrdenesTrabajotoolStripButton";
            this.consultaOrdenesTrabajotoolStripButton.Size = new System.Drawing.Size(68, 68);
            this.consultaOrdenesTrabajotoolStripButton.Text = "Órdenes facturadas";
            this.consultaOrdenesTrabajotoolStripButton.Click += new System.EventHandler(this.consultaOrdenesTrabajotoolStripButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 71);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 68);
            this.toolStripButton1.Text = "Acerca de";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip.BackgroundImage")));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 473);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(901, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 495);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMenuPrincipal";
            this.Text = "Sistema Reparación de Equipos Celulares";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MENU_PRINCIPAL_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoMecanicoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoVehiculoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem nuevaOrdenTrabajoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripButton nuevoClienteToolStripButton;
        private System.Windows.Forms.ToolStripButton nuevoMecanicoToolStripButton;
        private System.Windows.Forms.ToolStripButton nuevoVehiculoToolStripButton;
        private System.Windows.Forms.ToolStripButton nuevoRepuestoToolStripButton;
        private System.Windows.Forms.ToolStripButton nuevoServicioToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem nuevoRepuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoServicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton nuevaOrdenTrabajotoolStripButton;
        private System.Windows.Forms.ToolStripButton consultaOrdenesTrabajotoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem nuevoIngresoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonIngresoOrden;
    }
}



