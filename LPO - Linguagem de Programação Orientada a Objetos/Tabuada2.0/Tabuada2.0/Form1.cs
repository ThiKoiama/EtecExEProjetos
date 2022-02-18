using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada2._0
{
    public partial class Form1 : Form
    {
        int n, i;
        


        public Form1()
        {
            InitializeComponent();
          
        }

        private void lbox_r_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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

        private void btn_while_Click(object sender, EventArgs e)
        {
            i = 1;
            lbl_r.ResetText();
            try
            {
                n = Int32.Parse(txt_n1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("O campo número só aceita números inteiros!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_n1.Focus();
                txt_n1.Clear();
                return;
            }
            while (i<=10)
            {

                lbl_r.Text += (n + " X " + i + " = " + n * i + "\r\n");
                i++;
            }


        }

        private void btn_dowhile_Click(object sender, EventArgs e)
        {
            i = 0;
            lbl_r.ResetText();
            try
            {
                n = Int32.Parse(txt_n1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("O campo número só aceita números inteiros!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_n1.Focus();
                txt_n1.Clear();
                return;
            }

            do
            {
                i++;
                lbl_r.Text += (n + " X " + i + " = " + n * i + "\r\n");
            } while (i<10);
        }

        private void btn_for_Click(object sender, EventArgs e)
        {

            lbl_r.ResetText();
            try
            {
                n = Int32.Parse(txt_n1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("O campo número só aceita números inteiros!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_n1.Focus();
                txt_n1.Clear();
                return;
            }
            for (i = 1; i <= 10; i++)
            {
                
                lbl_r.Text+=(n+" X "+i+" = "+n*i + "\r\n");
                
            }

         }
    }
}
