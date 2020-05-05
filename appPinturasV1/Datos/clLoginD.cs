using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using appPinturasV1.Entidades;

namespace appPinturasV1.Datos
{
    class clLoginD
    {
        clBDSql objBDSql = new clBDSql();

        public List<clLoginE> mtdiniciar(clLoginE objLoginE)
        {

            

            DataTable tblUsuario = new DataTable();
            string consulta = ("select IDRol,Nombre,Apellido from Persona where Usuario = '" + objLoginE.usuario + "' and Contraseña = '" + objLoginE.Contraseña + "'");
            tblUsuario = objBDSql.mtdSelect(consulta);
            List<clLoginE> log = new List<clLoginE>();
            
                objLoginE.Id = int.Parse(tblUsuario.Rows[0][0].ToString());
                objLoginE.Nombre = tblUsuario.Rows[0][1].ToString();
                objLoginE.Apellido = tblUsuario.Rows[0][2].ToString();
                log.Add(objLoginE);
                
            
            return log;

        }

    }
}
