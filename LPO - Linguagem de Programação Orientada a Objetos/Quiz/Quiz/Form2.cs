using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    
    public partial class form2 : Form
    {
        
        
        public form2()
        {
            InitializeComponent();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Form form3 = new form3();
            form3.Show();
            this.Hide();
            variaveis.name = txt_nome.Text;
            
        }
        
        
    }
}
