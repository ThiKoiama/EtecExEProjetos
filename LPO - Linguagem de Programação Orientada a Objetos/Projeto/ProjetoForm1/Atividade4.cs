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
    public partial class Atividade4 : Form
    {
        string frase, aocontrario, fraseEspaco, a="a", le="e", i="i" ,o="o" ,u="u" ;

        private void Atividade4_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        public Atividade4()
        {
            InitializeComponent();
        }

        private void Atividade4_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
   

            frase = txt_frase.Text;

            for (int i = frase.Length - 1; i >= 0; i--)
            {
                aocontrario += frase[i];
               
            }

            txt_inversa.Text = aocontrario;

            for (int i = 0; i < frase.Length; i++)
            {
                l_vertical.Items.Add(frase[i]);
            }

            fraseEspaco = frase.Replace(" ", "");
            txt_espaco.Text = fraseEspaco;

            int quantidade_a = frase.ToUpper().Length - frase.ToUpper().Replace(a.ToUpper(), "").Length;
            txt_a.Text = quantidade_a.ToString();

            int quantidade_e= frase.ToUpper().Length - frase.ToUpper().Replace(le.ToUpper(), "").Length;
            txt_e.Text = quantidade_e.ToString();

            int quantidade_i = frase.ToUpper().Length - frase.ToUpper().Replace(i.ToUpper(), "").Length;
            txt_i.Text = quantidade_i.ToString();

            int quantidade_o = frase.ToUpper().Length - frase.ToUpper().Replace(o.ToUpper(), "").Length;
            txt_o.Text = quantidade_o.ToString();

            int quantidade_u = frase.ToUpper().Length - frase.ToUpper().Replace(u.ToUpper(), "").Length;
            txt_u.Text = quantidade_u.ToString();



            for (int i = 0; i<= frase.Length - frase.Replace(" ", "").Length; i++)
            {
                string[] palavraporpalavra = frase.Split();
                l_porpalavra.Items.Add(palavraporpalavra[i]);
            }
            
            if (frase == aocontrario)
            {
                MessageBox.Show("A frase é um palíndromo.", "Palíndromo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A frase não é um palíndromo.", "Palíndromo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

         
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_frase.Clear();
            txt_frase.Focus();
            txt_inversa.Clear();
            txt_espaco.Clear();
            txt_a.Clear();
            txt_e.Clear();
            txt_i.Clear();
            txt_o.Clear();
            txt_u.Clear();
            l_porpalavra.Items.Clear();
            l_vertical.Items.Clear();
            aocontrario = "";
        }
    }
}
