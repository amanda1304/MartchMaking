using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Register.Classes
{
    internal class EncerrarAplicacao
    {
        public static void FecharAplicacao(object sender, FormClosingEventArgs evento) { 
        
            Application.ExitThread();
        
        }
    }
}
