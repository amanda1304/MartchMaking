using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Register
{
    internal class usuario
    {
        private string usuarioCorreto = "admin";
        private string senhaCorreta = "1234";

        // Método para validar o login
        public bool ValidarLogin(string usuario, string senha)
        {
            return usuario == usuarioCorreto && senha == senhaCorreta;
        }
    }
}
