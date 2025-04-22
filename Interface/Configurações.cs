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
        int idUsuario = 1; // aqui você coloca o ID real do usuário logado
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
        }
        private void SelecionarAvatar(string nomeAvatar)
        {
            imagemSelecionada = nomeAvatar;
            pictureBoxPerfil.Image = (Image)Properties.Resources.ResourceManager.GetObject(nomeAvatar);
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
            

            if (string.IsNullOrEmpty(imagemSelecionada))
            {
                
                MessageBox.Show("Selecione uma imagem primeiro.");
                return;
            }
            //bool sucesso = configService.SalvarAvatar(UserSession.IdUsuario, imagemSelecionada);

            //bool sucesso = configService.SalvarAvatar(UserSession.IdPerfilUsuario, imagemSelecionada);
            bool sucesso = configService.SalvarAvatar(UserSession.userLogado.id, imagemSelecionada);

            if (sucesso)
                MessageBox.Show("Imagem de perfil atualizada com sucesso!");
            else
                MessageBox.Show("Erro ao salvar imagem.");
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
    }
}
