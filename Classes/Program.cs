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
            if (logo.IsDisposed)
            {
                Application.Run(new Login_Register());
            }
        }
    }
}
