using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double n1, n2, n;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
             n1 = Double.Parse(textBox1.Text);
             n2 = Double.Parse(textBox2.Text);
             n = n1 + n2;
            MessageBox.Show("O resultado é: " + n, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            n1 = Double.Parse(textBox1.Text);
            n2 = Double.Parse(textBox2.Text);
            n = n1 * n2;
            MessageBox.Show("O resultado é: " + n, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
             n1 = Double.Parse(textBox1.Text);
             n2 = Double.Parse(textBox2.Text);
             n = n1 / n2;
            MessageBox.Show("O resultado é: " + n, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

                    

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
             n1 = Double.Parse(textBox1.Text);
             n2 = Double.Parse(textBox2.Text);
             n = n1 - n2;
            MessageBox.Show("O resultado é: " + n, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
