using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForm1
{
    public partial class Atividade3 : Form
    {
        public Atividade3()
        {
            InitializeComponent();
        }

        private void Atividade3_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Você realmente deseja sair?", "Deseja sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }

            else
            {
                e.Cancel = true;

            }
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            try
            {
                string provedorf, provedort, dominio;
                int posicao;
                string email = txt_email.Text;
                posicao = email.IndexOf('@');
                dominio = email.Substring(0, posicao);
                provedorf = email.Substring(posicao + 1);
                provedort = provedorf.Substring(0,provedorf.IndexOf('.'));
                MessageBox.Show("O email é válido!\nPosição do @: " + posicao.ToString() + "\nDomínio: " + dominio + "\nProvedor: " + provedort, "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Email não é válido", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_email.Clear();
            txt_email.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
