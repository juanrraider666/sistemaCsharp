using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace appPinturasV1.Datos
{
    class clBDSql
    {
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        SqlCommand cmdRegistrar;
        SqlDataReader datareader;
        public clBDSql()
        {
            conexion = new SqlConnection("Data Source=BAUTISTA-PC;Initial Catalog=MER.Proyecto;Integrated Security=True");
            conexion.Open();

        }

        public DataTable mtdSelect(string consulta)
        {
            //conexion.Open();
            adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            conexion.Close();
            return tblDatos;
        }



        public void mtdAutoComplete(TextBox cajaTexto)

        {

            try
            {
                cmdRegistrar = new SqlCommand("select Documento from Persona", conexion);
                datareader = cmdRegistrar.ExecuteReader();

                while (datareader.Read())
                {
                    cajaTexto.AutoCompleteCustomSource.Add(datareader["Documento"].ToString());

                }
                datareader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("hay un problema porque :" + ex.ToString());

            }

        }


        public void mtdAutoCompleteNombre(TextBox cajaTexto)

        {

            try
            {
                cmdRegistrar = new SqlCommand("select Nombre from Persona", conexion);
                datareader = cmdRegistrar.ExecuteReader();

                while (datareader.Read())
                {
                    cajaTexto.AutoCompleteCustomSource.Add(datareader["Nombre"].ToString());

                }
                datareader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("hay un problema porque :" + ex.ToString());

            }

        }


        /// <summary>
        /// Este metodo hace la administracion de datos(incert-delete-up)
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public int mtdIDU(string consulta)
        {
            //conexion.Open();
            cmdRegistrar = new SqlCommand();
            cmdRegistrar.Connection = conexion;
            cmdRegistrar.CommandText = consulta;
            int cantidad = cmdRegistrar.ExecuteNonQuery();
            conexion.Close();
            return cantidad;
        }
    }
}
