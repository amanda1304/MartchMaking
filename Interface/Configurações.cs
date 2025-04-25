using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_Register.Model.PerfilUsuario;
using Login_Register.Model.Services;
using Login_Register.Model.Usuario;
using MySql.Data.MySqlClient;
namespace Login_Register
{
    
    public partial class Configurações : Form
    {
        ConfiguracoesService configService = new ConfiguracoesService();
        
        string imagemSelecionada = "";
        string imagemCorFundoSelecionada;
        int idUsuario = 1; // aqui você coloca o ID real do usuário logado

        string nomeBandeiraSelecionada;
        string nomeBordaSelecionada;
        string nomeMenuSelecionado;

        public Configurações()
        {
            InitializeComponent();
            
        }
        int TogMove;
        int MValX;
        int MValY;

        private void Configurações_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void Configurações_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void Configurações_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil perfil = new Perfil();
            perfil.Show();
        }

        private void btnSimbolos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Jogos TelaJogos = new Jogos();
            TelaJogos.Show();
        }

        private void btnAmigos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Amigos TelaAmigos = new Amigos();
            TelaAmigos.Show();
        }

        private void btnMatchMaking_Click(object sender, EventArgs e)
        {
            this.Hide();
            MatchMaking TelaMatch = new MatchMaking();
            TelaMatch.Show();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configurações Telaconfig = new Configurações();
            Telaconfig.Show();
        }

        private void btnMatchMakingLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            TelaInicial TelaInicial = new TelaInicial();
            TelaInicial.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            {
                DialogResult resultado = MessageBox.Show(
                    "Tem certeza que deseja sair?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    // Abre outro formulário
                    Login_Register loginregister = new Login_Register(); // substitua pelo seu form
                    loginregister.Show();

                    // Fecha o formulário atual
                    this.Close();
                }
            }
        }

        private void btnFecharTelaInicial_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                   "Tem certeza que deseja sair?",
                   "Confirmação",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question
               );

            if (resultado == DialogResult.Yes)
            {


                // Fecha o formulário atual
                this.Close();
            }
        }
        

        private void btnMinimizarTelaInicial_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            Opacity += .2;
        }

        private void Configurações_Load(object sender, EventArgs e)
        {
            timer5.Start();

            Image avatar = configService.CarregarAvatar(UserSession.userLogado.id);
            if (avatar != null)
            {
                pictureBoxPerfil.Image = avatar;
            }

            Image fundo = configService.CarregarCorFundo(UserSession.userLogado.id);
            if (fundo != null)
            {
                pictureBoxFotodeFundoAtual.Image = fundo;
            }

            // Aqui: carregando nome do usuário no TextBox
            textBox1.Text = UserSession.userLogado.nome;

            // Opcional: se quiser também puxar dados do perfil
            PerfilUsuarioDAO perfilDAO = new PerfilUsuarioDAO(new DatabaseService());
            PerfilUsuario perfil = perfilDAO.ObterPerfilPorUsuario(this.idUsuario);

            if (perfil != null)
            {
                textBox1.Text = perfil.Nickname;
                // ou outros campos, como descricao etc
            }
        }

        private void SelecionarAvatar(string nomeAvatar)
        {
            imagemSelecionada = nomeAvatar;
            pictureBoxPerfil.Image = (Image)Properties.Resources.ResourceManager.GetObject(nomeAvatar);
        }
        private void SelecionarCorFundo(string nomeImagemFundo)
        {
            imagemCorFundoSelecionada = nomeImagemFundo;

            // Define a imagem de fundo no formulário
            pictureBoxFotodeFundoAtual.Image = (Image)Properties.Resources.ResourceManager.GetObject(nomeImagemFundo);
            //this.BackgroundImageLayout = ImageLayout.Stretch;

            // Salva no banco
            configService.SalvarCorFundo(UserSession.userLogado.id, nomeImagemFundo);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("_26");
            pictureBoxPerfil.Image = Properties.Resources._26;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("_25");
            pictureBoxPerfil.Image = Properties.Resources._25;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("_23");
            pictureBoxPerfil.Image = Properties.Resources._23;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string novoNome = textBox1.Text.Trim();
            btnSalvarAlterações1.Enabled = !string.IsNullOrEmpty(novoNome);
        
        }

        private void btnFotodePerfil1_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("_22");
            pictureBoxPerfil.Image = Properties.Resources._22;
        }

        private void btnFotodePerfil3_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("_24");
            pictureBoxPerfil.Image = Properties.Resources._24;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
           
        }

        private void btnSalvarAlterações1_Click(object sender, EventArgs e)
        {
            bool algoFoiAlterado = false;
            bool sucessoGeral = true;
            string mensagem = "";

            // 1. Atualizar nome se foi modificado
            string novoNome = textBox1.Text.Trim();
            if (novoNome != UserSession.userLogado.nome)
            {
                if (!string.IsNullOrEmpty(novoNome))
                {
                    var usuarioDAO = new UsuarioReferencia(new DatabaseService());
                    bool nomeAtualizado = usuarioDAO.AtualizarNome(UserSession.userLogado.id, novoNome);

                    if (nomeAtualizado)
                    {
                        UserSession.userLogado.nome = novoNome;
                        algoFoiAlterado = true;
                    }
                    else
                    {
                        sucessoGeral = false;
                        mensagem += "Erro ao atualizar o nome.\n";
                    }
                }
                else
                {
                    sucessoGeral = false;
                    mensagem += "O nome não pode estar vazio.\n";
                    textBox1.Text = UserSession.userLogado.nome; // Restaura o nome original
                }
            }

            // 2. Atualizar avatar se foi selecionado
            if (!string.IsNullOrEmpty(imagemSelecionada))
            {
                bool avatarAtualizado = configService.SalvarAvatar(UserSession.userLogado.id, imagemSelecionada);

                if (avatarAtualizado)
                {
                    algoFoiAlterado = true;
                }
                else
                {
                    sucessoGeral = false;
                    mensagem += "Erro ao atualizar avatar.\n";
                }
            }

            // 3. Atualizar fundo se foi selecionado
            if (!string.IsNullOrEmpty(imagemCorFundoSelecionada))
            {
                bool fundoAtualizado = configService.SalvarCorFundo(UserSession.userLogado.id, imagemCorFundoSelecionada);

                if (fundoAtualizado)
                {
                    algoFoiAlterado = true;
                }
                else
                {
                    sucessoGeral = false;
                    mensagem += "Erro ao atualizar fundo.\n";
                }
            }

            // Feedback para o usuário
            if (algoFoiAlterado)
            {
                if (sucessoGeral)
                {
                    MessageBox.Show("Alterações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Algumas alterações não puderam ser salvas:\n" + mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nenhuma alteração foi feita.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFotodePerfil6_Click(object sender, EventArgs e)
        {
            
            SelecionarAvatar("Ellipse_40");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_40;
        }

        private void btnFotodePerfil7_Click(object sender, EventArgs e)
        {
           SelecionarAvatar("Ellipse_39");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_39;
        }

        private void btnFotodePerfil8_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("Ellipse_38");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_38;
        }

        private void btnFotodePerfil9_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("_27");
            pictureBoxPerfil.Image = Properties.Resources._27;
        }

        private void btnFotodePerfil10_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("_28");
            pictureBoxPerfil.Image = Properties.Resources._28;
        }

        private void btnFotodePerfil11_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("_29");
            pictureBoxPerfil.Image = Properties.Resources._29;
        }

        private void btnFotodePerfil12_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("_30");
            pictureBoxPerfil.Image = Properties.Resources._30;
        }

        private void btnFotodePerfil13_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("_31");
            pictureBoxPerfil.Image = Properties.Resources._31;
        }


        private void btnFotodePerfil15_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("Ellipse_36");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_36;
        }

        private void btnFotodePerfil17_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("_32");
            pictureBoxPerfil.Image = Properties.Resources._32;
        }

        private void btnFotodePerfil18_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("_33");
            pictureBoxPerfil.Image = Properties.Resources._33;
        }

        private void btnFotodePerfil19_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("_34");
            pictureBoxPerfil.Image = Properties.Resources._34;
        }

        private void btnFotodePerfil20_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("_35");
            pictureBoxPerfil.Image = Properties.Resources._35;
        }

        private void btnFotodePerfil21_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("_37");
            pictureBoxPerfil.Image = Properties.Resources._37;
        }
        private void btnFotodePerfil25_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("_38");
            pictureBoxPerfil.Image = Properties.Resources._38;
        }

        private void btnFotodePerfil26_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("_39");
            pictureBoxPerfil.Image = Properties.Resources._39;
        }

        private void btnFotodePerfil27_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("_36");
            pictureBoxPerfil.Image = Properties.Resources._36;
        }

        private void btnFotodePerfil28_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("_40");
            pictureBoxPerfil.Image = Properties.Resources._40;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("Ellipse_37");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_37;
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            SelecionarAvatar("Ellipse_35");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_35;
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            SelecionarAvatar("Ellipse_34");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_34;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("Ellipse_33");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_33;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("Ellipse_32");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_32;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("Ellipse_31");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_31;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("Ellipse_30");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_30;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("Ellipse_29");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_29;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("Ellipse_45");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_45;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("Ellipse_44");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_44;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("Ellipse_43");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_43;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("Ellipse_42");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_42;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("Ellipse_41");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_41;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("Ellipse_28");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_28;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("Ellipse_27");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_27;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            SelecionarAvatar("Ellipse_26");
            pictureBoxPerfil.Image = Properties.Resources.Ellipse_26;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SelecionarAvatar("_41");
            pictureBoxPerfil.Image = Properties.Resources._41;
        }

        private void btnFundo1_Click(object sender, EventArgs e)
        {
            SelecionarCorFundo("Group_15");
            pictureBoxFotodeFundoAtual.Image = Properties.Resources.Group_15;
        }

        private void btnFundo7_Click(object sender, EventArgs e)
        {
            SelecionarCorFundo("Group_35");
            pictureBoxFotodeFundoAtual.Image = Properties.Resources.Group_35;
        }

        private void btnFundo2_Click(object sender, EventArgs e)
        {
            SelecionarCorFundo("Group_51");
            pictureBoxFotodeFundoAtual.Image = Properties.Resources.Group_51;
        }

        private void btnFundo8_Click(object sender, EventArgs e)
        {
            SelecionarCorFundo("Group_42");
            pictureBoxFotodeFundoAtual.Image = Properties.Resources.Group_42;
        }

        private void btnFundo3_Click(object sender, EventArgs e)
        {
            SelecionarCorFundo("Group_44");
            pictureBoxFotodeFundoAtual.Image = Properties.Resources.Group_44;
        }

        private void btnFundo9_Click(object sender, EventArgs e)
        {
            SelecionarCorFundo("Group_50");
            pictureBoxFotodeFundoAtual.Image = Properties.Resources.Group_50;
        }

        private void btnFundo4_Click(object sender, EventArgs e)
        {
            SelecionarCorFundo("Group_45");
            pictureBoxFotodeFundoAtual.Image = Properties.Resources.Group_45;
        }

        private void btnFundo10_Click(object sender, EventArgs e)
        {
            SelecionarCorFundo("Group_47");
            pictureBoxFotodeFundoAtual.Image = Properties.Resources.Group_47;
        }

        private void btnFundo5_Click(object sender, EventArgs e)
        {
            SelecionarCorFundo("Group_46");
            pictureBoxFotodeFundoAtual.Image = Properties.Resources.Group_46;
        }

        private void btnFundo11_Click(object sender, EventArgs e)
        {
            SelecionarCorFundo("Group_43");
            pictureBoxFotodeFundoAtual.Image = Properties.Resources.Group_43;
        }

        private void btnFundo6_Click(object sender, EventArgs e)
        {
            SelecionarCorFundo("Group_41");
            pictureBoxFotodeFundoAtual.Image = Properties.Resources.Group_41;
        }

        private void btnFundo12_Click(object sender, EventArgs e)
        {
            SelecionarCorFundo("Group_40");
            pictureBoxFotodeFundoAtual.Image = Properties.Resources.Group_40;
        }

       
        public void AplicarTema(string nomeBorda, string nomeBandeira, string nomeMenu)
        {
            pnlMenuTelaInicial.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(nomeMenu);
        }


        private void btnTemaAmarelo_Click(object sender, EventArgs e)
        {
            AplicarTema("Amanrelo", "Amanrelo1", "Amarelo2");
            pnlMenuTelaInicial.BackgroundImage = Properties.Resources.Amarelo2;
        }

        private void btnTemaVermelho_Click(object sender, EventArgs e)
        {

            AplicarTema("Vermelho", "Vermelho1", "Vermelho2");
            pnlMenuTelaInicial.BackgroundImage = Properties.Resources.Vermelho2;
        }

        private void btnTemaRoxo_Click(object sender, EventArgs e)
        {
            AplicarTema("Roxo", "Roxo1", "Roxo2");
            pnlMenuTelaInicial.BackgroundImage = Properties.Resources.Roxo2;
        }

        private void btnTemaAzul_Click(object sender, EventArgs e)
        {
            AplicarTema("Azul", "Azul1", "Azul2");
            pnlMenuTelaInicial.BackgroundImage = Properties.Resources.Azul2;
        }

        private void btnTemaVerde_Click(object sender, EventArgs e)
        {
            AplicarTema("Verde", "Verde1", "Verde2");
            pnlMenuTelaInicial.BackgroundImage = Properties.Resources.Verde2;
        }
    }
}
