using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YourNamespace;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Login_Register
{
    
    public partial class Login_Register : Form
    {
        
        private AnimacaoLogin animador = new AnimacaoLogin();
       
        //private int targetX;
        public Login_Register()
        {
            InitializeComponent();
            
        }
        int TogMove;
        int MValX;
        int MValY;


        private void Login_Register_Load(object sender, EventArgs e)
        {

            timer1.Start();
           /*
            // Inicializa a posição do painel
            pnl.Left = 0;
            targetX = 0;

            // Configura os eventos de clique dos botões
            linkRegister.LinkClicked += linkRegister_LinkClicked; // Método gerado pelo Designer
            linkLogin.LinkClicked += linkLogin_LinkClicked_1;

            // Inicia o timer para a animação
            Timer animationTimer = new Timer();
            animationTimer.Interval = 5; // Intervalo de 10ms
            animationTimer.Tick += AnimationTimer_Tick;
            animationTimer.Start();*/

        }
        private void Login_Register_MouseDown_1(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void Login_Register_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void Login_Register_MouseUp_1(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //targetX = 440;
            animador.MoverParaDireita(pnl, 441, 25);
        }
        private void linkLogin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //targetX = 0;
            animador.MoverParaEsquerda(pnl, 441, 25);
        }
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            /*
            // Verifica se o painel precisa se mover
            if (pnl.Left < targetX)
           {
                pnl.Left += 5; // Move para a direita
            }
           else if (pnl.Left > targetX)
            {
               pnl.Left -= 5; // Move para a esquerda
            }
            */
           
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
        private void textBoxpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkEsqueciASenha_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            EsqueciASenha esqueciasenha = new EsqueciASenha();
            esqueciasenha.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Opacity += .2;
        }

        private void textBoxuser_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxpassword_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnOpenEye_Click(object sender, EventArgs e)
        {
            if (textBoxpassword.PasswordChar == '\0')
            {
                btnClosedEye.BringToFront();
                textBoxpassword.PasswordChar = '•';
            }
        }

        private void btnClosedEye_Click(object sender, EventArgs e)
        {
            if (textBoxpassword.PasswordChar == '•')
            {
                btnOpenEye.BringToFront();
                textBoxpassword.PasswordChar = '\0';
            }
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            ValidarLogin validacao = new ValidarLogin();
            if (validacao.Validar(textBoxuser.Text, textBoxpassword.Text))
            {

                this.Hide();
                TelaInicial telainicial = new TelaInicial();
                telainicial.Show();

            }
            else
            {
                label_error.Text = "*O Login e/ou a senhá está incorreto";
                label_error.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


    }
}
