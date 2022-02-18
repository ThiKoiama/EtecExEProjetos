using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXDECISAO1
{
    public partial class Form1 : Form
    {
        double n1, n2, r;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja sair?", "Deseja sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }

            else
            {
                e.Cancel = true;
                txt_n1.Focus();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            try
            {
                n1 = Double.Parse(txt_n1.Text);
                n2 = Double.Parse(txt_n2.Text);

            }

            catch (Exception)
            {
                MessageBox.Show("Os campos 1° número e 2° número devem ter apenas números", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_n1.Focus();
                txt_n1.Clear();
                txt_n2.Clear();
                txt_op.Clear();
                return;
            }

            if (txt_op.Text == "+")
            {
                r = n1 + n2;
            }
            else if (txt_op.Text == "-")
            {
                r = n1 - n2;
            }
            else if (txt_op.Text == "*")
            {
                r = n1 * n2;
            }
            else if (txt_op.Text == "/")
            {
                r = n1 / n2;
            }

            else
            {
                MessageBox.Show("O operador deve ter apenas sinais matemáticos.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("O resultado é " + r, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        public Form1()
        {
            InitializeComponent();
        }


    }
}
