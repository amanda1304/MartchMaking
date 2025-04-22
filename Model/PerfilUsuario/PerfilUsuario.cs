using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Register.Model.PerfilUsuario
{
        public class PerfilUsuario
        {
            public int IdPerfilUsuario { get; set; }
            public int IdUsuario { get; set; }
            public string Nickname { get; set; }
            public DateTime? HorarioJogo { get; set; }
            public string Descricao { get; set; }
            public bool StatusDescricao { get; set; }
        }

    
}
