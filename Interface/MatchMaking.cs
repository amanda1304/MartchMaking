﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_Register.Classes;

namespace Login_Register
{
    public partial class MatchMaking : Form
    {
        public MatchMaking()
        {
            InitializeComponent();
            this.FormClosing += EncerrarAplicacao.FecharAplicacao;
        }
        int TogMove;
        int MValX;
        int MValY;

        private void MatchMaking_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void MatchMaking_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void MatchMaking_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Perfil perfil = new Perfil();
                perfil.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir o formulário Perfil:\n" + ex.Message);
                this.Show(); // Reexibe o form atual, se quiser
            }
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .2;
        }

        private void MatchMaking_Load(object sender, EventArgs e)
        {
            timer3.Start();
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

        private void btnListadeJogos_Click(object sender, EventArgs e)
        {
            flowLayoutPanelListadeJogos.Visible = !flowLayoutPanelListadeJogos.Visible;
        }

        private void panelListadeJogos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelListadeJogos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
