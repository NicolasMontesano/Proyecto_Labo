using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace winform_app
{
    public partial class AgregarEmpleado : Form
    {
        private Empleado emple = null;
        public AgregarEmpleado()
        {
            InitializeComponent();
            Empleado emple = new Empleado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            EmpleadoNegocio EmpleNegocio = new EmpleadoNegocio();

            try
            {
                if (emple == null)
                    emple = new Empleado();

                emple.Nombre = txtNombreEmple.Text;
                emple.Apellido = txtApellidoEmple.Text;
                emple.FechaNacimiento = dtpFechNacEmp.Value;
                emple.DNI = txtDNIemple.Text;
                usu.User = txtUsuarioEmple.Text;
                usu.Pass = txtContraEmple.Text;

                if (cbCatEmple.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione una categoria por favor");
                    return;
                }
                else
                {
                    emple.usuario.TipoUsuario = ((Usuario)cbCatEmple.SelectedItem).Id;
                }

                if (emple.Id != 0)
                {
                    // EmpleNegocio.modificar(emple);
                    //MessageBox.Show("Empleado modificado correctamente");

                }
                else
                {
                    EmpleNegocio.agregar_Sp(emple, usu);
                    MessageBox.Show("Empleado agregado correctamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            UsuarioNegocio cat = new UsuarioNegocio();

            cbCatEmple.DataSource = cat.listar();
            cbCatEmple.ValueMember = "Id";
            cbCatEmple.DisplayMember = "Tipo";
            cbCatEmple.SelectedIndex = -1;
        }
    }
}
