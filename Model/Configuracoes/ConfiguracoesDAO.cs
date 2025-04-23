using System;
using MySql.Data.MySqlClient;
using System.Configuration;
using Login_Register.Model.Configuracoes;
using System.Windows.Forms;
using Login_Register.Model.Usuario;

public class ConfiguracoesDAO
{

    private string connectionString;

    public ConfiguracoesDAO(DatabaseService databaseService)
    {
        // Usa a connection string do DatabaseService corretamente
        connectionString = databaseService.GetConnection().ConnectionString;
    }
    public Configuracoes ObterPorIdPerfilUsuario(int idPerfilUsuario)
    {
        Configuracoes config = null;

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT * FROM configuracoes WHERE id_perfil_usuario = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", idPerfilUsuario);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    config = new Configuracoes
                    {
                        id_Config = (int)reader["id_config"],
                        cor_fundo = reader["cor_fundo"].ToString(),
                        bandeiras = reader["bandeiras"].ToString(),
                        avatar_perfil = reader["avatar_perfil"].ToString(),
                        id_perfilusuario = (int)reader["id_perfil_usuario"],
                        bordas = reader["bordas"].ToString(),
                        menu = reader["menu"].ToString()
                    };
                }
            }
        }

        return config;
    }


 
       public bool AtualizarAvatarPerfil(int idPerfilUsuario, string avatar)
    {
        try
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MessageBox.Show("Conexão com o banco aberta com sucesso.");

                string query = "UPDATE configuracoes SET avatar_perfil = @avatar WHERE id_perfil_usuario = @id_perfil_usuario";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@avatar", avatar);
                cmd.Parameters.AddWithValue("@id_perfil_usuario", idPerfilUsuario);

                MessageBox.Show($"Executando query para id_perfil_usuario = {idPerfilUsuario} com avatar = {avatar}");

                int rows = cmd.ExecuteNonQuery();

                MessageBox.Show($"Linhas afetadas: {rows}");

                return rows > 0;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao salvar avatar: " + ex.Message);
            return false;
        }
    }
    public void InserirConfiguracao(int idPerfilUsuario, string avatar)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "INSERT INTO configuracoes (id_perfil_usuario, avatar_perfil) VALUES (@id, @avatar)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", idPerfilUsuario);
            cmd.Parameters.AddWithValue("@avatar", avatar);
            cmd.ExecuteNonQuery();
        }
    }
    public void AtualizarCorFundo(int idPerfilUsuario, string nomeImagemFundo)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "UPDATE configuracoes SET cor_fundo = @nome WHERE id_perfil_usuario = @idPerfil";
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@nome", nomeImagemFundo);
                cmd.Parameters.AddWithValue("@idPerfil", idPerfilUsuario);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void AtualizarTema(int idPerfilUsuario, string bandeira, string borda, string menu)
    {
        using (var conexao = new MySqlConnection(connectionString))
        {
            conexao.Open();

            string query = @"UPDATE configuracoes 
                         SET bandeiras = @bandeira, bordas = @borda, menu = @menu 
                         WHERE id_perfil_usuario = @idPerfil";

            using (var cmd = new MySqlCommand(query, conexao))
            {
                cmd.Parameters.AddWithValue("@bandeira", bandeira);
                cmd.Parameters.AddWithValue("@borda", borda);
                cmd.Parameters.AddWithValue("@menu", menu);
                cmd.Parameters.AddWithValue("@idPerfil", idPerfilUsuario);

                cmd.ExecuteNonQuery();
            }
        }
    }



}
