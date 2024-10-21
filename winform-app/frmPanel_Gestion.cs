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
        public int Tipo_usuario = 0;
        public frmPanel_Gestion(int tipo_usuario)
        {
            InitializeComponent();
            Tipo_usuario = tipo_usuario;

            if(Tipo_usuario == 0)
            {
                MessageBox.Show("Error al ingresar");
                this.Close();
            }
            if(Tipo_usuario != 1)
            {
                tsmiEmpleados.Enabled = false;
            }
            if(tipo_usuario == 2)
            {
                tsmiIngresos.Enabled = false;
                tsmiFacturas.Enabled = false;
            }
            if( tipo_usuario == 3)
            {
                tsmiDisciplinas.Enabled = false;
                tsmiRutinas.Enabled = false;
                tsmiEjercicios.Enabled = false;
            }
        }

        private void frmPanel_Gestion_Load(object sender, EventArgs e)
        {

        }

        private void vistasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
