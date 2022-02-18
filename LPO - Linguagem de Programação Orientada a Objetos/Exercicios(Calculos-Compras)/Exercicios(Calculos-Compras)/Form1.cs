using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios_Calculos_Compras_
{
    public partial class form1 : Form
    {
        double n1, n2, res;

        private void btn_compras_Click(object sender, EventArgs e)
        {
            Form compra = new Compras();
            compra.Show();
            this.Hide();
        }

        public form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
           
            try
            {
                n1 = double.Parse(txt_n1.Text);
                n2 = double.Parse(txt_n2.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Os campos só aceitam números!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rb_add.Checked)
            {
                res = n1 + n2;
                MessageBox.Show("O resultado da soma é " + res, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rb_sub.Checked)
            {
                res = n1 - n2;
                MessageBox.Show("O resultado da subtração é " + res, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rb_mul.Checked)
            {
                res = n1 * n2;
                MessageBox.Show("O resultado da multiplicação é " + res, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rb_div.Checked)
            {
                res = n1 / n2;
                MessageBox.Show("O resultado da divisão é " + res, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rb_exp.Checked)
            {
                res =  Math.Pow(n1, n2);
                MessageBox.Show("O resultado da exponenciação é " + res, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
