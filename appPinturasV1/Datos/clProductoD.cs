using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appPinturasV1.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace appPinturasV1.Datos
{
    class clProductoD
    {
        clBDSql objBDsql = new clBDSql();
        clProductoE objProductoE = new clProductoE();

        public int mtdRegistrar(clProductoE objProductoE)
        {

            string consulta = "insert into Producto(Producto ,FechadeIngreso,FechadeVencimiento," +
                "Referencia,Color,Cantidad,Marca,Precio," +
                "IdTipo,IdPresentacion)values('" + objProductoE.Producto + "','" + objProductoE.FechaIngreso + "','" +
                "" + objProductoE.FechaVencimiento + "','" + objProductoE.Referencia + "','" + objProductoE.Color + "'," +
                "'" + objProductoE.Cantidad + "','" + objProductoE.Marca + "','" + objProductoE.Precio + "','" + objProductoE.IdTipoProducto + "','" + objProductoE.IdPresentacion + "')";
            int registros = objBDsql.mtdIDU(consulta);
            return registros;
        }

        public List<clProductoE> mtdListar(clProductoE objProdE)
        {
            string consulta = "";
            DataTable tblProducto = new DataTable();
            List<clProductoE> listaP = new List<clProductoE>();

            if (objProdE != null && objProdE.Producto != null)
            {
                consulta = "select * from Producto  where Producto='" + objProdE.Producto + "'";
            }
            else if (objProdE != null && objProdE.Referencia != null)
            {
                consulta = "select * from Producto   where Referencia='" + objProdE.Referencia + "'";
            }
            else if (objProdE != null && objProdE.IdTipoProducto != 0)
            {
                consulta = "select * from Producto  where IdTipo=" + objProdE.IdTipoProducto + "";
            }
            else if (objProdE != null && objProdE.IdPresentacion > 0)
            {
                consulta = "select * from Producto  where IdPresentacion ='" + objProdE.IdPresentacion + "'";
            }
            else if (objProdE != null && objProdE.FechaIngreso != null)
            {
                consulta = "select * from Producto    where FechadeIngreso ='" + objProdE.FechaIngreso + "'";
            }
            else if (objProdE != null && objProdE.Marca != null)
            {
                consulta = "select * from Producto  where Marca='" + objProdE.Marca + "'";
            }

            else
            {
                consulta = "select * from Producto  ";
            }
            tblProducto = objBDsql.mtdSelect(consulta);

            for (int i = 0; i < tblProducto.Rows.Count; i++)
            {
                clProductoE objProductoE = new clProductoE();

                objProductoE.IdProducto = int.Parse(tblProducto.Rows[i][0].ToString());
                objProductoE.Producto = tblProducto.Rows[i][1].ToString();
                objProductoE.FechaIngreso = Convert.ToDateTime(tblProducto.Rows[i][2].ToString());
                objProductoE.FechaVencimiento = Convert.ToDateTime(tblProducto.Rows[i][3].ToString());
                objProductoE.Referencia = tblProducto.Rows[i][4].ToString();
                objProductoE.Color = tblProducto.Rows[i][5].ToString();
                objProductoE.Cantidad = int.Parse(tblProducto.Rows[i][6].ToString());
                objProductoE.Marca = tblProducto.Rows[i][7].ToString();
                objProductoE.Precio = double.Parse(tblProducto.Rows[i][8].ToString());
                objProductoE.IdTipoProducto = int.Parse(tblProducto.Rows[i][9].ToString());
                objProductoE.IdPresentacion = int.Parse(tblProducto.Rows[i][10].ToString());
                
                
                listaP.Add(objProductoE);
            }

            return listaP;

        }
        public int mtdActualizar(clProductoE objProductoE)
        {
            string consulta="";
            if (objProductoE != null && objProductoE.Producto != null)
            {
                consulta = "update Producto set Producto ="+objProductoE.Producto+" where IDProducto='" + objProductoE.IdProducto + "'";
            }
            else if (objProductoE != null && objProductoE.Referencia != null)
            {
                consulta = "update Producto set Referencia =" + objProductoE.Referencia + " where IDProducto='" + objProductoE.IdProducto + "'";
            }
            else if (objProductoE != null && objProductoE.IdTipoProducto != 0)
            {
                consulta = "update Producto set IdTipo =" + objProductoE.IdTipoProducto + " where IDProducto='" + objProductoE.IdProducto + "'";
            }
            else if (objProductoE != null && objProductoE.IdPresentacion > 0)
            {
                consulta = "update Producto set IdPresentacion =" + objProductoE.IdPresentacion + " where IDProducto='" + objProductoE.IdProducto + "'";
            }
            else if (objProductoE != null && objProductoE.FechaIngreso != null)
            {
                consulta = "update Producto set FechadeIngreso =" + objProductoE.FechaIngreso + " where IDProducto='" + objProductoE.IdProducto + "'";
            }
            else if (objProductoE != null && objProductoE.Marca != null)
            {
                consulta = "update Producto set FechadeVencimiento =" + objProductoE.FechaVencimiento + " where IDProducto='" + objProductoE.IdProducto + "'";
            }
            int update = objBDsql.mtdIDU(consulta);
            return update;
        }
    }
}
