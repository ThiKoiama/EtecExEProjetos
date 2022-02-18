using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        int idade, meses, dias;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            idade = Convert.ToInt32(txt_idade.Text);
            meses = idade * 12;
            dias = idade * 365;
            MessageBox.Show("Seu nome é, " + txt_nome.Text + "sua idade é de " + meses + " meses ou de " + dias + " dias.", "Nome e idade", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
