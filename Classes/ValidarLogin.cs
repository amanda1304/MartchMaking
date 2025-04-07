using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Register
{
    internal class ValidarLogin
    {
        public bool Validar(string usuario, string senha)
        {
            return usuario == "projeto" && senha == "1234";
        }
    }
}
