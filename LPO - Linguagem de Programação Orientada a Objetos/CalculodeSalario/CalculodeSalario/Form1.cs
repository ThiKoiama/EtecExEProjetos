using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculodeSalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_n.Clear();
            txt_ht.Clear();
            txt_vh.Clear();
            txt_sb.Clear();
            txt_nd.Clear();
            txt_pctinss.Clear();
            txt_pctirrf.Clear();
            txt_inss.Clear();
            txt_irrf.Clear();
            txt_sl.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sb, ht, vh, nd, pctinss, pctirrf, inss, irrf, sl, ded, cons;
            ht = Double.Parse(txt_ht.Text);
            vh = Double.Parse(txt_vh.Text);
            nd = Double.Parse(txt_nd.Text);
            sb = ht * vh;
            cons = 189.59;
            if (sb <= 1693.72)
            {
                pctinss = 0.08;
                txt_pctinss.Text = "8%";
                inss = Math.Round(sb * pctinss, 2);
                txt_inss.Text = inss.ToString();
            }
            else if (sb <= 2822.90)
            {
                pctinss = 0.09;
                txt_pctinss.Text = "9%";
                inss = Math.Round(sb * pctinss, 2);
                txt_inss.Text = inss.ToString();
            }
            else if(sb <=5645.80)
            {
                pctinss = 0.11;
                txt_pctinss.Text = "11%";
                inss = Math.Round(sb * pctinss, 2);
                txt_inss.Text = inss.ToString();
            }
            else
            {
                inss = 642.34;
                txt_pctinss.Text = "TETO";
                txt_inss.Text = inss.ToString();
            }
            if (sb - inss <= 1903.98)
            {
                pctirrf = 0;
                ded = 0;
                txt_pctirrf.Text = "0%";
                txt_irrf.Text = "0";
                irrf = ((sb - nd * cons - inss)*pctirrf) - ded;
                irrf = Math.Round(irrf, 2);
                if (irrf < 0)
                {
                    irrf = 0;
                }
                sl = sb - inss - irrf;
                txt_sl.Text = sl.ToString();
            }
            else if (sb - inss <= 2826.65)
            {
                pctirrf = 0.0075;
                ded =142.8;
                irrf = ((sb - nd * cons - inss) * pctirrf) - ded;
                irrf = Math.Round(irrf, 2);
                txt_pctirrf.Text = "7,5%";
                if (irrf < 0)
                {
                    irrf = 0;
                }
                txt_irrf.Text = irrf.ToString();
                sl = sb - inss - irrf;
                txt_sl.Text = sl.ToString();
            }
            else if (sb - inss <= 3751.05)
            {
                pctirrf = 0.15;
                ded = 354.8;
                irrf = ((sb - nd * cons - inss) * pctirrf) - ded;
                irrf = Math.Round(irrf, 2);
                txt_pctirrf.Text = "15%";
                if (irrf < 0)
                {
                    irrf = 0;
                }
                txt_irrf.Text = irrf.ToString();
                sl = sb - inss - irrf;
                txt_sl.Text = sl.ToString();
            }
            else if (sb - inss <= 4664.68)
            {
                pctirrf = 0.225;
                ded = 636.13;
                txt_pctirrf.Text = "22,5%";
                irrf = ((sb - nd * cons - inss) * pctirrf) - ded;
                irrf = Math.Round(irrf, 2);
                if (irrf < 0)
                {
                    irrf = 0;
                }
                txt_irrf.Text = irrf.ToString();
                sl = sb - inss - irrf;
                txt_sl.Text = sl.ToString();
            }
            else 
            {
                pctirrf = 0.275;
                ded = 869.36;
                irrf = ((sb - nd * cons - inss) * pctirrf) - ded;
                irrf = Math.Round(irrf, 2);
                txt_pctirrf.Text = "27,5%";
                if (irrf < 0)
                {
                    irrf = 0;
                }

                txt_irrf.Text = irrf.ToString();
                sl = sb - inss - irrf;
                txt_sl.Text = sl.ToString();
            }
            txt_sb.Text = sb.ToString();
            



            
        }
    }
}
