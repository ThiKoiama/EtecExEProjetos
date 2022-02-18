using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            double valor, novovalor;
            valor = Double.Parse(txt_valor.Text);
            novovalor =  valor + valor * .007;
            MessageBox.Show("O novo valor é R$" + novovalor, "Investimentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
