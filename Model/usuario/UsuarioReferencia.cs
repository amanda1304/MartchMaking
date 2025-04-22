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

                // Inserir usuário
                string query = "INSERT INTO usuarios (nome, email, senha, data_registro) VALUES (@Nome, @Email, @Senha, @DataRegistro)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senhaHash);
                    cmd.Parameters.AddWithValue("@DataRegistro", DateTime.Now);
                    cmd.ExecuteNonQuery();

                    // Recuperar o ID gerado
                    long idUsuario = cmd.LastInsertedId;

                    // Inserir perfil do usuário
                    string perfilQuery = "INSERT INTO perfil_usuario (id_usuario, nickname, status_descricao) VALUES (@IdUsuario, @Nickname, @Status)";
                    using (MySqlCommand perfilCmd = new MySqlCommand(perfilQuery, conn))
                    {
                        perfilCmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        perfilCmd.Parameters.AddWithValue("@Nickname", nome);
                        perfilCmd.Parameters.AddWithValue("@Status", true);
                        perfilCmd.ExecuteNonQuery();
                    }
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
                            try
                            {
                                Usuario usuario = Usuario.UserFromDataReader(reader);

                                if (usuario == null)
                                {
                                    MessageBox.Show("Erro: objeto usuário está nulo.");
                                    return false;
                                }

                                UserSession.RegisterLoginUser(usuario);
                                return true;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro ao montar objeto Usuario: " + ex.Message);
                                return false;
                            }
                        }
                    }
                }
            }

            return false;
        }
    }


}
