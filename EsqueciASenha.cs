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
    public partial class EsqueciASenha: Form
    {
        public EsqueciASenha()
        {
            InitializeComponent();
        }

        private void btnVoltarRecuperarSenha_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Register login_register = new Login_Register();
            login_register.Show();
        }
    }
}
