using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_Register.Model.Usuario;

namespace Login_Register.Model.Services
{
    public static class UserSession
    {
        public static usuario userLogado { get; set; }

        public static void RegisterLoginUser(usuario usuario) { 
        
            userLogado = usuario;
           // MessageBox.Show(userLogado.nome);
        
        }

    }
}
