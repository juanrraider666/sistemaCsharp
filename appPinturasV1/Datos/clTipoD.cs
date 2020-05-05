using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using appPinturasV1.Entidades;

namespace appPinturasV1.Datos
{
    class clTipoD
    {
        clBDSql objBDSql = new clBDSql();
        List<clTipoE> lista = new List<clTipoE>();
        public List<clTipoE> mtdListar()
        {
            string consulta = "select * from Tipo";
            DataTable tblTipo = new DataTable();
            tblTipo = objBDSql.mtdSelect(consulta);

            for (int i = 0; i < tblTipo.Rows.Count; i++)
            {
                clTipoE objTipoE = new clTipoE();
                objTipoE.IdTipo = int.Parse(tblTipo.Rows[i][0].ToString());
                objTipoE.Tipo = tblTipo.Rows[i][1].ToString();
                objTipoE.Descripcion = tblTipo.Rows[i][2].ToString();
                lista.Add(objTipoE);
            }
            return lista;
        }

        public int mtdRegistrarTipo(clTipoE objTipoE)
        {
            string consulta = "insert into Tipo(Tipo,Descripcion)" +
                " values ('" + objTipoE.Tipo + "','" + objTipoE.Descripcion + "')";

            int cantidad = objBDSql.mtdIDU(consulta);
            return cantidad;
        }
    }
}
