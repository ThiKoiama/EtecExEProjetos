using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        double peso, alt, imc;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja sair?", "Deseja sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }

            else
            {
                e.Cancel = true;
                txt_peso.Focus();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                peso = Double.Parse(txt_peso.Text);
                alt = Double.Parse(txt_altura.Text);

            }

            catch (Exception)
            {
                MessageBox.Show("Os campos peso e altura devem ter apenas números reais.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_peso.Focus();
                txt_peso.Clear();
                txt_altura.Clear();
                return;
            }

            imc = peso / (alt * alt);
            if (imc < 18.5)
            {
                MessageBox.Show("Magro", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (imc < 25)
            {
                MessageBox.Show("Normal", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if(imc < 30)
            {
                MessageBox.Show("Obeso I", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Obeso II", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
