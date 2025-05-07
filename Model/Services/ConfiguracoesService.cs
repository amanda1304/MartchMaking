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
    public Image CarregarCorFundo(int idUsuario)
    {
        try
        {
            var perfilDAO = new PerfilUsuarioDAO(new DatabaseService());
            var perfil = perfilDAO.ObterPerfilPorUsuario(idUsuario);

            var configDAO = new ConfiguracoesDAO(new DatabaseService());
            var config = configDAO.ObterPorIdPerfilUsuario(perfil.IdPerfilUsuario);

            if (!string.IsNullOrEmpty(config.cor_fundo))
            {
                return (Image)Login_Register.Properties.Resources.ResourceManager.GetObject(config.cor_fundo);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao carregar imagem de fundo: " + ex.Message);
        }

        return null;
    }
  public bool SalvarCorFundo(int idUsuario, string nomeImagemFundo)
{
    // Validação dos parâmetros de entrada
    if (idUsuario <= 0)
    {
        MessageBox.Show("ID do usuário inválido");
        return false;
    }

    if (string.IsNullOrWhiteSpace(nomeImagemFundo))
    {
        MessageBox.Show("Nome da imagem de fundo não pode ser vazio");
        return false;
    }

    try
    {
        var perfilDAO = new PerfilUsuarioDAO(new DatabaseService());
        var perfil = perfilDAO.ObterPerfilPorUsuario(idUsuario);

        // Verifica se o perfil foi encontrado
        if (perfil == null)
        {
            MessageBox.Show("Perfil do usuário não encontrado");
            return false;
        }

        var configDAO = new ConfiguracoesDAO(new DatabaseService());
        bool atualizado = configDAO.AtualizarCorFundo(perfil.IdPerfilUsuario, nomeImagemFundo);

        if (!atualizado)
        {
            MessageBox.Show("Não foi possível atualizar a cor de fundo");
            return false;
        }

        return true;
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Erro ao salvar imagem de fundo: {ex.Message}");
        return false;
    }
}
    public void SalvarTema(int idUsuario, string bandeira, string borda, string menu)
    {
        try
        {
            var perfilDAO = new PerfilUsuarioDAO(new DatabaseService());
            var perfil = perfilDAO.ObterPerfilPorUsuario(idUsuario);

            var configDAO = new ConfiguracoesDAO(new DatabaseService());

            // Verifica se já existem configurações para esse perfil
            var configuracaoAtual = configDAO.ObterPorIdPerfilUsuario(perfil.IdPerfilUsuario);

            if (configuracaoAtual != null)
            {
                // Verifica se houve alteração
                if (configuracaoAtual.bandeiras != bandeira || configuracaoAtual.bordas != borda || configuracaoAtual.menu != menu)
                {
                    configDAO.AtualizarTema(perfil.IdPerfilUsuario, bandeira, borda, menu);
                    MessageBox.Show("Tema atualizado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhuma alteração foi feita.");
                }
            }
            else
            {
                // Não existia ainda: inserir novo registro
                configDAO.InserirTema(perfil.IdPerfilUsuario, bandeira, borda, menu);
                MessageBox.Show("Tema salvo com sucesso!");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao salvar o tema: " + ex.Message + "\n" + ex.StackTrace);
        }
    }



}







