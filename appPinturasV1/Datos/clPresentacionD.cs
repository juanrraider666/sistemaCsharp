using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appPinturasV1.Entidades;
using System.Data;
namespace appPinturasV1.Datos
{
    class clPresentacionD

    {

        clBDSql objBDsql = new clBDSql();
        List<clPresentacionE> listaP = new List<clPresentacionE>();
        public List<clPresentacionE> mtdListar()
        {
            string consulta = "select * from Presentacion";
            DataTable tblPresentacion = new DataTable();
          
           
            tblPresentacion = objBDsql.mtdSelect(consulta);


            for (int i = 0; i < tblPresentacion.Rows.Count; i++)
            {

                clPresentacionE objpreE = new clPresentacionE();
                objpreE.IdPresentacion = int.Parse(tblPresentacion.Rows[i][0].ToString());
                objpreE.Presentacion = tblPresentacion.Rows[i][1].ToString();
                objpreE.descripcion = tblPresentacion.Rows[i][2].ToString();
                listaP.Add(objpreE);
            }

            return listaP;
        }
        public int mtdRegistrarPResentacion(clPresentacionE objPresentacionE)
        {
            string consulta = "insert into Presentacion(Presentacion,Descripcion)" +
                " values (" + objPresentacionE.Presentacion + ",'" + objPresentacionE.descripcion + "')";

            int cantidad = objBDsql.mtdIDU(consulta);
            return cantidad;
        }
    }
}