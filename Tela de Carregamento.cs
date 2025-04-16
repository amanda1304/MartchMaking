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
    public partial class Tela_de_Carregamento : Form
    {
        public Tela_de_Carregamento()
        {
            InitializeComponent();
            FecharJanela();
        }
        private async void FecharJanela()
        {
            /*await Task.Delay(5000);
            this.Close();
            this.Hide();
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();*/
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Tela_de_Carregamento_Load(object sender, EventArgs e)
        {
           
        }
    }
}
