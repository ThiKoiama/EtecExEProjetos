using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex10
{
    public partial class Form1 : Form
    {
        double valor;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            valor = Double.Parse(txt_valor.Text);
            valor /= 5;
            MessageBox.Show("O valor da parcela é de R$" + valor, "Valor da parcela", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
