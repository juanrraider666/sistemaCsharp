using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appPinturasV1.Datos;
using appPinturasV1.Entidades;

namespace appPinturasV1.Logica
{
    class clProductoL
    {
        clProductoD objProductoD = new clProductoD();

        public int mtdValidar(clProductoE objProductoE)
        {
            int registros = 0;

            if (objProductoE.Producto=="" || objProductoE.Referencia=="" || objProductoE.Precio==0)
            {
                registros = -2;
            }
            else
            {
                registros = objProductoD.mtdRegistrar(objProductoE);
            }

            return registros;

        }


        List<clProductoE> listal = new List<clProductoE >();

        public List<clProductoE> mtdListarProducto(clProductoE objProductoE = null)
        {
            listal = objProductoD.mtdListar(objProductoE);
                return listal;
        }
        public int mtdActualizar(clProductoE objProductoE)
        {
            int consulta = objProductoD.mtdActualizar(objProductoE);
            return consulta;
        }
    }
}
