using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Register.Classes
{
    internal class RegistroMensagens
    {

        public string Mensagem { get; set; }
        public string Tipo { get; set; }  // Pode ser "erro" ou "sucesso"

        public RegistroMensagens(string mensagem, string tipo)
        {
            Mensagem = mensagem;
            Tipo = tipo;
        }
    }
}
