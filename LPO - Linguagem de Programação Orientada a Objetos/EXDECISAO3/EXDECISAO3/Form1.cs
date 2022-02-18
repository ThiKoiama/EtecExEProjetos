using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXDECISAO3
{
    public partial class Form1 : Form
    {
        int r, n1, n2;

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
                n1 = Int32.Parse(txt_n1.Text);
                n2 = Int32.Parse(txt_n2.Text);
                
            }

            catch (Exception)
            {
                MessageBox.Show("Os campos devem ter apenas números inteiros.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_n1.Focus();
                txt_n1.Clear();
                txt_n2.Clear();
                return;
            }
            if (n2 > n1)
            {
                r = n2 - n1;
            }
            else
            {
                r = n1 - n2;
            }
            MessageBox.Show("A diferença do maior pelo menor é de " + r, "Diferença do maior pelo menor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
