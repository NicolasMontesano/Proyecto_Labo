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
            dgvClientes.DataSource = alNeg.Listar();
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
    }
}
