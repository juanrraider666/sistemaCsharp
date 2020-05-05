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
    public partial class frmTipoPresentacion : Form
    {
        public frmTipoPresentacion()
        {
            InitializeComponent();
        }
        clTipoL objTipoL = new clTipoL();
        clTipoE objTipoE = new clTipoE();
        clPresentacionL objPresentacionL = new clPresentacionL();
        clPresentacionE objPresnetacionE = new clPresentacionE();
        private void frmTipoPresentacion_Load(object sender, EventArgs e)
        {
            txtTipo.Text = "Tipo";
            txtTipo.ForeColor = Color.Gray;
            txtDescripcionTipo.Text = "Descrpción";
            txtDescripcionTipo.ForeColor = Color.Gray;
            txtPresentacion.Text = "Presentación";
            txtPresentacion.ForeColor = Color.Gray;
            txtDescripcionPresentacion.Text = "Descripción";
            txtDescripcionPresentacion.ForeColor = Color.Gray;
            dgvListaTipo.DataSource = objTipoL.mtdListar();
            dgvListaPresentacion.DataSource = objPresentacionL.mtdListar();
            
        }

        private void txtTipo_Enter(object sender, EventArgs e)
        {
            txtTipo.ForeColor = Color.Black;
            txtTipo.Text = "";
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            txtDescripcionTipo.ForeColor = Color.Black;
            txtDescripcionTipo.Text = "";
        }

        private void txtPresentacion_Enter(object sender, EventArgs e)
        {
            txtPresentacion.ForeColor = Color.Black;
            txtPresentacion.Text = "";
        }

        private void txtDescripcion2_Enter(object sender, EventArgs e)
        {
            txtDescripcionPresentacion.ForeColor = Color.Black;
            txtDescripcionPresentacion.Text = "";
        }

        private void btnGuardarPresentacion_Click(object sender, EventArgs e)
        {
            clPresentacionL objPresentacionL = new clPresentacionL();
            objPresnetacionE.Presentacion = txtPresentacion.Text;
            objPresnetacionE.descripcion = txtDescripcionPresentacion.Text;
            int Registros = objPresentacionL.mtdValidarPresentacion(objPresnetacionE);
            if (Registros == -2)
            {
                MessageBox.Show("Datos Nulos");
            }
            else if (Registros == 1)
            {
                MessageBox.Show("Presentacion Registrada");
            }
            dgvListaPresentacion.DataSource = objPresentacionL.mtdListar();
        }

        private void btnGuardarTipo_Click(object sender, EventArgs e)
        {
            clTipoL objTipoL = new clTipoL();
            //objPresnetacionE.Presentacion = txtPresentacion.Text;
            //objPresnetacionE.descripcion = txtDescripcionPresentacion.Text
            objTipoE.Tipo = txtTipo.Text;
            objTipoE.Descripcion = txtDescripcionTipo.Text;

            int Registros = objTipoL.mtdValidatIPO(objTipoE);
            if (Registros == -2)
            {
                MessageBox.Show("Datos Nulos");
            }
            else if (Registros == 1)
            {
                MessageBox.Show("Tipo Registrado");
            }
            dgvListaTipo.DataSource = objTipoL.mtdListar();
        }
    }
}
