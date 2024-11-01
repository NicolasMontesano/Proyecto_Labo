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
using dominio;

namespace winform_app
{
    public partial class frmClientes : Form
    {
        private List<Alumno> alumnoList;//lista todo
        private List<Alumno> alumnoList2;//lista los inactivos
        private List<Alumno> alumnoList3;//lista los activos
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }
        public void cargarClientes()
        {
            AlumnoNegocio alNeg = new AlumnoNegocio();
            alumnoList = alNeg.Listar();
            dgvClientes.DataSource = alumnoList;
        }
        private void btnAgregarAlu_Click(object sender, EventArgs e)
        {
            frmAgregarAL frmAgregarAL = new frmAgregarAL(); 
            frmAgregarAL.ShowDialog();
            cargarClientes();

        }
        private void btnEliminarAlu_Click_1(object sender, EventArgs e)
        {
            AlumnoNegocio alNeg = new AlumnoNegocio();
            Alumno seleccionado;
            Alumno Alumno= new Alumno();
            alNeg.eliminarAlumno(Alumno.idAlumno);
            try
            {
                DialogResult respuesta = MessageBox.Show("Quieres eliminar este alumno?");
                if(respuesta == DialogResult.OK)
                {
                    seleccionado = (Alumno)dgvClientes.CurrentRow.DataBoundItem;
                    alNeg.eliminarAlumno(seleccionado.idAlumno);
                    cargarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarAl_Click(object sender, EventArgs e)
        {
            Alumno alSeleccionado;

            alSeleccionado = (Alumno)dgvClientes.CurrentRow.DataBoundItem;


            frmAgregarAL modificar = new frmAgregarAL(alSeleccionado);
            modificar.ShowDialog();
            cargarClientes();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void txtFiltroDni_TextChanged(object sender, EventArgs e)
        {
            List<Alumno> FiltroAlDni; //no lo instancio porque lo de abajo me devuelve una lista

            string FiltroDni = txtFiltroDni.Text;

            if (FiltroDni != "")
            {

                FiltroAlDni = alumnoList.FindAll(x => x.DNI.ToLower().Contains(FiltroDni.ToLower()));

            }
            else
            {
                FiltroAlDni = alumnoList;
            }


            dgvClientes.DataSource = null; //limpio el datasource
            dgvClientes.DataSource = FiltroAlDni; //lo cargo con mi lista filtrada
        }

        private void txtFiltroNombreAl_TextChanged(object sender, EventArgs e)
        {
            List<Alumno> FiltroNombreAL; //no lo instancio porque lo de abajo me devuelve una lista

            string FiltroNombre = txtFiltroNombreAl.Text;

            if (FiltroNombre != "") //preguntar a los chicos si agrego un && de que si el boton de filtar inactivos se pulso
            {

                FiltroNombreAL = alumnoList.FindAll(x => x.Nombre.ToLower().Contains(FiltroNombre.ToLower()));

            }
            else
            {
                FiltroNombreAL = alumnoList;
            }


            dgvClientes.DataSource = null; //limpio el datasource
            dgvClientes.DataSource = FiltroNombreAL; //lo cargo con mi lista filtrada
        }

        private void txtFiltroApeAL_TextChanged(object sender, EventArgs e)
        {
            List<Alumno> FiltroApeAl; //no lo instancio porque lo de abajo me devuelve una lista

            string FiltroApellido = txtFiltroApeAL.Text;

            if (FiltroApellido != "")
            {

                FiltroApeAl = alumnoList.FindAll(x => x.Apellido.ToLower().Contains(FiltroApellido.ToLower()));

            }
            else
            {
                FiltroApeAl = alumnoList;
            }


            dgvClientes.DataSource = null; //limpio el datasource
            dgvClientes.DataSource = FiltroApeAl; //lo cargo con mi lista filtrada
        }

        public void cargarClientesInactivos()
        {
            AlumnoNegocio alNeg = new AlumnoNegocio();
            alumnoList2 = alNeg.ListarAlInactivos();
            dgvClientes.DataSource = alumnoList2;
        }

        private void btnFiltrarInactivos_Click(object sender, EventArgs e)
        {
            cargarClientesInactivos();
        }
        public void cargarClientesActivos()
        {
            AlumnoNegocio alNeg = new AlumnoNegocio();
            alumnoList3 = alNeg.ListarAlActivos();
            dgvClientes.DataSource = alumnoList3;
        }

        private void btnFiltrarActivos_Click(object sender, EventArgs e)
        {
            cargarClientesActivos();
        }
    }
}
