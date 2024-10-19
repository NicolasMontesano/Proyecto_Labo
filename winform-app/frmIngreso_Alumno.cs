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
    public partial class frmIngreso_Alumno : Form
    {
        public Alumno alumno = null;
        public frmIngreso_Alumno()
        {
            InitializeComponent();
        }
        public frmIngreso_Alumno(Alumno alumno)
        {
            InitializeComponent();
            this.alumno = alumno;
        }

        private void frmIngreso_Alumno_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        //private void SetupUI()
        //{
        //    // Configuración general del formulario
        //    this.Text = "Bienvenido al Gimnasio";
        //    this.Size = new Size(800, 600);
        //    this.BackColor = Color.FromArgb(40, 40, 40); // Fondo oscuro

        //    // Etiqueta de bienvenida
        //    Label welcomeLabel = new Label();
        //    welcomeLabel.Text = "Bienvenido, [Nombre del Cliente]";
        //    welcomeLabel.Font = new Font("Arial", 24, FontStyle.Bold);
        //    welcomeLabel.ForeColor = Color.White;
        //    welcomeLabel.AutoSize = true;
        //    welcomeLabel.Location = new Point(250, 50);
        //    this.Controls.Add(welcomeLabel);

        //    // Botón de Check-In
        //    Button btnCheckIn = new Button();
        //    btnCheckIn.Text = "Check-In";
        //    btnCheckIn.Font = new Font("Arial", 14);
        //    btnCheckIn.BackColor = Color.FromArgb(0, 122, 204); // Azul brillante
        //    btnCheckIn.ForeColor = Color.White;
        //    btnCheckIn.Size = new Size(200, 50);
        //    btnCheckIn.Location = new Point(300, 150);
        //    btnCheckIn.FlatStyle = FlatStyle.Flat;
        //    this.Controls.Add(btnCheckIn);

        //    // Botón Ver Horarios
        //    Button btnSchedule = new Button();
        //    btnSchedule.Text = "Ver Horarios";
        //    btnSchedule.Font = new Font("Arial", 14);
        //    btnSchedule.BackColor = Color.FromArgb(0, 122, 204);
        //    btnSchedule.ForeColor = Color.White;
        //    btnSchedule.Size = new Size(200, 50);
        //    btnSchedule.Location = new Point(300, 250);
        //    btnSchedule.FlatStyle = FlatStyle.Flat;
        //    this.Controls.Add(btnSchedule);

        //    // Botón Estado de Membresía
        //    Button btnMembership = new Button();
        //    btnMembership.Text = "Estado de Membresía";
        //    btnMembership.Font = new Font("Arial", 14);
        //    btnMembership.BackColor = Color.FromArgb(0, 122, 204);
        //    btnMembership.ForeColor = Color.White;
        //    btnMembership.Size = new Size(200, 50);
        //    btnMembership.Location = new Point(300, 350);
        //    btnMembership.FlatStyle = FlatStyle.Flat;
        //    this.Controls.Add(btnMembership);

        //    // Agregar una imagen de fondo opcional (íconos de gimnasio)
        //    Panel backgroundPanel = new Panel();
        //    backgroundPanel.Size = new Size(800, 600);
        //    backgroundPanel.BackgroundImage = Image.FromFile("path/to/gym_image.jpg"); // Ruta de la imagen
        //    backgroundPanel.BackgroundImageLayout = ImageLayout.Center;
        //    backgroundPanel.Controls.Add(welcomeLabel); // Se asegura que el texto esté visible
        //    backgroundPanel.Controls.Add(btnCheckIn);
        //    backgroundPanel.Controls.Add(btnSchedule);
        //    backgroundPanel.Controls.Add(btnMembership);
        //    this.Controls.Add(backgroundPanel);
        //}
    }
}
