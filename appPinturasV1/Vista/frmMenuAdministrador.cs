using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appPinturasV1.Vista
{
    public partial class frmMenuAdministrador : Form
    {
        public string nomb { get; set; }
        public string apell { get; set; }
        public int id { get; set; }

        public frmMenuAdministrador()
        {
            InitializeComponent();
        }

        frmRegistrarPersona objregistroP = new frmRegistrarPersona();
        frmRegistrarProducto objProducto = new frmRegistrarProducto();
        frmListarPersona objPersonaL = new frmListarPersona();
        frmListarProducto objProductosL = new frmListarProducto();
        Point posicion;
        Boolean mouse;

        frmVentasV objVetas = new frmVentasV();
        private void btnRegistrarPersona_Click(object sender, EventArgs e)
        {
            objregistroP.Show();
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            objProducto.Show();
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            string nombre = nomb;
            string apellido = apell;
            objVetas.nombEmpleado = nombre;
            objVetas.apellEmpleado = apellido;
            objVetas.Show();
        }

        private void btnListarPersona_Click(object sender, EventArgs e)
        {
            objPersonaL.Show();
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            objProductosL.Show();
        }

        private void frmMenuAdministrador_Load(object sender, EventArgs e)
        {
            int identidad = id;
            if (identidad!=1)
            {
                btnRegistrarPersona.Enabled =false;
                btnRegistrarPersona.Cursor = Cursors.No;
                btnRegistrarProducto.Enabled = false;
                btnRegistrarProducto.Cursor = Cursors.No;
                btnListarPersona.Enabled = false;
                btnListarPersona.Cursor = Cursors.No;
                
                string nombre = nomb;
                string apellido = apell;
                lblRol.Text = "Empleado :"+nombre+" "+apellido;
            }
            else
            {
                
                string nombre = nomb;
                string apellido = apell;
                lblRol.Text = "Administrador :" + nombre + " " + apellido;

            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmMenuAdministrador_MouseDown(object sender, MouseEventArgs e)
        {
            posicion = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouse = true;
        }

        private void frmMenuAdministrador_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == true)
            {
                Location = new Point(Cursor.Position.X - posicion.X, Cursor.Position.Y - posicion.Y);
            }
        }

        private void frmMenuAdministrador_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }
    }
}
