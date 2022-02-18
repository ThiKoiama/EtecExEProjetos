namespace CarroOuCaminhao
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
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_km = new System.Windows.Forms.TextBox();
            this.msk_placa = new System.Windows.Forms.MaskedTextBox();
            this.btn_carro = new System.Windows.Forms.Button();
            this.btn_caminhao = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.lbl_eixo = new System.Windows.Forms.Label();
            this.txt_eixo = new System.Windows.Forms.TextBox();
            this.txt_carro = new System.Windows.Forms.TextBox();
            this.txt_caminhao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(112, 43);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(136, 20);
            this.txt_modelo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Km";
            // 
            // txt_km
            // 
            this.txt_km.Location = new System.Drawing.Point(112, 144);
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(136, 20);
            this.txt_km.TabIndex = 9;
            // 
            // msk_placa
            // 
            this.msk_placa.Location = new System.Drawing.Point(112, 93);
            this.msk_placa.Mask = "LLL 9999";
            this.msk_placa.Name = "msk_placa";
            this.msk_placa.Size = new System.Drawing.Size(136, 20);
            this.msk_placa.TabIndex = 10;
            // 
            // btn_carro
            // 
            this.btn_carro.Location = new System.Drawing.Point(377, 37);
            this.btn_carro.Name = "btn_carro";
            this.btn_carro.Size = new System.Drawing.Size(101, 37);
            this.btn_carro.TabIndex = 13;
            this.btn_carro.Text = "Carro";
            this.btn_carro.UseVisualStyleBackColor = true;
            this.btn_carro.Click += new System.EventHandler(this.btn_carro_Click);
            // 
            // btn_caminhao
            // 
            this.btn_caminhao.Location = new System.Drawing.Point(525, 37);
            this.btn_caminhao.Name = "btn_caminhao";
            this.btn_caminhao.Size = new System.Drawing.Size(101, 37);
            this.btn_caminhao.TabIndex = 14;
            this.btn_caminhao.Text = "Caminhão";
            this.btn_caminhao.UseVisualStyleBackColor = true;
            this.btn_caminhao.Click += new System.EventHandler(this.btn_caminhao_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(674, 37);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(101, 37);
            this.btn_send.TabIndex = 15;
            this.btn_send.Text = "Enviar";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // lbl_eixo
            // 
            this.lbl_eixo.AutoSize = true;
            this.lbl_eixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eixo.Location = new System.Drawing.Point(374, 146);
            this.lbl_eixo.Name = "lbl_eixo";
            this.lbl_eixo.Size = new System.Drawing.Size(41, 18);
            this.lbl_eixo.TabIndex = 16;
            this.lbl_eixo.Text = "Eixo";
            this.lbl_eixo.Visible = false;
            // 
            // txt_eixo
            // 
            this.txt_eixo.Location = new System.Drawing.Point(430, 144);
            this.txt_eixo.Name = "txt_eixo";
            this.txt_eixo.Size = new System.Drawing.Size(136, 20);
            this.txt_eixo.TabIndex = 17;
            this.txt_eixo.Visible = false;
            // 
            // txt_carro
            // 
            this.txt_carro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_carro.Location = new System.Drawing.Point(112, 201);
            this.txt_carro.Multiline = true;
            this.txt_carro.Name = "txt_carro";
            this.txt_carro.ReadOnly = true;
            this.txt_carro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_carro.Size = new System.Drawing.Size(198, 226);
            this.txt_carro.TabIndex = 18;
            // 
            // txt_caminhao
            // 
            this.txt_caminhao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_caminhao.Location = new System.Drawing.Point(461, 201);
            this.txt_caminhao.Multiline = true;
            this.txt_caminhao.Name = "txt_caminhao";
            this.txt_caminhao.ReadOnly = true;
            this.txt_caminhao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_caminhao.Size = new System.Drawing.Size(198, 226);
            this.txt_caminhao.TabIndex = 19;
            this.txt_caminhao.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Proximo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_caminhao);
            this.Controls.Add(this.txt_carro);
            this.Controls.Add(this.txt_eixo);
            this.Controls.Add(this.lbl_eixo);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_caminhao);
            this.Controls.Add(this.btn_carro);
            this.Controls.Add(this.msk_placa);
            this.Controls.Add(this.txt_km);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_modelo);
            this.Name = "Form1";
            this.Text = "Automóvel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_km;
        private System.Windows.Forms.MaskedTextBox msk_placa;
        private System.Windows.Forms.Button btn_carro;
        private System.Windows.Forms.Button btn_caminhao;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lbl_eixo;
        private System.Windows.Forms.TextBox txt_eixo;
        private System.Windows.Forms.TextBox txt_carro;
        private System.Windows.Forms.TextBox txt_caminhao;
        private System.Windows.Forms.Button button1;
    }
}

