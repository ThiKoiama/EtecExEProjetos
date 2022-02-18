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
    public partial class Atividade1 : Form
    {
        string variavel;
        public Atividade1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            variavel = txt_palavra.Text;
            lb1.Items.Add(variavel);
            txt_palavra.Clear();
            txt_palavra.Focus();
        }

        private void btn_movetudodir_Click(object sender, EventArgs e)
        {
            lb2.Items.AddRange(lb1.Items);
            lb1.Items.Clear();
        }

        private void btn_movetudoesq_Click(object sender, EventArgs e)
        {
            lb1.Items.AddRange(lb2.Items);
            lb2.Items.Clear();
        }

        private void btn_movedir_Click(object sender, EventArgs e)
        {
            try
            {
                string position = lb1.SelectedItem.ToString();
                lb2.Items.Add(position);
                lb1.Items.Remove(position);
            }
            catch
            {
                MessageBox.Show("Por favor selecione um item no ListBox.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
 
        }

        private void btn_moveesq_Click(object sender, EventArgs e)
        {
            try
            {
                string position = lb2.SelectedItem.ToString();
                lb1.Items.Add(position);
                lb2.Items.Remove(position);
            }
            catch
            {
                MessageBox.Show("Por favor selecione um item no ListBox.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                                    
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            lb2.Items.Clear();
        }

        private void btn_prox_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
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

            }
        }

        private void lb1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
