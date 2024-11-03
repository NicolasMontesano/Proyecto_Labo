using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app
{
    public partial class frmIngresos : Form
    {
        private List<Ingreso> listaIngreso;
        private int idEmpleado = 0;
        public frmIngresos()
        {
            InitializeComponent();
        }
        public frmIngresos(int idEmpleado)
        {
            InitializeComponent();
            this.idEmpleado = idEmpleado;
        }

        private void frmIngresos_Load(object sender, EventArgs e)
        {
            try
            {
                cargarDatos();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void cargarDatos()
        {
            try
            {
                cargarCbosHora();
                cargarCbosMinutos();
                cargarGrilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un errror al cargar la grilla");
            }
        }
        public void cargarGrilla()
        {
            string filtro = "";
            if(txtFiltro != null && txtFiltro.Text.Trim() != "") filtro = txtFiltro.Text.Trim();
            //int hDesde = Convert.ToInt32(cboHoraDesde.SelectedItem.ToString());
            //int hHasta = Convert.ToInt32(cboHoraHasta.SelectedItem.ToString());
            //int mDesde = Convert.ToInt32(cboMinutosDesde.SelectedItem.ToString());
            //int mHasta = Convert.ToInt32(cboMinutosHasta.SelectedItem.ToString());

            int hDesde = 0;
            int hHasta = 23;
            int mDesde = 0;
            int mHasta = 60;

            if(cboHoraDesde.SelectedItem != null) hDesde = Convert.ToInt32(cboHoraDesde.SelectedItem.ToString());
            if (cboHoraHasta.SelectedItem != null) hHasta = Convert.ToInt32(cboHoraHasta.SelectedItem.ToString());
            if (cboMinutosDesde.SelectedItem!= null) mDesde = Convert.ToInt32(cboMinutosDesde.SelectedItem.ToString());
            if (cboMinutosHasta.SelectedItem!= null) mHasta = Convert.ToInt32(cboMinutosHasta.SelectedItem.ToString());

            try
            {
                IngresoNegocio negocio = new IngresoNegocio();
                
                listaIngreso = negocio.ListarIngreso(dtpFiltro.Value,filtro,hDesde,hHasta,mDesde,mHasta);
                dgvIngresos.DataSource = listaIngreso;
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar la grilla");
            }

        }
        public void ocultarColumnas()
        {
            dgvIngresos.Columns["IdAsistencia"].Visible = false;
            dgvIngresos.Columns["IdAlumno"].Visible = false;
            dgvIngresos.Columns["IdRecepcionista"].Visible = false;
        }
        public void cargarCbosHora()
        {
            for (int i = 0; i <= 23; i++)
            {
                cboHoraDesde.Items.Add(i.ToString());
            }
            for (int i = 23; i <= 0; i--)
            {
                cboHoraHasta.Items.Add(i.ToString());
            }
        }
        public void cargarCbosMinutos()
        {
            for (int i = 0; i <= 59; i++)
            {
                cboMinutosDesde.Items.Add(i.ToString());
            }
            for (int i = 59; i >= 0; i--)
            {
                cboMinutosHasta.Items.Add(i.ToString());
            }
        }

        private void btnNuevoIngreso_Click(object sender, EventArgs e)
        {
            frmAlta_Ingreso frmAltaIngr = new frmAlta_Ingreso(idEmpleado);
            frmAltaIngr.ShowDialog();
        }
    }
}
