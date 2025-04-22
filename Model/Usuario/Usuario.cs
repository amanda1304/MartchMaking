using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Login_Register.Model.Usuario
{
    public class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public DateTime data_registro { get; set; }

        public static Usuario UserFromDataReader(MySqlDataReader reader)
        {

            return new Usuario
            {
                id = Convert.ToInt32(reader["id_usuario"].ToString()),
                nome = reader["nome"].ToString(),
                email = reader["email"].ToString(),
                senha = reader["senha"].ToString(),
                data_registro = Convert.ToDateTime(reader["data_registro"].ToString()),



            };


        }
    }
}