using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Register.Model.MensagensChat
{
    internal class MensagensChat
    {
        public int id_mesagem { get; set; }
        public int id_chat { get; set; }
        public int id_remetente { get; set; }
        public string mensagem { get; set; }
        public DateTime data_hora  { get; set; }
    }
}
