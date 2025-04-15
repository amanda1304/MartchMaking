using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Configuration;
using Login_Register.Model.Usuario;
using MySql.Data.MySqlClient;
using Login_Register.Model.Services;


namespace Login_Register.Model.Usuario
{
    public class UsuarioReferencia
    {

        private readonly DatabaseService _dbService;

        public UsuarioReferencia()
        {
            _dbService = new DatabaseService();
        }
       
        public bool UsuarioExiste(string email)
        {
            using (MySqlConnection conn = _dbService.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM usuarios WHERE email = @Email";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public void RegistrarUsuario(string nome, string email, string senha)
        {
            if (UsuarioExiste(email))
            {
                MessageBox.Show("Usuário já registrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string senhaHash = Criptografia.GerarHash(senha);

            using (MySqlConnection conn = _dbService.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO usuarios (nome, email, senha ) VALUES (@Nome, @Email, @Senha)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senhaHash);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Usuário registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool FazerLogin(string email, string senha)
        {

            string senhaHash = Criptografia.GerarHash(senha);


            using (MySqlConnection conn = _dbService.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM usuarios WHERE email = @Email AND senha = @Senha";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senhaHash);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Aqui pode usar o método UserFromDataReader
                            usuario usuario = usuario.UserFromDataReader(reader);
                            UserSession.RegisterLoginUser(usuario);

                            return true;
                          
                        }
                    }
                }
            }

            return false;
        }
    }


}
