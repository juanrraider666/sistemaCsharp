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
using appPinturasV1.Datos;

namespace appPinturasV1.Vista
{
    public partial class frmRegistrarProducto : Form
    {
        public frmRegistrarProducto()
        {
            InitializeComponent();
        }
        clTipoL objTipoL = new clTipoL();
        clPresentacionL objPresL = new clPresentacionL();
        Point posicion;
        Boolean mouse;
        private void frmRegistrarProducto_Load(object sender, EventArgs e)
        {

            cmbTipo.DataSource = objTipoL.mtdListar();
            cmbTipo.DisplayMember = "Tipo";
            cmbTipo.ValueMember = "IdTipo";

            cmbPresentacion.DataSource = objPresL.mtdListar();
            cmbPresentacion.DisplayMember = "Presentacion";
            cmbPresentacion.ValueMember = "IdPresentacion";
        }
        clProductoL objProductoL = new clProductoL();
        clProductoE objProductoE = new clProductoE();
        private void btnRegistar_Click(object sender, EventArgs e)
        {
            objProductoE.Producto = txtProducto.Text;
            objProductoE.FechaIngreso = dtmFechaIngreso.Value;
            objProductoE.FechaVencimiento = DateTime.Parse(dtmFechaVencimiento.Text);
            objProductoE.Referencia = txtRefenerncia.Text;
            objProductoE.Color = txtColor.Text;
            objProductoE.Cantidad = int.Parse(txtCantidad.Text);
            objProductoE.Marca = txtMarca.Text;
            objProductoE.Precio = double.Parse(txtPrecio.Text);
            objProductoE.IdTipoProducto = int.Parse(cmbTipo.SelectedValue.ToString());
            objProductoE.IdPresentacion = int.Parse(cmbPresentacion.SelectedValue.ToString());
            //List<clProductoE> validar = new List<clProductoE>();
            //validar = objProductoL.mtdListarProducto(objProductoE);
            //if (validar[0].IdProducto >= 1)
            //{
            //    MessageBox.Show("producto ya existente");
            //}
            //else
            //{
                int Registros = objProductoL.mtdValidar(objProductoE);

                if (Registros == -2)
                {
                    MessageBox.Show("Datos Nulos");
                }
                else if (Registros == 1)
                {
                    MessageBox.Show("Producto Registrado");
                }
           // }
            

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

        private void frmRegistrarProducto_MouseDown(object sender, MouseEventArgs e)
        {
            posicion = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouse = true;
        }

        private void frmRegistrarProducto_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == true)
            {
                Location = new Point(Cursor.Position.X - posicion.X, Cursor.Position.Y - posicion.Y);
            }
        }

        private void frmRegistrarProducto_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
