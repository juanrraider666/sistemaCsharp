using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appPinturasV1.Datos;
using appPinturasV1.Entidades;

namespace appPinturasV1.Logica
{
    class clPersonaL
    {
        clPersonaD objPersonaD = new clPersonaD();

        public int mtdValidar(clPersonaE objPersonaE)
        {
            int registros = 0;
            if (objPersonaE.Nombre == "" || objPersonaE.Usuario == "")
            {
                registros = -2;
            }else
            { 

                registros = objPersonaD.mtdRegistrar(objPersonaE);
            }


            return registros;
        }

        List<clPersonaE> lista = new List<clPersonaE>();
        public List<clPersonaE> mtdListarPersona(clPersonaE objPersonaE = null)
        {
            lista = objPersonaD.mtdListar(objPersonaE);
            return lista;
        }

    }
}
