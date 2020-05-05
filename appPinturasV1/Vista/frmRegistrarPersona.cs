using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appPinturasV1.Logica;
using appPinturasV1.Entidades;

namespace appPinturasV1.Vista
{
    public partial class frmRegistrarPersona : Form
    {
        public frmRegistrarPersona()
        {
            InitializeComponent();
        }
        clRolL objRolL = new clRolL();

        clPersonaL objPersonaL = new clPersonaL();
        clPersonaE objPersonaE = new clPersonaE();
        Point posicion;
        Boolean mouse;
        private void frmRegistrarPersona_Load_1(object sender, EventArgs e)
        {
            cmbRol.DataSource = objRolL.mtdListar();
            cmbRol.DisplayMember = "Rol";
            cmbRol.ValueMember = "IdRol";
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            objPersonaE.Documento = txtDocumento.Text;
            objPersonaE.Nombre = txtNombre.Text;
            objPersonaE.Apellido = txtApellido.Text;
            objPersonaE.Usuario = txtUsuario.Text;
         //   txtContraseña.MaxLength = 10;
            objPersonaE.Contraseña = txtContraseña.Text;
            objPersonaE.IdRol = int.Parse(cmbRol.SelectedValue.ToString());

            int Registros = objPersonaL.mtdValidar(objPersonaE);

            if (Registros == -2)
            {
                MessageBox.Show("Datos Nulos");
            }
            else if (Registros == 1)
            {
                MessageBox.Show("Persona Registrado");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de que desea salir?", "Mensage de estado",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question)
       == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmRegistrarPersona_MouseDown(object sender, MouseEventArgs e)
        {
            posicion = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouse = true;
        }

        private void frmRegistrarPersona_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == true)
            {
                Location = new Point(Cursor.Position.X - posicion.X, Cursor.Position.Y - posicion.Y);
            }
        }

        private void frmRegistrarPersona_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

   

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidarV.soloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidarV.soloLetras(e);
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
