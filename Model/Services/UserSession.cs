using Login_Register.Model.Usuario;
using System.Windows.Forms;
using System;

public static class UserSession
{
    public static Usuario userLogado { get; set; }
    public static int IdPerfilUsuario { get; set; } // <--- nova propriedade

    public static void RegisterLoginUser(Usuario usuario)
    {
        userLogado = usuario;
        MessageBox.Show("ID do usuário: " + UserSession.userLogado.id);

        // Após logar, buscamos o ID do perfil do usuário
        try
        {
            var perfilDAO = new PerfilUsuarioDAO(new DatabaseService());
            var perfil = perfilDAO.ObterPerfilPorUsuario(usuario.id);

            if (perfil != null)
            {
                IdPerfilUsuario = perfil.IdPerfilUsuario;
            }
            else
            {
                MessageBox.Show("Perfil do usuário não encontrado.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao obter o perfil do usuário: " + ex.Message);
        }
    }
}

