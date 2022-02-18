namespace Ex3
{
    partial class Form1
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
            this.lbl_dist = new System.Windows.Forms.Label();
            this.lbl_comb = new System.Windows.Forms.Label();
            this.txt_dp = new System.Windows.Forms.TextBox();
            this.txt_cg = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_dist
            // 
            this.lbl_dist.AutoSize = true;
            this.lbl_dist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dist.Location = new System.Drawing.Point(76, 66);
            this.lbl_dist.Name = "lbl_dist";
            this.lbl_dist.Size = new System.Drawing.Size(170, 20);
            this.lbl_dist.TabIndex = 0;
            this.lbl_dist.Text = "Distância percorrida";
            // 
            // lbl_comb
            // 
            this.lbl_comb.AutoSize = true;
            this.lbl_comb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comb.Location = new System.Drawing.Point(82, 196);
            this.lbl_comb.Name = "lbl_comb";
            this.lbl_comb.Size = new System.Drawing.Size(156, 20);
            this.lbl_comb.TabIndex = 1;
            this.lbl_comb.Text = "Combustível gasto";
            // 
            // txt_dp
            // 
            this.txt_dp.Location = new System.Drawing.Point(255, 68);
            this.txt_dp.Name = "txt_dp";
            this.txt_dp.Size = new System.Drawing.Size(100, 20);
            this.txt_dp.TabIndex = 2;
            // 
            // txt_cg
            // 
            this.txt_cg.Location = new System.Drawing.Point(255, 198);
            this.txt_cg.Name = "txt_cg";
            this.txt_cg.Size = new System.Drawing.Size(100, 20);
            this.txt_cg.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(398, 342);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(121, 23);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(544, 386);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_cg);
            this.Controls.Add(this.txt_dp);
            this.Controls.Add(this.lbl_comb);
            this.Controls.Add(this.lbl_dist);
            this.Name = "Form1";
            this.Text = "Média de gasto de combustível";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dist;
        private System.Windows.Forms.Label lbl_comb;
        private System.Windows.Forms.TextBox txt_dp;
        private System.Windows.Forms.TextBox txt_cg;
        private System.Windows.Forms.Button btn_ok;
    }
}

