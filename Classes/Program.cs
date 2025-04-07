using System;
using System.Windows.Forms;

namespace Login_Register
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Logo logo = new Logo();
            Application.Run(new Logo());
            //Application.Run(new Perfil());
            //Application.Run(new Amigos());
            //Application.Run(new Jogos());
            if (logo.IsDisposed)
            {
                Application.Run(new Login_Register());
            }
        }
    }
}
