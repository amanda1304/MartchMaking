using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Register.Model.SugestaoAmizada
{
    public class SugestaoAmizade
    {

        public int id_susgestao { get; set; }
        public int id_usuario_origem { get; set; }
        public int id_usuario_destino { get; set; }  

    }
}
