using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Login_Register
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

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
