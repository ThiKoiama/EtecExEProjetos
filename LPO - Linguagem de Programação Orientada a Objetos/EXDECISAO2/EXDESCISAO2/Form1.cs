using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXDESCISAO2
{
    public partial class Form1 : Form
    {
        int a, b, c;

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

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                a = Int32.Parse(txt_n1.Text);
                b = Int32.Parse(txt_n2.Text);
                c = Int32.Parse(txt_n3.Text);
            }

            catch (Exception)
            {
                MessageBox.Show("Os campos devem ter apenas números inteiros.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_n1.Focus();
                txt_n1.Clear();
                txt_n2.Clear();
                txt_n3.Clear();
                return;
            }

                        
            if ((c>a) && (c > b)) 
            {
                MessageBox.Show("O maior número é " + c, "Maior número", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((b > a) && (b > c))
            {
                MessageBox.Show("O maior número é " + b, "Maior número", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O maior número é " + a, "Maior número", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
