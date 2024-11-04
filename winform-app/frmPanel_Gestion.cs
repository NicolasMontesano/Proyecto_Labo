using dominio;
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
    public partial class frmPanel_Gestion : Form
    {
        public Empleado emp = null;
        public frmPanel_Gestion(Empleado emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        private void frmPanel_Gestion_Load(object sender, EventArgs e)
        {
            if (emp.usuario.TipoUsuario == 0)
            {
                MessageBox.Show("Error al ingresar");
                this.Close();
            }
            if (emp.usuario.TipoUsuario != 1)
            {
                tsmiEmpleados.Visible = false;
            }
            if (emp.usuario.TipoUsuario == 2)
            {
                tsmiIngresos.Visible = false;
                tsmiFacturas.Visible = false;
            }
            if (emp.usuario.TipoUsuario == 3)
            {
                tsmiDisciplinas.Visible = false;
                tsmiRutinas.Visible = false;
                tsmiEjercicios.Visible = false;
            }

        }

        private void vistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturas frmFacturas = new frmFacturas();    
            frmFacturas.ShowDialog();   
        }

        private void tsmiClientes_Click(object sender, EventArgs e)
        {
            frmClientes ventCliente = new frmClientes();
            ventCliente.ShowDialog();

        }

        private void tsmiIngresos_Click(object sender, EventArgs e)
        {
            frmIngresos frmIngresos = new frmIngresos(emp.Id);
            frmIngresos.ShowDialog();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarEmpleado AgregoEmple = new AgregarEmpleado();
            AgregoEmple.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaEmpleados ListaEmple = new ListaEmpleados();
            ListaEmple.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaEmpleados ListaEmple = new ListaEmpleados();
            ListaEmple.ShowDialog();
        }
    }
}
