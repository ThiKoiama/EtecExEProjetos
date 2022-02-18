using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5
{
    public partial class Form1 : Form
    {
        double media, nota1, nota2, nota3;
        public Form1()
        {
            InitializeComponent();
        }
                
        private void btn_ok_Click(object sender, EventArgs e)
        {
            nota1 = Convert.ToDouble(txt_nota1.Text);
            nota2 = Convert.ToDouble(txt_nota2.Text);
            nota3 = Convert.ToDouble(txt_nota3.Text);
            media = (nota1 + nota2 + nota3) / 3;
            MessageBox.Show("Aluno: " + txt_nome.Text+"\nMédia: "+media, "Média", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
