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
    public partial class Atividade6 : Form
    {
        public Atividade6()
        {
            InitializeComponent();
        }

        private void Atividade6_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }


        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            DateTime selected;
            string path;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            selected = monthCalendar1.SelectionRange.Start;
            if(selected.Day == 25 && selected.Month == 12)
            {
                path = "../../img/natal.jpg";
                pictureBox1.Load(path);
            }
            else if(selected.Day == 31 && selected.Month == 12)
            {
                path = "../../img/novo.jpg";
                pictureBox1.Load(path);
            }
            else if(selected.DayOfYear >= new DateTime(selected.Year, 3, 20).DayOfYear && selected.DayOfYear < new DateTime(selected.Year, 6, 21).DayOfYear)
            {
                path = "../../img/outono.jpg";
                pictureBox1.Load(path);
            }
            else if(selected.DayOfYear >= new DateTime(selected.Year, 6, 21).DayOfYear && selected.DayOfYear < new DateTime(selected.Year, 9, 23).DayOfYear)
            {
                path = "../../img/inverno.jpg";
                pictureBox1.Load(path);
            }
            else if(selected.DayOfYear >= new DateTime(selected.Year, 9, 23).DayOfYear && selected.DayOfYear < new DateTime(selected.Year, 12, 22).DayOfYear)
            {
                path = "../../img/primavera.jpg";
                pictureBox1.Load(path);
            }
            else
            {
                path = "../../img/verao.jpg";
                pictureBox1.Load(path);
            }
            
        }
    }
}
