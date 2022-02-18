using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        double dp, cg, media;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            dp = Convert.ToDouble(txt_dp.Text);
            cg = Convert.ToDouble(txt_cg.Text);
            media = dp / cg;
            MessageBox.Show("Consumo médio do carro: " + media + " l/km", "Consumo médio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
