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
using negocio;



namespace winform_app
{
    public partial class frmAgregarAL : Form
    {
        public frmAgregarAL()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarAlu_Click(object sender, EventArgs e)
        {
            
            Alumno alumno = new Alumno();   
            Usuario usuario = new Usuario();

            AlumnoNegocio alumnoNegocio = new AlumnoNegocio();
            UsuarioNegocio usuarioNegocio= new UsuarioNegocio();



            try
            {
                alumno.Nombre = txtNombre.Text;
                alumno.Apellido = txtApellido.Text;
                alumno.FechaNacimiento = dtpFechNacAl.Value;
                alumno.DNI = txtDniAl.Text;
                usuario.User = txtUsserAl.Text;
                usuario.Pass = txtPassUsu.Text;

                alumnoNegocio.agregar_Sp(alumno, usuario);
                //alumnoNegocio.agregar(alumno);
                //usuarioNegocio.agregar(usuario);

                MessageBox.Show("Agregado Exitosamente :D");
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }



        }
    }
}
