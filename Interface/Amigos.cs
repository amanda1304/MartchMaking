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
    public partial class Amigos : Form
    {
        public Amigos()
        {
            InitializeComponent();
        }
        int TogMove;
        int MValX;
        int MValY;

        private void Amigos_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            MValX = e.X;
            MValY = e.Y;
        }

        private void Amigos_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void Amigos_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }
    }
}
