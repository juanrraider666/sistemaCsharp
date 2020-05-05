using appPinturasV1.Datos;
using appPinturasV1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPinturasV1.Logica
{
    class clTipoL
    {
        clTipoD objTipoD = new clTipoD();
        List<clTipoE> lista = new List<clTipoE>();
        public List<clTipoE> mtdListar()
        {
            lista = objTipoD.mtdListar();
            return lista;
        }

        public int mtdValidatIPO(clTipoE objTipoE)
        {
            int registros = 0;
            if (objTipoE.Tipo == "")
            {
                registros = -2;
            }
            else
            {

                registros = objTipoD.mtdRegistrarTipo(objTipoE);
            }


            return registros;
        }
    }

}
