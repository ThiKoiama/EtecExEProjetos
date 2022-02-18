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
    public partial class form4 : Form
    {
        public form4()
        {
            InitializeComponent();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (rb7.Checked == true)
            {
                variaveis.qr = variaveis.qr + 1;
            }
            if (rb8.Checked == true)
            {
                variaveis.qr = variaveis.qr + 1;
            }
            if (rb9.Checked == true)
            {
                variaveis.qr = variaveis.qr + 1;
            }
            if (rb10.Checked == true)
            {
                variaveis.qr = variaveis.qr + 1;
            }
            if (rb11.Checked == true)
            {
                variaveis.qr = variaveis.qr + 1;
            }
            Form form5 = new form5();
            form5.Show();
            this.Hide();
        }

       
    }
}
