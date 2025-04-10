using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login_Register
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            
        }
        int TogMove;
        int MValX;
        int MValY;
        private void TelaInicial_MouseDown(object sender, MouseEventArgs e)
        {

            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void TelaInicial_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void TelaInicial_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }
        private void TelaInicial_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.Width = this.ClientSize.Width / 2; // Exemplo de ajuste dinâmico
                control.Height = this.ClientSize.Height / 2;
            }
        }
  
        private void labelFavoritosDaSemana1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btnFecharTelaInicial_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarTelaInicial_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdicionarAmigo1_Click(object sender, EventArgs e)
        {
            btnAmigoAdicionado1.BringToFront();
        }

        private void btnAmigoAdicionado1_Click(object sender, EventArgs e)
        {
        }

        private void btnAmigoAdicionado2_Click(object sender, EventArgs e)
        {
           

        }

        private void btnAdicionarAmigo2_Click(object sender, EventArgs e)
        {
            btnAmigoAdicionado2.BringToFront();
        }

        private void btnAmigoAdicionado3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarAmigo3_Click(object sender, EventArgs e)
        {
            btnAmigoAdicionado3.BringToFront();
        }

        private void btnAmigoAdicionado4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarAmigo4_Click(object sender, EventArgs e)
        {
            btnAmigoAdicionado4.BringToFront();
        }

        private void btnAmigoAdicionado5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarAmigo5_Click(object sender, EventArgs e)
        {
            btnAmigoAdicionado5.BringToFront();
        }

        private void labelHistoricoJogoDeUsuario1_Click(object sender, EventArgs e)
        {

        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Jogos TelaJogos = new Jogos();
            TelaJogos.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Perfil perfil = new Perfil();
            perfil.Show();
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
    }

}