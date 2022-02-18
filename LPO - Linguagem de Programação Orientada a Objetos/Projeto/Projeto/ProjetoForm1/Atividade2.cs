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
    public partial class Atividade2 : Form
    {
        string variavel;
        public Atividade2()
        {
            InitializeComponent();
        }

        private void Atividade2_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_exec_Click(object sender, EventArgs e)
        {
            variavel = txt_nome.Text;
            for(int i = 0; i < variavel.Length; i++)
            {
                lb1.Items.Add(variavel[i]);
            }
        }

        private void Btn_prox_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
