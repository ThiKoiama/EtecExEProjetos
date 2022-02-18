using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        double salariototal, salario, valorvendas;
        byte v;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            salario = Convert.ToDouble(txt_salario.Text);
            v = Convert.ToByte(txt_vendas.Text);
            valorvendas = (v * 0.15);
            salariototal = salario + valorvendas;
            MessageBox.Show("Nome do vendedor: " + txt_nome.Text + "\nSalário fixo: " + salario + "\nSalário total: " + salariototal, "Dados vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
