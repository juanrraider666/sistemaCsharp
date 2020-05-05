using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appPinturasV1.Datos;
using appPinturasV1.Entidades;
using appPinturasV1.Logica;

namespace appPinturasV1.Vista
{
    public partial class frmListarProducto : Form
    {
        public frmListarProducto()
        {
            InitializeComponent();
        }

        private void frmListarProducto_Load(object sender, EventArgs e)
        {

            cmbTipo.DataSource = objTipol.mtdListar();
            cmbTipo.DisplayMember = "Tipo";
            cmbTipo.ValueMember = "IdTipo";


            cmbPresentacion.DataSource = objPresL.mtdListar();
            cmbPresentacion.DisplayMember = "Presentacion";
            cmbPresentacion.ValueMember = "IdPresentacion";
            dgvProductos.DataSource = objProL.mtdListarProducto();

        }

        clProductoL objProL = new clProductoL();
        clTipoL objTipol = new clTipoL(); 
        clPresentacionL objPresL = new clPresentacionL();
        Point posicion;
        Boolean mouse;

        private void btnProducto_Click(object sender, EventArgs e)
        {
            clProductoE objProE = new clProductoE();
            objProE.Producto = txtProducto.Text;
            dgvProductos.DataSource = objProL.mtdListarProducto(objProductoE: objProE);

            

        }

        private void btnReferencia_Click(object sender, EventArgs e)
        {
            clProductoE objProE = new clProductoE();
            objProE.Referencia = txtReferencia.Text;
            dgvProductos.DataSource = objProL.mtdListarProducto(objProductoE: objProE);
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                clProductoE objPE = new clProductoE();
                objPE.IdTipoProducto = int.Parse(cmbTipo.SelectedValue.ToString());
                dgvProductos.DataSource = objProL.mtdListarProducto(objProductoE: objPE);
            }
            catch (Exception ex)
            {

                MessageBox.Show("f : "+ex.ToString());
            }
        }

        private void cmbPresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                clProductoE objPE = new clProductoE();
                objPE.IdPresentacion = int.Parse(cmbPresentacion.SelectedValue.ToString());
                dgvProductos.DataSource = objProL.mtdListarProducto(objProductoE: objPE);
            }
            catch (Exception ex)
            {
                MessageBox.Show("f : " + ex.ToString());

            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = objProL.mtdListarProducto();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmListarProducto_MouseDown(object sender, MouseEventArgs e)
        {
            posicion = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouse = true;
        }

        private void frmListarProducto_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == true)
            {
                Location = new Point(Cursor.Position.X - posicion.X, Cursor.Position.Y - posicion.Y);
            }
        }

        private void frmListarProducto_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }
    }
}
