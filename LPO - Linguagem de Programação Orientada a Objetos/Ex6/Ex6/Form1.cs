using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6
{
    public partial class Form1 : Form
    {
        double a, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            a = Double.Parse(txt_a.Text);
            b = Double.Parse(txt_b.Text);
            MessageBox.Show("O valor de a é " + b +"\nO valor de b é " + a,"Exercício6", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
