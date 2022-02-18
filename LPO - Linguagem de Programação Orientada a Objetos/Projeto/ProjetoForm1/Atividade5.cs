using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForm1
{
    public partial class Atividade5 : Form
    {
        public Atividade5()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (rbn.Checked)
            {
                pb.Load("../../Imagem/foto1.jpg");
            }
            else
            {
                pb.LoadAsync("../../Imagem/foto1.jpg");
            }
        }

        
       

        private void Button2_Click(object sender, EventArgs e)
        {
            if (rbn.Checked)
            {
                pb.Load("https://wallpapertag.com/wallpaper/full/2/6/f/959052-full-hd-desktop-wallpaper-1920x1080-1920x1080-for-windows-10.jpg");
            }
            else
            {
                pb.LoadAsync("https://wallpapertag.com/wallpaper/full/2/6/f/959052-full-hd-desktop-wallpaper-1920x1080-1920x1080-for-windows-10.jpg");
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pb.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        
        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pb.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pb.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void LinkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void Atividade5_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Você realmente deseja sair?", "Deseja sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.ExitThread();
            }

            else
            {
                e.Cancel = true;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
