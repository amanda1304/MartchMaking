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
    public partial class TelaInicial: Form
    {
        public TelaInicial()
        {
            InitializeComponent();
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja continuar?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Se o usuário clicar em "Sim", abre o formulário LoginRegister
            if (resultado == DialogResult.Yes)
            {
                Login_Register loginForm = new Login_Register();
                loginForm.Show();

                // (Opcional) Esconder a TelaInicial
                this.Close();
            }
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            
                InitializeComponent();
         }

        private void TelaInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Fecha o programa quando a TelaInicio for fechada
        }
    }
}
