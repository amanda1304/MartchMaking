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
    public partial class Logo: Form
    {
        public Logo()
        {
            InitializeComponent();
            FecharJanela();
        }
        private async void FecharJanela()
        {
            await Task.Delay(5000);
            this.Close();

        }

        private void Logo_Load(object sender, EventArgs e)
        {

        }
    }
}
