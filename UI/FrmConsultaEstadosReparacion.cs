using ServicioTecnicoCelular.CS;
using ServicioTecnicoCelular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicioTecnicoCelular.BD;

namespace ServicioTecnicoCelular.UI
{
    public partial class FrmConsultaEstadosReparacion : Form
    {
        private DataGridView dataGridViewOrders;
        private DataGridView dataGridViewDetails;
        private TextBox txtFilter;
        private Button btnFilter;
        private Button btn_cancelar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private String formularioInvoca;
        private List<OrdenDeReparacion> listaOrdenesTrabajo;
        private Form childForm;
        private int Orden;

        public FrmConsultaEstadosReparacion(OrdenDeReparacionView ordenDeReparacionView,String formularioInvoca)
        {
            if(ordenDeReparacionView!=null)
             this.Orden = ordenDeReparacionView.Orden;

            this.formularioInvoca = formularioInvoca;
            InitializeComponent();
            // Cargar datos de ejemplo
            if(formularioInvoca=="FrmConsultaOrdenes")
            {
                this.label1.Visible = false;
                this.txtFilter.Visible = false;
                this.btnFilter.Visible = false;
            }
            else
            {
                this.label1.Visible = true;
                this.txtFilter.Visible = true;
                this.btnFilter.Visible = true;
            }

            
            CargarDatos();
            // Mostrar datos en el DataGridView de órdenes
            MostrarOrdenes(listaOrdenesTrabajo);
        }

        private void InitializeComponent()
        {
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewOrders.MultiSelect = false;
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(1204, 200);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.SelectionChanged += new System.EventHandler(this.dataGridViewOrders_SelectionChanged);
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.Location = new System.Drawing.Point(4, 16);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.Size = new System.Drawing.Size(1205, 200);
            this.dataGridViewDetails.TabIndex = 1;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(99, 14);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(200, 20);
            this.txtFilter.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(309, 14);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filtrar";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(1109, 528);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(108, 33);
            this.btn_cancelar.TabIndex = 10;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewOrders);
            this.groupBox1.Location = new System.Drawing.Point(7, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1216, 237);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Órdenes de Reparación";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewDetails);
            this.groupBox2.Location = new System.Drawing.Point(8, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1215, 230);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de órdenes de Reparación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código/Cliente:";
            // 
            // FrmConsultaEstadosReparacion
            // 
            this.ClientSize = new System.Drawing.Size(1235, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmConsultaEstadosReparacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Estados de Reparación Celular";
            this.Load += new System.EventHandler(this.FrmConsultaOrdenesTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CargarDatos()
        {
            listaOrdenesTrabajo = new List<OrdenDeReparacion>();
            listaOrdenesTrabajo = OrdenReparacionData.ObtenerOrdenesDeReparacion();            
        }

        private void MostrarOrdenes(List<OrdenDeReparacion> ordenes)
        {            
            // Mapear los objetos Tecnico a objetos TecnicoView
            var ordenDeReparacionView = ordenes.Select(o => new OrdenDeReparacionView
            {
                Orden = o.Codigo,
                Dispositivo = o.celular.Modelo,
                Marca = o.celular.Marca,
                SistemaOperativo = o.celular.SistemaOperativo,
                Cliente = o.celular.Propietario.NombreCompleto,
                Tipo = o.celular.TipoCelular,
                Autorizado = o.autorizado,
                Tecnico = o.tecnico.NombreCompleto,
                Motivo = o.motivo,
                Diagnostico = o.diagnostico,
                EstadoOrden = o.estadoOrden,
                Fecha = o.Fecha,
            }).ToList();

            // Asignar la lista de objetos TecnicoView como la fuente de datos del DataGridView
            dataGridViewOrders.DataSource = ordenDeReparacionView;

            List<OrdenDeReparacionView> ordenesFiltradas;

            if (formularioInvoca == "FrmConsultaOrdenes")
            {
                
                ordenesFiltradas = ordenDeReparacionView.Where(o => o.EstadoOrden == "Reparado" && o.Orden == this.Orden).ToList();
                dataGridViewOrders.DataSource = ordenesFiltradas;
            }
            else
            {            
                ordenesFiltradas = ordenDeReparacionView.Where(o => o.EstadoOrden == "Reparado").ToList();
                dataGridViewOrders.DataSource = ordenesFiltradas;
            }

            // Configurar las columnas del DataGridView
            dataGridViewOrders.Columns["Orden"].HeaderText = "N° Órden";
            dataGridViewOrders.Columns["Dispositivo"].HeaderText = "Dispositivo";
            dataGridViewOrders.Columns["Marca"].HeaderText = "Marca";
            dataGridViewOrders.Columns["SistemaOperativo"].HeaderText = "Sistema Operativo";
            dataGridViewOrders.Columns["Cliente"].HeaderText = "Cliente";
            dataGridViewOrders.Columns["Tipo"].Visible = false;
            dataGridViewOrders.Columns["Autorizado"].HeaderText = "Autorizada reparación";
            dataGridViewOrders.Columns["Tecnico"].HeaderText = "Técnico";
            dataGridViewOrders.Columns["Motivo"].Visible = false;
            dataGridViewOrders.Columns["Diagnostico"].Visible = false;
            dataGridViewOrders.Columns["EstadoOrden"].HeaderText = "Estado órden";
            dataGridViewOrders.Columns["Fecha"].HeaderText = "Fecha de registro";
           
            // Ajustar el tamaño de las columnas (opcional)
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Asignar la lista de órdenes al DataGridView
            /*var datosOrdenes = ordenes.Select(o => new
            {
                Orden = o.Codigo,
                Propietario = o.celular.Propietario.NombreCompleto,
                ModeloDispositvo = o.celular.Modelo,
                MarcaDispositivo = o.celular.Marca,
                Sistema = o.celular.SistemaOperativo,                                
                FechaEmision = o.Fecha,
                Tipo = o.TipoServicio,
                Motivo = o.motivo,
                //o.tecnico.NombreCompleto,
                Sub = o.Subtotal,
                Impuesto = o.Iva,
                TotalNeto = o.Total
            }).ToList();

            if(formularioInvoca == "FrmConsultaOrdenes")
            {
                List<OrdenDeReparacion> ordenesFiltradas;
                ordenesFiltradas = listaOrdenesTrabajo.Where(o => o.estadoOrden == "Reparado" && o.Codigo == this.Orden).ToList();
                dataGridViewOrders.DataSource = ordenesFiltradas;
            }
            else
            {
                List<OrdenDeReparacion> ordenesFiltradas;
                ordenesFiltradas = listaOrdenesTrabajo.Where(o => o.estadoOrden == "Reparado").ToList();
                dataGridViewOrders.DataSource = ordenesFiltradas;
            }

            
            // Ajustar el tamaño de las columnas (opcional)
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //  dataGridViewOrders.DataSource = datosOrdenes;
            */
        }

        private void MostrarDetalles(List<OrdenReparacionDetalle> detalles)
        {
            // Asignar la lista de detalles al DataGridView
            var datosDetalles = detalles.Select(d => new
            {
                d.codigo,
                d.Item,
                d.Cantidad,
                d.Precio,
                Total = d.Cantidad * d.Precio
            }).ToList();

            dataGridViewDetails.DataSource = datosDetalles;
            dataGridViewDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Obtener el filtro del TextBox
            string filtro = txtFilter.Text.ToLower();

            // Verificar si el filtro es un número entero válido
            int idFiltro;
            bool esNumero = int.TryParse(filtro, out idFiltro);

            List<OrdenDeReparacion> ordenesFiltradas;

            if (esNumero)
            {
                // Filtrar por ID
                ordenesFiltradas = listaOrdenesTrabajo.Where(o => o.Codigo == idFiltro).ToList();
            }
            else
            {
                // Filtrar por 
                ordenesFiltradas = listaOrdenesTrabajo.Where(o =>
                    o.celular.Propietario.NombreCompleto.ToLower().Contains(filtro)
                ).ToList();
            }

            // Mostrar los datos filtrados en el DataGridView de órdenes
            MostrarOrdenes(ordenesFiltradas);
        }

        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                // Obtener el Id de la orden seleccionada
                int ordenId = (int)dataGridViewOrders.SelectedRows[0].Cells["Orden"].Value;

                // Obtener los detalles de la orden seleccionada
                var ordenSeleccionada = listaOrdenesTrabajo.FirstOrDefault(o => o.Codigo == ordenId);
                if (ordenSeleccionada != null)
                {
                    // Mostrar los detalles en el DataGridView de detalles
                    MostrarDetalles(ordenSeleccionada.detalles);
                }
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {            
            this.Close();
            if(formularioInvoca=="FrmConsultaOrdenes")
            {
                if (childForm == null || childForm.IsDisposed)
                {
                    childForm = new FrmConsultaOrdenes();
                    childForm.MdiParent = FrmMenuPrincipal.ActiveForm;
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
        }

        private void FrmConsultaOrdenesTrabajo_Load(object sender, EventArgs e)
        {

        }
    }
}
