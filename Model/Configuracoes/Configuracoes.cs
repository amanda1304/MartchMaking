using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Login_Register.Model.Configuracoes
{
    public class Configuracoes
    {
        public int id_Config { get; set; }
        public string cor_fundo { get; set; }
        public string bandeiras { get; set; }
        public string avatar_perfil { get; set; }
        public string bordas { get; set; }
        public string menu { get; set; }
        public int id_perfilusuario { get; set; }
    }
}
