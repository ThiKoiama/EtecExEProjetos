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
    public partial class poo : Form
    {
        bool carro=true;

         class Caminhao : Veiculo
        {
            public string eixo {set; get;}
        }

        public poo()
        {
            InitializeComponent();
            
        }

        private void poo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (carro==true)
            {
                Veiculo novoCarro = new CarroOuCaminhao.Veiculo();
                novoCarro.Infmod = txt_modelo.Text;
                novoCarro.Infplaca = msk_placa.Text;
                novoCarro.Infkm = txt_km.Text;
                txt_carro.AppendText("Modelo: " + novoCarro.Infmod + "\t");
                txt_carro.AppendText("Placa: " + novoCarro.Infplaca + "\t");
                txt_carro.AppendText("Km: " + novoCarro.Infkm + "\r\n");
            }
            else
            {
                    Caminhao novoCaminhao = new CarroOuCaminhao.poo.Caminhao();
                    novoCaminhao.Infmod = txt_modelo.Text;
                    novoCaminhao.Infplaca = msk_placa.Text;
                    novoCaminhao.Infkm = txt_km.Text;
                    novoCaminhao.eixo = txt_eixo.Text;
                    txt_caminhao.AppendText("Modelo: " + novoCaminhao.Infmod + "\t");
                    txt_caminhao.AppendText("Placa: " + novoCaminhao.Infplaca + "\t");
                    txt_caminhao.AppendText("Km: " + novoCaminhao.Infkm + "\t");
                    txt_caminhao.AppendText("Eixo: " + novoCaminhao.eixo + "\r\n");
                
            }
            txt_modelo.Clear();
            txt_eixo.Clear();
            msk_placa.Clear();
            txt_km.Clear();
            txt_modelo.Focus();
        }

        private void btn_carro_Click(object sender, EventArgs e)
        {
            carro = true;
            lbl_eixo.Visible = false;
            txt_caminhao.Visible = false;
            txt_eixo.Visible = false;
        }

        private void btn_caminhao_Click(object sender, EventArgs e)
        {
            carro = false;
            lbl_eixo.Visible = true;
            txt_caminhao.Visible = true;
            txt_eixo.Visible = true;
        }

        
    }
}
