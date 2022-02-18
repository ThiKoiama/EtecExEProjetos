using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class form6 : Form
    {
        public form6()
        {
            InitializeComponent();
            int pct;
            string respostas;
            respostas = variaveis.qr.ToString();
            lbl_acertos.Text = respostas;
            lbl_nome.Text = variaveis.name;
            pct = (variaveis.qr * 100) / 15;
            string porcentagem;
            porcentagem = pct.ToString();
            lbl_pct.Text = porcentagem+" %"; 
        }

        private void form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
