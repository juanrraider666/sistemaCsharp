using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appPinturasV1.Datos;
using appPinturasV1.Entidades;

namespace appPinturasV1.Logica
{
    class clRolL
    {
        clRolD objRolD = new clRolD();
        List<clRolE> lista = new List<clRolE>();
        public List<clRolE> mtdListar()
        {
            lista = objRolD.mtdListar();
            return lista;
        }
    }
}
