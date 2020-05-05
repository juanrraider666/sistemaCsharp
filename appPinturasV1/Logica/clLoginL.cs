using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appPinturasV1.Entidades;
using appPinturasV1.Datos;
using System.Windows.Forms;
namespace appPinturasV1.Logica
{
    class clLoginL
    {
        // clLoginE objLoginE = new clLoginE();
        clLoginD objLoginD = new clLoginD();
        
        List<clLoginE> log = new List<clLoginE>();
        public List<clLoginE> mtdIngreso(clLoginE objLoginE)
        {


            if (objLoginE.usuario == "" || objLoginE.Contraseña == "")
            {
                MessageBox.Show  ("Datos Nulos","Error al iniciar sesión");
            }
            else
            {
                
                log =objLoginD.mtdiniciar(objLoginE);
                

            }
            return log;

        }
    }
}
