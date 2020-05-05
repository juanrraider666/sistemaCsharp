using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appPinturasV1.Entidades;
using appPinturasV1.Logica;


namespace appPinturasV1.Vista
{
    public partial class frmLoginV : Form
    {
        public frmLoginV()
        {
            InitializeComponent();
        }
        Point posicion;
        Boolean mouse;
        private void frmLoginV_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "Usuario";
            txtUsuario.ForeColor = Color.Gray;
            txtContraseña.Text = "Contraseña";
            txtContraseña.ForeColor = Color.Gray;
        }
        
        clLoginE objLoginE = new clLoginE();
        clLoginL objLoginL = new clLoginL();
        //frmAdministradorV objFrmAdministrador = new frmAdministradorV();
        frmMenuAdministrador objPrincipalV = new frmMenuAdministrador();
        frmVentasV  objVentasV = new frmVentasV();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            objLoginE.usuario = txtUsuario.Text;
            objLoginE.Contraseña = txtContraseña.Text;
            if (txtUsuario.Text == "Usuario" || txtContraseña.Text == "Contraseña" )
            {
                MessageBox.Show("Ingrese Usuario y contraseña validos","Error en inicio de sesión");
            }
            else
            {
                List<clLoginE> log = new List<clLoginE>();
                log = objLoginL.mtdIngreso(objLoginE);
                objPrincipalV.nomb = log[0].Nombre;
                objPrincipalV.apell = log[0].Apellido;
                objPrincipalV.id = log[0].Id;
                int ingreso = log[0].Id;



                if (ingreso == 1)
                {
                    this.Hide();
                    objPrincipalV.Show();
                }
                else if (ingreso == 2)
                {
                    this.Hide();
                    objPrincipalV.Show();
                }
                else
                {
                    MessageBox.Show("Verificar datos", "Error en el inicio de sesion");
                }
            }
        }
            

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseña.Text = "";
            txtContraseña.ForeColor = Color.Black;
            txtContraseña.MaxLength = 10;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtUsuario.ForeColor = Color.Black;
        }

        private void btnLogin_MouseMove(object sender, MouseEventArgs e)
        {
            
            btnLogin.BackgroundImage = Properties.Resources.aq;
            btnLogin.BackColor = Color.Transparent;

        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
          
            btnLogin.BackgroundImage = Properties.Resources.h;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿Esta seguro de que desea salir?", "Mensage de estado",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmLoginV_MouseDown(object sender, MouseEventArgs e)
        {
            posicion = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouse = true;
        }

        private void frmLoginV_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse==true)
            {
                Location= new Point(Cursor.Position.X - posicion.X, Cursor.Position.Y - posicion.Y);
            }
        }

        private void frmLoginV_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
