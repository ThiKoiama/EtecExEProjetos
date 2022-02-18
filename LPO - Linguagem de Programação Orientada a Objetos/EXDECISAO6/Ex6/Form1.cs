using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6
{
    public partial class Form1 : Form
    {
        int idade;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                idade = Int32.Parse(txt_idade.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("O campo idade só aceita números inteiros!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_idade.Focus();
                txt_idade.Clear();
                return;
            }
            if (idade >= 5 && idade <= 7)
            {
                MessageBox.Show("Você está na categoria Infantil A.", "Natação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if(idade >= 5 && idade <= 10)
            {
                MessageBox.Show("Você está na categoria Infantil B.", "Natação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (idade >= 5 && idade <= 13)
            {
                MessageBox.Show("Você está na categoria Juvenil A.", "Natação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (idade >= 5 && idade <= 17)
            {
                MessageBox.Show("Você está na categoria Juvenil B.", "Natação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if(idade >= 5 && idade <= 25)
            {
                MessageBox.Show("Você está na categoria Sênior.", "Natação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Você está fora da Faixa Etária.", "Natação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                txt_idade.Focus();
            }
        }

        
    }
}
