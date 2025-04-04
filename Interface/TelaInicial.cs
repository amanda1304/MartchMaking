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
            
        }
    }
}
