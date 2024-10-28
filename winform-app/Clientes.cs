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
    }
}
