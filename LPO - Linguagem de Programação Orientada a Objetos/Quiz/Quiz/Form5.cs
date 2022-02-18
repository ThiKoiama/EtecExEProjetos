using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class form5 : Form
    {
        public form5()
        {
            InitializeComponent();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (rb12.Checked == true)
            {
                variaveis.qr = variaveis.qr + 1;
            }
            if (rb13.Checked == true)
            {
                variaveis.qr = variaveis.qr + 1;
            }
            if (rb14.Checked == true)
            {
                variaveis.qr = variaveis.qr + 1;
            }
            if (rb15.Checked == true)
            {
                variaveis.qr = variaveis.qr + 1;
            }

            Form form6 = new form6();
            form6.Show();
            this.Hide();

        }
    }
}