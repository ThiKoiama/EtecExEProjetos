namespace Exercicios_Calculos_Compras_
{
    partial class form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_compras = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.rb_add = new System.Windows.Forms.RadioButton();
            this.rb_sub = new System.Windows.Forms.RadioButton();
            this.rb_mul = new System.Windows.Forms.RadioButton();
            this.rb_div = new System.Windows.Forms.RadioButton();
            this.rb_exp = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_compras
            // 
            this.btn_compras.Location = new System.Drawing.Point(489, 285);
            this.btn_compras.Name = "btn_compras";
            this.btn_compras.Size = new System.Drawing.Size(75, 23);
            this.btn_compras.TabIndex = 0;
            this.btn_compras.Text = "COMPRAS";
            this.btn_compras.UseVisualStyleBackColor = true;
            this.btn_compras.Click += new System.EventHandler(this.btn_compras_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(12, 285);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 1;
            this.btn_calc.Text = "CALCULAR";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "1° valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "2° valor:";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(116, 33);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(100, 20);
            this.txt_n1.TabIndex = 4;
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(116, 89);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(100, 20);
            this.txt_n2.TabIndex = 5;
            // 
            // rb_add
            // 
            this.rb_add.AutoSize = true;
            this.rb_add.Location = new System.Drawing.Point(416, 36);
            this.rb_add.Name = "rb_add";
            this.rb_add.Size = new System.Drawing.Size(65, 17);
            this.rb_add.TabIndex = 6;
            this.rb_add.TabStop = true;
            this.rb_add.Text = "ADIÇÃO";
            this.rb_add.UseVisualStyleBackColor = true;
            // 
            // rb_sub
            // 
            this.rb_sub.AutoSize = true;
            this.rb_sub.Location = new System.Drawing.Point(416, 59);
            this.rb_sub.Name = "rb_sub";
            this.rb_sub.Size = new System.Drawing.Size(91, 17);
            this.rb_sub.TabIndex = 7;
            this.rb_sub.TabStop = true;
            this.rb_sub.Text = "SUBTRAÇÃO";
            this.rb_sub.UseVisualStyleBackColor = true;
            // 
            // rb_mul
            // 
            this.rb_mul.AutoSize = true;
            this.rb_mul.Location = new System.Drawing.Point(416, 82);
            this.rb_mul.Name = "rb_mul";
            this.rb_mul.Size = new System.Drawing.Size(110, 17);
            this.rb_mul.TabIndex = 8;
            this.rb_mul.TabStop = true;
            this.rb_mul.Text = "MULTIPLICAÇÃO";
            this.rb_mul.UseVisualStyleBackColor = true;
            // 
            // rb_div
            // 
            this.rb_div.AutoSize = true;
            this.rb_div.Location = new System.Drawing.Point(416, 105);
            this.rb_div.Name = "rb_div";
            this.rb_div.Size = new System.Drawing.Size(68, 17);
            this.rb_div.TabIndex = 9;
            this.rb_div.TabStop = true;
            this.rb_div.Text = "DIVISÃO";
            this.rb_div.UseVisualStyleBackColor = true;
            // 
            // rb_exp
            // 
            this.rb_exp.AutoSize = true;
            this.rb_exp.Location = new System.Drawing.Point(416, 128);
            this.rb_exp.Name = "rb_exp";
            this.rb_exp.Size = new System.Drawing.Size(116, 17);
            this.rb_exp.TabIndex = 10;
            this.rb_exp.TabStop = true;
            this.rb_exp.Text = "EXPONENCIAÇÃO";
            this.rb_exp.UseVisualStyleBackColor = true;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(576, 320);
            this.Controls.Add(this.rb_exp);
            this.Controls.Add(this.rb_div);
            this.Controls.Add(this.rb_mul);
            this.Controls.Add(this.rb_sub);
            this.Controls.Add(this.rb_add);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.btn_compras);
            this.Name = "form1";
            this.Text = "CALCULOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_compras;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.TextBox txt_n2;
        private System.Windows.Forms.RadioButton rb_add;
        private System.Windows.Forms.RadioButton rb_sub;
        private System.Windows.Forms.RadioButton rb_mul;
        private System.Windows.Forms.RadioButton rb_div;
        private System.Windows.Forms.RadioButton rb_exp;
    }
}

