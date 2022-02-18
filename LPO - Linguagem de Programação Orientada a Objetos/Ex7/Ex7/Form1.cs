using System;
using System.Windows.Forms;

namespace Ex7
{
    public partial class Form1 : Form
    {
        double temp, c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            c = Double.Parse(txt_c.Text);
            temp = (9 * c + 160) / 5;
            MessageBox.Show("A temperatura em °F é igual a: " + temp+"°F", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
    }
}
