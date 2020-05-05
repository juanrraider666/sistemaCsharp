using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appPinturasV1.Datos;
using appPinturasV1.Entidades;

namespace appPinturasV1.Logica
{
    class clPresentacionL
    {
        clPresentacionD objPresentacionD = new clPresentacionD();
        List<clPresentacionE> lista = new List<clPresentacionE>();
        public List<clPresentacionE> mtdListar()
        {
            lista = objPresentacionD.mtdListar();
            return lista;
        }
        public int mtdValidarPresentacion(clPresentacionE objPresentacionE)
        {
            int registros = 0;
            if (objPresentacionE.Presentacion == "")
            {
                registros = -2;
            }
            else
            {

                registros = objPresentacionD.mtdRegistrarPResentacion(objPresentacionE);
            }


            return registros;
        }
    }
}
