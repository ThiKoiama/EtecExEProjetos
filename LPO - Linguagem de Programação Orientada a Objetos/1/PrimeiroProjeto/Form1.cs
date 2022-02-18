using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroProjeto
{
    public partial class v : Form
    {
        public v()
        {
            InitializeComponent();
        }

        private void lbl_sobrenome_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //lbl_txt.Text = "Seu nome é" +" "+txt_nome.Text + " " + txt_sobrenome.Text; 
            MessageBox.Show("Seu nome é" + " " + txt_nome.Text + " " + txt_sobrenome.Text, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lbl_txt.Text = "";
            txt_nome.Text = "";
            txt_sobrenome.Text = "";
            txt_nome.Focus();
        }

        private void lbl_txt_Click(object sender, EventArgs e)
        {

        }
    }
}
