using Login_Register.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Register
{
    public partial class Login_Register: Form
    {
        private AnimacaoLogin animar = new AnimacaoLogin();
        private int targetX;
        public Login_Register()
        {
            InitializeComponent();
            animar.ConfigurarPainel(pnl);
        }
        private void Login_Register_Load(object sender, EventArgs e)
        {
           
        }
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            animar.MoverParaDireita( pnl, 440, 3);
        }
        private void linkLogin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            animar.MoverParaEsquerda(pnl, 3);

        }
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {

           
        }
        private void txtRegister_Click(object sender, EventArgs e)
        {

        }

        private void panelconfirmsenha_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtConfirmarSenha_Click(object sender, EventArgs e)
        {

        }

        private void panelsenharegister_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSenhaRegister_Click(object sender, EventArgs e)
        {

        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panelemail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtJaTemConta_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtUserNameRegister_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSenhaRegister_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFecharLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnFecharRegister_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizarRegister_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label_error_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarRegister_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void txtNaoTemContaLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
