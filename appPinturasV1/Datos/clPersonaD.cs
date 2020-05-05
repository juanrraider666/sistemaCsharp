using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appPinturasV1.Entidades;
using System.Data;
using appPinturasV1.Vista;

namespace appPinturasV1.Datos
{
    class clPersonaD
    {
        clBDSql objBDSql = new clBDSql();
        clPersonaE objPersonaE = new clPersonaE();
        clRolE objRolE = new clRolE();
        public int mtdRegistrar(clPersonaE objPersonaE)
        {
            string consulta = "insert into Persona(Documento,Nombre,Apellido,Usuario,Contraseña,IdRol)" +
                " values (" + objPersonaE.Documento + ",'" + objPersonaE.Nombre + "','" + objPersonaE.Apellido +
                "','" + objPersonaE.Usuario + "','" + objPersonaE.Contraseña + "'," + objPersonaE.IdRol + ")";

            int cantidad = objBDSql.mtdIDU(consulta);
            return cantidad;
        }

        /// <summary>
        /// Metodo para listar las Personas Registradas
        /// </summary>
        /// <returns></returns>

        public List<clPersonaE> mtdListar(clPersonaE objPersonaE)
        {
            string consulta = "";
            DataTable tblPersona = new DataTable();
            List<clPersonaE> listaPers = new List<clPersonaE>();

            if (objPersonaE != null && objPersonaE.Documento != null)
            {
                consulta = "select Documento,Nombre,Apellido,Usuario,contraseña,Persona.IdRol,Rol from Persona inner join Rol on Persona.IdRol = Rol.IdRol where Documento='" + objPersonaE.Documento + "'";
            }
            else if (objPersonaE != null && objPersonaE.Nombre != null)
            {
                consulta = "select Documento,Nombre,Apellido,Usuario,contraseña,Persona.IdRol,Rol from Persona inner join Rol on Persona.IdRol = Rol.IdRol where Nombre='" + objPersonaE.Nombre + "'";
            }
            else if (objPersonaE != null && objPersonaE.Apellido != null)
            {
                consulta = "select Documento,Nombre,Apellido,Usuario,contraseña,Persona.IdRol,Rol from Persona inner join Rol on Persona.IdRol = Rol.IdRol where Apellido='" + objPersonaE.Apellido + "'";
            }
            else if (objPersonaE != null && objPersonaE.Usuario != null)
            {
                consulta = "select Documento,Nombre,Apellido,Usuario,contraseña,Persona.IdRol,Rol from Persona inner join Rol on Persona.IdRol = Rol.IdRol where Usuario='" + objPersonaE.Usuario + "'";
            }
            else if (objPersonaE != null && objPersonaE.Contraseña !=null)
            {
                consulta = "select Documento,Nombre,Apellido,Usuario,contraseña,Persona.IdRol,Rol from Persona inner join Rol on Persona.IdRol = Rol.IdRol where Contraseña=" + objPersonaE.Contraseña + "";
            }

            else if (objPersonaE != null && objPersonaE.IdRol != 0)
            {
                consulta = "select Documento,Nombre,Apellido,Usuario,contraseña,Persona.IdRol,Rol from Persona inner join Rol on Persona.IdRol = Rol.IdRol where Persona.IdRol=" + objPersonaE.IdRol+ "";
            }

            else
            {
                consulta = "select Documento,Nombre,Apellido,Usuario,contraseña,Persona.IdRol,Rol from Persona inner join Rol on Persona.IdRol = Rol.IdRol";
            }

            tblPersona = objBDSql.mtdSelect(consulta);
            clVentaE objVentaE = new clVentaE();
            for (int i = 0; i < tblPersona.Rows.Count; i++)
            {
                clPersonaE objPersonaeE = new clPersonaE();
                objPersonaeE.Documento = tblPersona.Rows[i][0].ToString();
                objPersonaeE.Nombre = tblPersona.Rows[i][1].ToString();
                objPersonaeE.Apellido = tblPersona.Rows[i][2].ToString();
                objPersonaeE.Usuario = tblPersona.Rows[i][3].ToString();
                objPersonaeE.Contraseña = tblPersona.Rows[i][4].ToString();
                objPersonaeE.IdRol = int.Parse(tblPersona.Rows[i][5].ToString());
                objPersonaeE.Rol = tblPersona.Rows[i][6].ToString();
                listaPers.Add(objPersonaeE);
            }
            
            return listaPers;

        }
    }
}
