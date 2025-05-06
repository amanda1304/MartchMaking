using System;
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
    public partial class EsqueciASenha: Form
    {
        public EsqueciASenha()
        {
            InitializeComponent();
            this.FormClosing += EncerrarAplicacao.FecharAplicacao;
        }
        int TogMove;
        int MValX;
        int MValY;
        private void btnVoltarRecuperarSenha_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Register login_register = new Login_Register();
            login_register.Show();
        }

        private void textBoxRecuperarSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void EsqueciASenha_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void EsqueciASenha_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void EsqueciASenha_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .2;
        }

        private void EsqueciASenha_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
