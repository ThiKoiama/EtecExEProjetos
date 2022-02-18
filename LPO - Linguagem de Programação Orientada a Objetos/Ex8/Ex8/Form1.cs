using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex8
{
    public partial class Form1 : Form
    {
        double dol, real, cot;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            dol = Double.Parse(txt_dol.Text);
            cot = Double.Parse(txt_cot.Text);
            real = dol * cot;
            MessageBox.Show("Você tem R$" + real, "Valor em R$", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
