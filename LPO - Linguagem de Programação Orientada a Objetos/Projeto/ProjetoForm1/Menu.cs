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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void atividade1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atividade1 f1 = new Atividade1();
            f1.Show();
            this.Hide();
            
        }

        private void atividade2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atividade2 a2 = new Atividade2();
            a2.Show();
            this.Hide();
        }

        private void atividade3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atividade3 a3 = new Atividade3();
            a3.Show();
            this.Hide();
        }

        private void atividade4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atividade4 a4 = new Atividade4();
            a4.Show();
            this.Hide();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
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

        private void AtividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void atividade5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atividade5 a5 = new Atividade5();
            a5.Show();
            this.Hide();
        }

        private void atividade6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atividade6 a6 = new Atividade6();
            a6.Show();
            this.Hide();
        }

        private void atividade7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Atividade7 a7 = new Atividade7();
            a7.Show();
            this.Hide();
        }

  
    }
}
