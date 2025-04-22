using System;
using MySql.Data.MySqlClient;

public static class AvatarManager
{
    /*public static string AvatarSelecionado { get; private set; }
    public static int IdPerfilUsuario { get; set; }

    public static void SelecionarAvatar(string nomeAvatar)
    {
        AvatarSelecionado = nomeAvatar;
    }

    public static bool SalvarAvatar(string connectionString)
    {
        if (string.IsNullOrEmpty(AvatarSelecionado) || IdPerfilUsuario == 0)
            return false;

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "UPDATE configuracoes SET avatar_perfil = @avatar WHERE id_perfil_usuario = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@avatar", AvatarSelecionado);
                cmd.Parameters.AddWithValue("@id", IdPerfilUsuario);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }

    public static string CarregarAvatar(string connectionString)
    {
        if (IdPerfilUsuario == 0)
            return null;

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT avatar_perfil FROM configuracoes WHERE id_perfil_usuario = @id";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", IdPerfilUsuario);
                object result = cmd.ExecuteScalar();
                AvatarSelecionado = result?.ToString();
                return AvatarSelecionado;
            }
        }
    }*/
}

