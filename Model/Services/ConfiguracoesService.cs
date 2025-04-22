using MySql.Data.MySqlClient;
using System.Configuration;
using Login_Register.Model.Configuracoes;
using System.Drawing;
using System.Windows.Forms;
using System;

public class ConfiguracoesService
{
    private ConfiguracoesDAO dao;

    public ConfiguracoesService()
    {
        dao = new ConfiguracoesDAO(new DatabaseService());
    }

    public Image CarregarAvatar(int idUsuario)
        {
            PerfilUsuarioDAO perfilDAO = new PerfilUsuarioDAO(new DatabaseService());
            var perfil = perfilDAO.ObterPerfilPorUsuario(idUsuario);

            if (perfil != null)
            {
                var config = dao.ObterPorIdPerfilUsuario(perfil.IdPerfilUsuario);
                if (config != null && !string.IsNullOrEmpty(config.avatar_perfil))
                {
                    return (Image)Login_Register.Properties.Resources.ResourceManager.GetObject(config.avatar_perfil);
                }
            }

            return null;
        }

    public bool SalvarAvatar(int idUsuario, string nomeAvatar)
    {
        try
        {
            PerfilUsuarioDAO perfilDAO = new PerfilUsuarioDAO(new DatabaseService());
            var perfil = perfilDAO.ObterPerfilPorUsuario(idUsuario);

            if (perfil != null)
            {
                var configExistente = dao.ObterPorIdPerfilUsuario(perfil.IdPerfilUsuario);

                if (configExistente == null)
                {
                    dao.InserirConfiguracao(perfil.IdPerfilUsuario, nomeAvatar);
                    return true;
                }

                return dao.AtualizarAvatarPerfil(perfil.IdPerfilUsuario, nomeAvatar);
            }

            return false;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao salvar avatar: " + ex.Message + "\n\n" + ex.StackTrace);
            return false; 
            
        }
    }

}







