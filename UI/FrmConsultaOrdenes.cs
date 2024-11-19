using ServicioTecnicoCelular.BD;
using ServicioTecnicoCelular.CS;
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
    public partial class FrmConsultaOrdenes : Form
    {
        private Form childForm;
        public FrmConsultaOrdenes()
        {
            InitializeComponent();            
            // Asignar la fuente de datos
            //dataGridViewOrdenes.DataSource = OrdenReparacionData.ObtenerOrdenesDeReparacion();
            LlenarDataGridView();

            // Crear una nueva columna de botón
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Acción";
            btnColumn.Name = "btnDetalles";
            btnColumn.Text = "Ver Detalles";
            btnColumn.UseColumnTextForButtonValue = true;

            // Agregar la columna de botón al DataGridView
            dataGridViewOrdenes.Columns.Add(btnColumn);

            // Asignar el manejador del evento CellClick
            dataGridViewOrdenes.CellClick += dataGridViewOrdenes_CellClick;
        }

        private void LlenarDataGridView()
        {
            // Obtener la lista de técnicos
            List<OrdenDeReparacion> ordenDeReparacion = OrdenReparacionData.ObtenerOrdenesDeReparacion();

            // Mapear los objetos Tecnico a objetos TecnicoView
            var ordenDeReparacionView = ordenDeReparacion.Select(o => new OrdenDeReparacionView
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
            dataGridViewOrdenes.DataSource = ordenDeReparacionView;

            // Configurar las columnas del DataGridView
            dataGridViewOrdenes.Columns["Orden"].HeaderText = "N° Órden";
            dataGridViewOrdenes.Columns["Dispositivo"].HeaderText = "Dispositivo";
            dataGridViewOrdenes.Columns["Marca"].HeaderText = "Marca";
            dataGridViewOrdenes.Columns["SistemaOperativo"].HeaderText = "Sistema Operativo";
            dataGridViewOrdenes.Columns["Cliente"].HeaderText = "Cliente";
            dataGridViewOrdenes.Columns["Tipo"].Visible = false;
            dataGridViewOrdenes.Columns["Autorizado"].HeaderText = "Autorizada reparación";
            dataGridViewOrdenes.Columns["Tecnico"].HeaderText = "Técnico";
            dataGridViewOrdenes.Columns["Motivo"].Visible = false;
            dataGridViewOrdenes.Columns["Diagnostico"].Visible = false;
            dataGridViewOrdenes.Columns["EstadoOrden"].HeaderText = "Estado órden";
            dataGridViewOrdenes.Columns["Fecha"].HeaderText = "Fecha de registro";

            // Ajustar el tamaño de las columnas (opcional)
            dataGridViewOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridViewOrdenes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el clic sea en la columna de botones y que no sea un encabezado
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewOrdenes.Columns["btnDetalles"].Index)
            {
                // Obtener el objeto Técnico seleccionado
                OrdenDeReparacionView ordenReparacionSeleccionada = (OrdenDeReparacionView)dataGridViewOrdenes.Rows[e.RowIndex].DataBoundItem;

                // Abrir el formulario de detalles y pasarle el objeto Técnico
                if(!ordenReparacionSeleccionada.Autorizado)
                {
                    childForm = new FrmModificaOrdenes(ordenReparacionSeleccionada);
                    childForm.MdiParent = FrmMenuPrincipal.ActiveForm;
                    childForm.Text = "Modifica órden de servicio";
                    childForm.Show();

                    /*FrmModificaOrdenes detalleForm = new FrmModificaOrdenes(ordenReparacionSeleccionada);
                    detalleForm.StartPosition = FormStartPosition.CenterScreen;
                    detalleForm.MaximizeBox = false;
                    //detalleForm.ShowDialog(); 
                    detalleForm.Show(); */
                }
                else
                {
                    if(ordenReparacionSeleccionada.Autorizado && (ordenReparacionSeleccionada.EstadoOrden!=Global.EstadoReparacion.Reparado.ToString() || ordenReparacionSeleccionada.EstadoOrden == Global.EstadoReparacion.EnReparacion.ToString()))
                    {
                        childForm = new FrmOrdenReparacion(ordenReparacionSeleccionada);
                        childForm.MdiParent = FrmMenuPrincipal.ActiveForm;
                        childForm.Text = "Procesamiento de órden de servicio";
                        childForm.Show();
                    }
                    else 
                    {
                        childForm = new FrmConsultaEstadosReparacion(ordenReparacionSeleccionada,"FrmConsultaOrdenes");
                        childForm.MdiParent = FrmMenuPrincipal.ActiveForm;
                        childForm.Text = "Procesamiento de órden de servicio";
                        childForm.Show();
                    }
                }                
                this.Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   
}
