namespace Tabuada2._0
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
            this.btn_while = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.btn_dowhile = new System.Windows.Forms.Button();
            this.btn_for = new System.Windows.Forms.Button();
            this.lbl_r = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_while
            // 
            this.btn_while.Location = new System.Drawing.Point(21, 377);
            this.btn_while.Name = "btn_while";
            this.btn_while.Size = new System.Drawing.Size(98, 42);
            this.btn_while.TabIndex = 1;
            this.btn_while.Text = "While";
            this.btn_while.UseVisualStyleBackColor = true;
            this.btn_while.Click += new System.EventHandler(this.btn_while_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número:";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(151, 53);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(65, 20);
            this.txt_n1.TabIndex = 4;
            // 
            // btn_dowhile
            // 
            this.btn_dowhile.Location = new System.Drawing.Point(402, 377);
            this.btn_dowhile.Name = "btn_dowhile";
            this.btn_dowhile.Size = new System.Drawing.Size(98, 42);
            this.btn_dowhile.TabIndex = 5;
            this.btn_dowhile.Text = "Do while";
            this.btn_dowhile.UseVisualStyleBackColor = true;
            this.btn_dowhile.Click += new System.EventHandler(this.btn_dowhile_Click);
            // 
            // btn_for
            // 
            this.btn_for.Location = new System.Drawing.Point(209, 377);
            this.btn_for.Name = "btn_for";
            this.btn_for.Size = new System.Drawing.Size(98, 42);
            this.btn_for.TabIndex = 6;
            this.btn_for.Text = "For";
            this.btn_for.UseVisualStyleBackColor = true;
            this.btn_for.Click += new System.EventHandler(this.btn_for_Click);
            // 
            // lbl_r
            // 
            this.lbl_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_r.ForeColor = System.Drawing.Color.White;
            this.lbl_r.Location = new System.Drawing.Point(85, 109);
            this.lbl_r.Name = "lbl_r";
            this.lbl_r.Size = new System.Drawing.Size(345, 220);
            this.lbl_r.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(525, 450);
            this.Controls.Add(this.lbl_r);
            this.Controls.Add(this.btn_for);
            this.Controls.Add(this.btn_dowhile);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_while);
            this.Name = "Form1";
            this.Text = "Tabuada";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_while;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Button btn_dowhile;
        private System.Windows.Forms.Button btn_for;
        private System.Windows.Forms.ListBox lbox_r;
        private System.Windows.Forms.Label lbl_r;
    }
}

