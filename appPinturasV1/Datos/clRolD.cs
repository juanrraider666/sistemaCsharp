using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using appPinturasV1.Entidades;

namespace appPinturasV1.Datos
{
    class clRolD
    {
        clBDSql objBDSql = new clBDSql();
        List<clRolE> Roles = new List<clRolE>();
        public List<clRolE> mtdListar()
        {
            string consulta = "select * from Rol";
            DataTable tblRol = new DataTable();
            tblRol = objBDSql.mtdSelect(consulta);

            for (int i = 0; i < tblRol.Rows.Count; i++)
            {
                clRolE objRolE = new clRolE();
                objRolE.IDRol = int.Parse(tblRol.Rows[i][0].ToString());
                objRolE.Rol = tblRol.Rows[i][1].ToString();
                Roles.Add(objRolE);
            }
            return Roles;
        }
    }
}
