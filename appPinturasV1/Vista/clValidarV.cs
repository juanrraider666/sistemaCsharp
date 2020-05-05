using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appPinturasV1.Logica
{
    class clValidarV
    {
        public static void soloNumeros (KeyPressEventArgs V)
        {
            if (Char.IsDigit(V.KeyChar))              
            {
                V.Handled = false;
            }
            else if (Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsControl(V.KeyChar))
            {
                V.Handled = false;

            }
            else
            {
                V.Handled = true;
                MessageBox.Show("solo Numeros");
            }
   
        }
        public static void soloLetras(KeyPressEventArgs V)
        {
             if (Char.IsLetter(V.KeyChar))              
            {
                V.Handled = false;
            }
            else if (Char.IsSeparator(V.KeyChar))
            {
                V.Handled = false;
            }
            else if (Char.IsControl(V.KeyChar))
            {
                V.Handled = false;
            }
            else
            {
                V.Handled = true;
                MessageBox.Show("solo Letras");
            }

        }
       
    }
}
