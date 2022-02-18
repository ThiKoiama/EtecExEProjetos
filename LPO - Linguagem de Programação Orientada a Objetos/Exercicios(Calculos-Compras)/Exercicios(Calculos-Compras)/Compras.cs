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
    public partial class Compras : Form
    {
        double v, qtd, vt, vd, vp, pctot;

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1 = new form1();
            form1.Show();
            this.Hide();
           
        }

        private void Compras_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }

        public Compras()
        {
            InitializeComponent();
        }

        
        private void btn_calc_Click(object sender, EventArgs e)
        {
       
            try
            {
                v = double.Parse(txt_v.Text);
                qtd = double.Parse(txt_q.Text);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Os campos estão vazios!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            vt = v * qtd;
            vt = v * qtd;
            lbl_vt.Text = vt.ToString();
            if(rb_5.Checked==true){
                vd =0.95*vt;
                lbl_vd.Text = vd.ToString();
            }
            if (rb_7.Checked==true)
            {
                vd = 0.93 * vt;
                lbl_vd.Text = vd.ToString();
            }
            if (rb_10.Checked==true)
            {
                vd = 0.9* vt; ;
                lbl_vd.Text = vd.ToString();
            }
            if (rb_ot.Checked==true)
            {
                pctot = Double.Parse(txt_ot.Text);
                vd = vt - 0.01 * pctot;
                lbl_vd.Text = vd.ToString();
            }
            
            if (rb_vista.Checked){
                lbl_vp.Text = vd.ToString();
            }
            if (rb_2.Checked==true)
            {
                vp = Math.Round(vd / 2);
                lbl_vp.Text = vp.ToString();
            }
            if (rb_4.Checked==true)
            {
                vp = Math.Round(vd / 4);
                lbl_vp.Text = vp.ToString();
            }
            if (rb_6.Checked==true)
            {
                vp = Math.Round(vd / 6);
                lbl_vp.Text = vp.ToString();
            }


        }
    }
}
