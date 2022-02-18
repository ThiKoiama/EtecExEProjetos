namespace ProjetoForm1
{
    partial class Atividade2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exec = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.btn_prox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 16;
            this.lb1.Location = new System.Drawing.Point(49, 136);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(74, 372);
            this.lb1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Palavra";
            // 
            // btn_exec
            // 
            this.btn_exec.Location = new System.Drawing.Point(326, 459);
            this.btn_exec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_exec.Name = "btn_exec";
            this.btn_exec.Size = new System.Drawing.Size(141, 49);
            this.btn_exec.TabIndex = 8;
            this.btn_exec.Text = "Executar";
            this.btn_exec.UseVisualStyleBackColor = true;
            this.btn_exec.Click += new System.EventHandler(this.btn_exec_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(161, 82);
            this.txt_nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(251, 22);
            this.txt_nome.TabIndex = 10;
            // 
            // btn_prox
            // 
            this.btn_prox.Location = new System.Drawing.Point(326, 361);
            this.btn_prox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_prox.Name = "btn_prox";
            this.btn_prox.Size = new System.Drawing.Size(141, 50);
            this.btn_prox.TabIndex = 13;
            this.btn_prox.Text = "Voltar";
            this.btn_prox.UseVisualStyleBackColor = true;
            this.btn_prox.Click += new System.EventHandler(this.Btn_prox_Click);
            // 
            // Atividade2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(523, 554);
            this.Controls.Add(this.btn_prox);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exec);
            this.Controls.Add(this.lb1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Atividade2";
            this.Text = "Atividade2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Atividade2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exec;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_prox;
    }
}