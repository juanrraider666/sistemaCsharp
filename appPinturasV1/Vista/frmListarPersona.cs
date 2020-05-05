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
using appPinturasV1.Datos;


namespace appPinturasV1.Vista
{
    public partial class frmListarPersona : Form
    {
        public frmListarPersona()
        {
            InitializeComponent();
        }
        clPersonaL objPersonaL = new clPersonaL();
        clRolL objRolL = new clRolL();
        clBDSql c = new clBDSql();
        Point posicion;
        Boolean mouse;
        private void btnNombre_Click(object sender, EventArgs e)
        {
            clPersonaE objPE = new clPersonaE();
            objPE.Nombre = txtNombre.Text;
            dgvPersonas.DataSource = objPersonaL.mtdListarPersona(objPersonaE: objPE);
        }

        private void btnDocumento_Click(object sender, EventArgs e)
        {
            clPersonaE objPE = new clPersonaE();
            objPE.Documento = txtDocumento.Text;
            dgvPersonas.DataSource = objPersonaL.mtdListarPersona(objPersonaE: objPE);
        }

        private void frmListarPersona_Load(object sender, EventArgs e)
        {
            dgvPersonas.DataSource = objPersonaL.mtdListarPersona();
            cmbRol.DataSource = objRolL.mtdListar();
            cmbRol.DisplayMember = "Rol";
            cmbRol.ValueMember = "IdRol";


            c.mtdAutoCompleteNombre(txtNombre);
        }

        private void cmbRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                clPersonaE objPe = new clPersonaE();
                objPe.IdRol = int.Parse(cmbRol.SelectedValue.ToString());
                dgvPersonas.DataSource = objPersonaL.mtdListarPersona(objPersonaE: objPe);
            }
            catch (Exception)
            {

                
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            dgvPersonas.DataSource = objPersonaL.mtdListarPersona();
        }

      

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidarV.soloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidarV.soloLetras(e);
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

        private void frmListarPersona_MouseDown(object sender, MouseEventArgs e)
        {
            posicion = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouse = true;
        }

        private void frmListarPersona_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == true)
            {
                Location = new Point(Cursor.Position.X - posicion.X, Cursor.Position.Y - posicion.Y);
            }
        }

        private void frmListarPersona_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }
    }
}
