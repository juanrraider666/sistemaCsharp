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
    public partial class frmVentasV : Form
    {
        public frmVentasV()
        {
            InitializeComponent();
        }
        clLoginL objLoginL = new clLoginL();
        public string nombEmpleado { get; set; }
        public string apellEmpleado { get; set; }
        private void frmVentas_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
            Random rnd = new Random();
            lblNumVenta.Text = rnd.Next(999).ToString(); ;
            
            List<clLoginE> log = new List<clLoginE>();

            lblNombre.Text = nombEmpleado;
            lblApellido.Text = apellEmpleado;

            clBDSql c = new clBDSql();
           
            c.mtdAutoComplete(txtDocCliente);
        }

        clPersonaE objPersonaE = new clPersonaE();
        clPersonaL objPersonaL = new clPersonaL();
        clVentaE objVentaE = new clVentaE();
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            List<clPersonaE> lista = new List<clPersonaE>();
            objPersonaE.Documento = txtDocCliente.Text;
          lista= objPersonaL.mtdListarPersona(objPersonaE);
            txtNomCliente.Text = lista[0].Nombre;
            txtApellCliente.Text = lista[0].Apellido;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            objPersonaE.Documento = txtDocCliente.Text;
            objPersonaE.Nombre = txtNomCliente.Text;
            objPersonaE.Apellido= txtApellCliente.Text;
            objPersonaE.IdRol = 3;
            int Registros = objPersonaL.mtdValidar(objPersonaE);
            if (Registros == -2)
            {
                MessageBox.Show("Datos Nulos");
            }
            else if (Registros == 1)
            {
                MessageBox.Show("cliente Registrado");
            }
        }
        clProductoL objProductoL = new clProductoL();
        clProductoE objProductoE = new clProductoE();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<clProductoE> listaVenta = new List<clProductoE>();
            objProductoE.Referencia = txtBusqRef.Text;
            listaVenta = objProductoL.mtdListarProducto(objProductoE);

            dgvVenta.Rows.Add(listaVenta[0].Producto,listaVenta[0].IdPresentacion,txtCantidad.Text,listaVenta[0].Precio);
            lblProducto.Text = "";
            txtBusqRef.Text = "";
            
        }

        private void txtBusqRef_TextChanged(object sender, EventArgs e)
        {
            List < clProductoE > listaVenta = new List<clProductoE>();
            objProductoE.Referencia = txtBusqRef.Text;
            listaVenta = objProductoL.mtdListarProducto(objProductoE);
            if (txtBusqRef.Text == "")
            {

            }
            else
            {
                lblProducto.Text = listaVenta[0].Producto + " " + listaVenta[0].Color;
            }
            
        } 
        

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            if (dgvVenta.SelectedRows.Count>0)
            {
                dgvVenta.Rows.Remove(dgvVenta.SelectedRows[0]);
            }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            //Creamos una instancia d ela clase CrearTicket
            clVentasL ticket = new clVentasL();
            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

            //Datos de la cabecera del Ticket.
            ticket.TextoCentro("PINTURAS Y MEZCLAS DEL LLANO");
            ticket.TextoIzquierda("EXPEDIDO EN: PAZ DE ARIPORO(CASANARE)");
            ticket.TextoIzquierda("DIREC: DIRECCION DE LA EMPRESA");
            ticket.TextoIzquierda("TELEF: 3204646467");
            ticket.TextoIzquierda("NIT : 46671466-4");
            ticket.TextoIzquierda("EMAIL: yanetgonzales71@gmail.com");//Es el mio por si me quieren contactar ...
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("Caja # 1", "Ticket # "+ lblNumVenta.Text);
            ticket.lineasAsteriscos();

            //Sub cabecera.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ATENDIÓ:"+lblNombre.Text+" "+lblApellido.Text);
            ticket.TextoIzquierda("CLIENTE:"+txtNomCliente.Text+" "+txtApellCliente.Text);
            ticket.TextoIzquierda("");
            ticket.TextoCentro("FECHA: " + DateTime.Now.ToShortDateString()+ " HORA: " + DateTime.Now.ToShortTimeString());
            ticket.lineasAsteriscos();

            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, 
            ticket.lineasAsteriscos();
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            int i = 0;
            foreach (DataGridViewRow dgventa in dgvVenta.Rows)//dgvLista es el nombre del datagridview
            {
                //string dato = dgvVenta.Rows[i].Cells[0].Value.ToString();
                //i++;
                //string dato1 = dgvVenta.CurrentRow.Cells[0].Value.ToString();
                //int dato2 = int.Parse(dgvVenta.CurrentRow.Cells[1].Value.ToString());
                //int dato3 = int.Parse(dgvVenta.CurrentRow.Cells[2].Value.ToString());
                //decimal dato4 = decimal.Parse(dgvVenta.CurrentRow.Cells[3].Value.ToString());

                ticket.AgregarArticulos(dgvVenta.Rows[i].Cells[0].Value.ToString(), int.Parse(dgvVenta.Rows[i].Cells[1].Value.ToString()),
            int.Parse(dgvVenta.Rows[i].Cells[2].Value.ToString()), decimal.Parse(dgvVenta.Rows[i].Cells[3].Value.ToString()));
                
            }
            ////ticket.AgregaArticulo("Articulo A", 2, 20, 40);
            ////ticket.AgregaArticulo("Articulo B", 1, 10, 10);
            ////ticket.AgregaArticulo("Este es un nombre largo del articulo, para mostrar como se bajan las lineas", 1, 30, 30);
            ticket.lineasIgual();

            //Resumen de la venta. Sólo son ejemplos
            ticket.AgregarTotales("         SUBTOTAL......$", 100);
            ticket.AgregarTotales("         IVA...........$", 19.0M);//La M indica que es un decimal en C#
            ticket.AgregarTotales("         TOTAL.........$", 200);
            ticket.TextoIzquierda("");
            ticket.AgregarTotales("         EFECTIVO......$", 200);
            ticket.AgregarTotales("         CAMBIO........$", 0);

            //Texto final del Ticket.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ARTÍCULOS VENDIDOS:");
            ticket.TextoIzquierda("");
            ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
            ticket.CortaTicket();
            ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera
        }

        private void txtDocCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            clValidarV.soloNumeros(e);
        }

        private void txtDocCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

