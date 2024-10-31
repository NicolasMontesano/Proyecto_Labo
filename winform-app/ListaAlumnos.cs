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
        private List<Alumno> alumnoList;

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

        private void btnFiltroDni_Click(object sender, EventArgs e)
        {

            List<Alumno> FiltroAlDni; //no lo instancio porque lo de abajo me devuelve una lista

            string FiltroDni = txtFiltroDni.Text;

          if(FiltroDni != "")
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

    }
}
