namespace projeto_encapsulamento
{
    partial class frm_Calcular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Calcular));
            this.rdb_Leite = new System.Windows.Forms.RadioButton();
            this.rdb_Martelo = new System.Windows.Forms.RadioButton();
            this.rdb_ProtetorSolar = new System.Windows.Forms.RadioButton();
            this.lbl_ValorInicial = new System.Windows.Forms.Label();
            this.txt_ValorInicial = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.txt_ValorFinal = new System.Windows.Forms.TextBox();
            this.lbl_ValorFinal = new System.Windows.Forms.Label();
            this.rdb_Televisao = new System.Windows.Forms.RadioButton();
            this.rdb_Casa = new System.Windows.Forms.RadioButton();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.lbl_texto = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdb_Leite
            // 
            this.rdb_Leite.AutoSize = true;
            this.rdb_Leite.Location = new System.Drawing.Point(91, 76);
            this.rdb_Leite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdb_Leite.Name = "rdb_Leite";
            this.rdb_Leite.Size = new System.Drawing.Size(54, 20);
            this.rdb_Leite.TabIndex = 1;
            this.rdb_Leite.Text = "Leite";
            this.rdb_Leite.UseVisualStyleBackColor = true;
            // 
            // rdb_Martelo
            // 
            this.rdb_Martelo.AutoSize = true;
            this.rdb_Martelo.Location = new System.Drawing.Point(91, 103);
            this.rdb_Martelo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdb_Martelo.Name = "rdb_Martelo";
            this.rdb_Martelo.Size = new System.Drawing.Size(70, 20);
            this.rdb_Martelo.TabIndex = 2;
            this.rdb_Martelo.Text = "Martelo";
            this.rdb_Martelo.UseVisualStyleBackColor = true;
            // 
            // rdb_ProtetorSolar
            // 
            this.rdb_ProtetorSolar.AutoSize = true;
            this.rdb_ProtetorSolar.BackColor = System.Drawing.Color.White;
            this.rdb_ProtetorSolar.Location = new System.Drawing.Point(173, 76);
            this.rdb_ProtetorSolar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdb_ProtetorSolar.Name = "rdb_ProtetorSolar";
            this.rdb_ProtetorSolar.Size = new System.Drawing.Size(104, 20);
            this.rdb_ProtetorSolar.TabIndex = 3;
            this.rdb_ProtetorSolar.Text = "Protetor Solar";
            this.rdb_ProtetorSolar.UseVisualStyleBackColor = false;
            // 
            // lbl_ValorInicial
            // 
            this.lbl_ValorInicial.AutoSize = true;
            this.lbl_ValorInicial.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_ValorInicial.Location = new System.Drawing.Point(67, 48);
            this.lbl_ValorInicial.Name = "lbl_ValorInicial";
            this.lbl_ValorInicial.Size = new System.Drawing.Size(79, 16);
            this.lbl_ValorInicial.TabIndex = 3;
            this.lbl_ValorInicial.Text = "Valor inicial:";
            // 
            // txt_ValorInicial
            // 
            this.txt_ValorInicial.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_ValorInicial.Location = new System.Drawing.Point(152, 45);
            this.txt_ValorInicial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ValorInicial.Name = "txt_ValorInicial";
            this.txt_ValorInicial.Size = new System.Drawing.Size(220, 23);
            this.txt_ValorInicial.TabIndex = 0;
            this.txt_ValorInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ValorInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ValorInicial_KeyPress);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Calcular.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calcular.ForeColor = System.Drawing.Color.White;
            this.btn_Calcular.Location = new System.Drawing.Point(280, 103);
            this.btn_Calcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(92, 44);
            this.btn_Calcular.TabIndex = 6;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = false;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // txt_ValorFinal
            // 
            this.txt_ValorFinal.Enabled = false;
            this.txt_ValorFinal.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_ValorFinal.Location = new System.Drawing.Point(173, 155);
            this.txt_ValorFinal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ValorFinal.Name = "txt_ValorFinal";
            this.txt_ValorFinal.Size = new System.Drawing.Size(199, 23);
            this.txt_ValorFinal.TabIndex = 6;
            this.txt_ValorFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_ValorFinal
            // 
            this.lbl_ValorFinal.AutoSize = true;
            this.lbl_ValorFinal.Location = new System.Drawing.Point(67, 158);
            this.lbl_ValorFinal.Name = "lbl_ValorFinal";
            this.lbl_ValorFinal.Size = new System.Drawing.Size(101, 16);
            this.lbl_ValorFinal.TabIndex = 7;
            this.lbl_ValorFinal.Text = "Valor final:  (R$)";
            // 
            // rdb_Televisao
            // 
            this.rdb_Televisao.AutoSize = true;
            this.rdb_Televisao.Location = new System.Drawing.Point(173, 103);
            this.rdb_Televisao.Name = "rdb_Televisao";
            this.rdb_Televisao.Size = new System.Drawing.Size(80, 20);
            this.rdb_Televisao.TabIndex = 4;
            this.rdb_Televisao.Text = "Televisão";
            this.rdb_Televisao.UseVisualStyleBackColor = true;
            // 
            // rdb_Casa
            // 
            this.rdb_Casa.AutoSize = true;
            this.rdb_Casa.Location = new System.Drawing.Point(298, 76);
            this.rdb_Casa.Name = "rdb_Casa";
            this.rdb_Casa.Size = new System.Drawing.Size(56, 20);
            this.rdb_Casa.TabIndex = 5;
            this.rdb_Casa.Text = "Casa";
            this.rdb_Casa.UseVisualStyleBackColor = true;
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Sair.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.ForeColor = System.Drawing.Color.White;
            this.btn_Sair.Location = new System.Drawing.Point(280, 186);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(92, 44);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // lbl_texto
            // 
            this.lbl_texto.AutoSize = true;
            this.lbl_texto.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_texto.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_texto.Location = new System.Drawing.Point(9, 9);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(435, 16);
            this.lbl_texto.TabIndex = 9;
            this.lbl_texto.Text = "Digite um valor de entrada e escolha uma opção para verificar o valor final";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Limpar.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.Color.White;
            this.btn_Limpar.Location = new System.Drawing.Point(70, 186);
            this.btn_Limpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(92, 44);
            this.btn_Limpar.TabIndex = 7;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // frm_Calcular
            // 
            this.AcceptButton = this.btn_Calcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 245);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.lbl_texto);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.rdb_Casa);
            this.Controls.Add(this.rdb_Televisao);
            this.Controls.Add(this.lbl_ValorFinal);
            this.Controls.Add(this.txt_ValorFinal);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_ValorInicial);
            this.Controls.Add(this.lbl_ValorInicial);
            this.Controls.Add(this.rdb_ProtetorSolar);
            this.Controls.Add(this.rdb_Martelo);
            this.Controls.Add(this.rdb_Leite);
            this.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Calcular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_Leite;
        private System.Windows.Forms.RadioButton rdb_Martelo;
        private System.Windows.Forms.RadioButton rdb_ProtetorSolar;
        private System.Windows.Forms.Label lbl_ValorInicial;
        private System.Windows.Forms.TextBox txt_ValorInicial;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.TextBox txt_ValorFinal;
        private System.Windows.Forms.Label lbl_ValorFinal;
        private System.Windows.Forms.RadioButton rdb_Televisao;
        private System.Windows.Forms.RadioButton rdb_Casa;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Label lbl_texto;
        private System.Windows.Forms.Button btn_Limpar;
    }
}

