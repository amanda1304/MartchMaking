using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Register.Model.JogosFavoritos
{
    internal class JogosFavoritos
    {
        public int id_jogo_favorito { get; set; }
        public int id_usuario { get; set; }
        public int id_jogo { get; set; }
        public string nivel_jogos { get; set; }
    }
}
