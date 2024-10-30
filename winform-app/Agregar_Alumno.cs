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
        private Alumno alumno = null;
        public frmAgregarAL()
        {
            InitializeComponent();
        }
        public frmAgregarAL(Alumno al)
        {
            InitializeComponent();
            Text = "Modficar ";
            this.alumno = al;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarAlu_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario();

            AlumnoNegocio alumnoNegocio = new AlumnoNegocio();
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

            try
            {
                if (alumno == null)
                    alumno = new Alumno();


                alumno.Nombre = txtNombre.Text;
                alumno.Apellido = txtApellido.Text;
                alumno.FechaNacimiento = dtpFechNacAl.Value;
                alumno.DNI = txtDniAl.Text;
                usuario.User = txtUsserAl.Text;
                usuario.Pass = txtPassUsu.Text;


                if (alumno.idAlumno != 0)
                {

                    alumnoNegocio.Modificar(alumno);
                    MessageBox.Show("MODIFICADO EXITOSAMENTE :)");
                    this.Close();

                }
                else
                {
                    alumnoNegocio.agregar_Sp(alumno, usuario);
                    //alumnoNegocio.agregar(alumno);
                    //usuarioNegocio.agregar(usuario);

                    MessageBox.Show("Agregado Exitosamente :D");
                    this.Close();

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregarAL_Load(object sender, EventArgs e)
        {
            try
            {


                if (alumno != null)
                {
                    txtNombre.Text = alumno.Nombre;
                    txtApellido.Text = alumno.Apellido;
                    txtDniAl.Text = alumno.DNI;
                    ///dtpFechNacAl.Value = alumno.FechaNacimiento;
                    //txtUsserAl.Visible = false;
                    //txtPassUsu.Visible = false;
                    //lblContrasñaAl.Visible = false;
                    //lblUsu.Visible = false;
                    UsuarioNegocio usuarioNegocio = new UsuarioNegocio();

                    Usuario usu = new Usuario();
                    usu = usuarioNegocio.ObtenerUsuario(alumno.IdUsuario);

                    txtUsserAl.Text = usu.User;
                    txtPassUsu.Text = usu.Pass;

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
