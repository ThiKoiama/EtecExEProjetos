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
    public partial class Atividade7 : Form
    {
        public Atividade7()
        {
            InitializeComponent();
        }

        private void Atividade7_Load(object sender, EventArgs e)
        {

        }

        private void Atividade7_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan t1;
            int idade;
            string dt_2;
            DateTime dt_incio, dt_atual;
            dt_incio = DateTime.Parse(monthCalendar1.SelectionStart.ToShortDateString());
            dt_atual = DateTime.Now;
            lbl_dtatual.Text = dt_atual.ToShortDateString();
            dt_2 = dt_incio.AddDays(int.Parse(txt_da.Text)).ToShortDateString();
            if (dt_atual > dt_incio)
            {
                t1 = dt_atual - dt_incio;
            }
            else
            {
                t1 = dt_incio - dt_atual;
            }
            DateTime datanasc = DateTime.Parse(txt_datanasc.Text);
            if(datanasc.DayOfYear <= dt_atual.DayOfYear)
            {
                idade = dt_atual.Year - datanasc.Year;
            }
            else
            {
                idade = dt_atual.Year - datanasc.Year - 1;
            }
            
            MessageBox.Show("Data nova: " + dt_2, "Data nova", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Idade: " + idade.ToString(), "Idade", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime dt_atual = DateTime.Now;
            DateTime selected = monthCalendar1.SelectionRange.Start;
            lbl_dtatual.Text = dt_atual.ToShortDateString();
            if (dt_atual < selected)
            {
                int difference = selected.DayOfYear - dt_atual.DayOfYear;
                lbl_difference.Text = difference + " dias";
            }
            else
            {
                int difference = dt_atual.DayOfYear - selected.DayOfYear;
                lbl_difference.Text = difference + " dias";
            }
        }
    }
}
