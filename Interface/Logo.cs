using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Login_Register
{
    public partial class Logo: Form
    {
        public Logo()
        {
            InitializeComponent();
            FecharJanela();
            PlaySound();
        }
        private void PlaySound()
        {
            // Reproduz o áudio embutido
            SoundPlayer player = new SoundPlayer(Properties.Resources.Matchmaking);
            player.Play(); // ou .PlayLooping() ou .PlaySync()
        }
        private async void FecharJanela()
        {
            await Task.Delay(5000);
            this.Close();

        }

        private void Logo_Load(object sender, EventArgs e)
        {
            // SoundPlayer splayer = new SoundPlayer(@"C:\Users\Bia\Desktop\Projeto Integrador\MatchMaking\audio\Matchmaking.wav");
            // splayer.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
