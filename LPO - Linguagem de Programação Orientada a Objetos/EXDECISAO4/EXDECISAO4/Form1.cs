using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXDECISAO4
{
    public partial class Form1 : Form
    {
        Double m, n1, n2, n3;

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
                n1 = Double.Parse(txt_n1.Text);
                n2 = Double.Parse(txt_n2.Text);
                n3 = Double.Parse(txt_n3.Text);

            }

            catch (Exception)
            {
                MessageBox.Show("Os campos notas apenas números reais, e o campo nome apenas caracteres.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nome.Focus();
                txt_nome.Clear();
                txt_n1.Clear();
                txt_n2.Clear();
                txt_n3.Clear();
                return;
            }
            m = (n1 + n2 + n3) / 3;
            if (m >= 7)
            {
                MessageBox.Show("Nome: " + txt_nome.Text + "\nMédia: " + m + "\nMenção: Aprovado!", "Menção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (m <= 5)
            {
                MessageBox.Show("Nome: " + txt_nome.Text + "\nMédia: " + m + "\nMenção: Reprovado!", "Menção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nome: " + txt_nome.Text  + "\nMédia: " + m + "\nMenção: Recuperação!", "Menção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
