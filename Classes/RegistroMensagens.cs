using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Login_Register
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
