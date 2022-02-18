using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarroOuCaminhao
{
    public partial class Form1 : Form
    {
        bool carro=true;
        string mod, placa, km, eixo;

        private void btn_carro_Click(object sender, EventArgs e)
        {
            carro = true;
            lbl_eixo.Visible = false;
            txt_caminhao.Visible = false;
            txt_eixo.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            poo f2 = new poo();
            f2.Show();
            this.Hide();
        }

        private void btn_send_Click(object sender, EventArgs e)

        {
            
            if (carro)
            {
                mod = txt_modelo.Text;
                placa = msk_placa.Text;
                km = txt_km.Text;
                txt_carro.AppendText("Modelo: " + mod+"\t");
                txt_carro.AppendText("Placa: " + placa+"\t");
                txt_carro.AppendText("Km: " + km+"\r\n");
            }

            else {
                eixo = txt_eixo.Text;
                mod = txt_modelo.Text;
                placa = msk_placa.Text;
                km = txt_km.Text;
                txt_caminhao.AppendText("Modelo: " + mod + "\t");
                txt_caminhao.AppendText("Placa: " + placa + "\t");
                txt_caminhao.AppendText("Km: " + km + "\t");
                txt_caminhao.AppendText("Eixo: " + eixo + "\r\n");
            
           

            }
            txt_modelo.Clear();
            txt_eixo.Clear();
            msk_placa.Clear();
            txt_km.Clear();
            txt_modelo.Focus();
        }

        private void btn_caminhao_Click(object sender, EventArgs e)
        {
            carro = false;
            lbl_eixo.Visible = true;
            txt_caminhao.Visible = true;
            txt_eixo.Visible = true;
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        
    }
}
