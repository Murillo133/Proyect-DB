using BOL;
using ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    class UtilGui
    {
        public static int Msj(string advertencia, string tipoMensaje)
        {
            DialogResult oDlgRes;
            oDlgRes = MessageBox.Show(advertencia, tipoMensaje,
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (oDlgRes == DialogResult.Yes)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

   


        public static void ActualizarCuentas()
        {
            try
            {
               
            }
            catch (Exception )
            {
               
            }
            
        }

    }
}
