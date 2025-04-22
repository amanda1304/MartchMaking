using Login_Register.Model.PerfilUsuario;
using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

public class PerfilUsuarioDAO
{

    //private readonly string connectionString;
    private DatabaseService dbService;

    /*public PerfilUsuarioDAO(string conn)
    {
        connectionString = conn;
    }*/

    public PerfilUsuarioDAO(DatabaseService dbService)
    {
        this.dbService = dbService;
    }

    public PerfilUsuario ObterPerfilPorUsuario(int idUsuario)
    {
        PerfilUsuario perfil = null;

        using (MySqlConnection conn = dbService.GetConnection())
        {
            conn.Open();
            string query = "SELECT * FROM perfil_usuario WHERE id_usuario = @idUsuario";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    perfil = new PerfilUsuario
                    {
                        IdPerfilUsuario = reader.GetInt32(reader.GetOrdinal("id_perfilusuario")),
                        IdUsuario = reader.GetInt32(reader.GetOrdinal("id_usuario")),
                        Nickname = reader["nickname"]?.ToString(),
                        HorarioJogo = reader["horario_jogo"] as DateTime?,
                        Descricao = reader["descricao"]?.ToString(),
                        StatusDescricao = Convert.ToBoolean(reader["status_descricao"])
                    };

                    // AQUI SIM o objeto já foi criado e podemos acessar a propriedade
                    MessageBox.Show("ID do perfil do usuário: " + perfil.IdPerfilUsuario);
                }
            }
        }

        return perfil;
    }

}

