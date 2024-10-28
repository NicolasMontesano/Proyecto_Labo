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
using negocio;

namespace winform_app
{
    public partial class frmLogin : Form
    {
        private Usuario usu;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("El Usuario es requerido");
                return;
            }
            else if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("La contraseña es requerida");
                return;
            }

            try
            {
                UsuarioNegocio negocio = new UsuarioNegocio();
                Usuario usu = negocio.Login(txtUsuario.Text, txtContraseña.Text);

                if (usu == null)
                {
                    MessageBox.Show("Ocurrió un error con el ingreso");
                    return;
                }

                if (usu.Id == 0)
                {
                    MessageBox.Show("Usuario inválido");
                    return;
                }

                //MessageBox.Show("Ingreso exitoso");
                //redireccionar a la siguiente página

                if (usu.TipoUsuario == 4)
                {
                    AlumnoNegocio negAlumno = new AlumnoNegocio();

                    Alumno alumno = negAlumno.ObtenerAlumnoxIdUsuario(usu.Id);

                    if(alumno.Estado == 1)
                    {
                        frmIngreso_Alumno frmIngreso = new frmIngreso_Alumno(alumno);
                        this.Hide();
                        frmIngreso.Show();
                    }
                    MessageBox.Show("Usuario inactivo");
                }
                else
                {
                    EmpleadoNegocio empNeg = new EmpleadoNegocio();
                    Empleado emp = new Empleado();

                    emp = empNeg.ObtenerEmpleadoxIdUsuario(usu.Id);
                    emp.usuario = new Usuario();
                    emp.usuario = usu;

                    if(emp.Activo == 1)
                    {
                        this.Hide();
                        frmPanel_Gestion ventGestion = new frmPanel_Gestion(emp);
                        ventGestion.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error con el ingreso");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContraseña.Clear();
            txtUsuario.Clear();
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
