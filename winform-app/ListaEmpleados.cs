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
    public partial class ListaEmpleados : Form
    {
        private List<Empleado> listaEmpleado;


        public ListaEmpleados()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void cargarEmpleados()
        {
            EmpleadoNegocio EmpNeg = new EmpleadoNegocio();
            listaEmpleado = EmpNeg.Listar();
            dgvEmpleados.DataSource = listaEmpleado;
        }

        private void ListaEmpleados_Load(object sender, EventArgs e)
        {
            cargarEmpleados();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EmpleadoNegocio EmpNeg = new EmpleadoNegocio();
            Empleado seleccionado;
            Empleado empleado = new Empleado();
            EmpNeg.eliminarEmpleado(empleado.Id);
            try
            {
                DialogResult respuesta = MessageBox.Show("Quieres eliminar este Empleado?");
                if (respuesta == DialogResult.OK)
                {
                    seleccionado = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
                    EmpNeg.eliminarEmpleado(seleccionado.Id);
                    cargarEmpleados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Empleado seleccionado;

            seleccionado = (Empleado)dgvEmpleados.CurrentRow.DataBoundItem;

            AgregarEmpleado modifico = new AgregarEmpleado();
            modifico.ShowDialog();
        }
    }
}
