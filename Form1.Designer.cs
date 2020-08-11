namespace Calculadora_Aula2
{
    partial class CALCULADORA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CALCULADORA));
            this.btn_0 = new System.Windows.Forms.Button();
            this.txt_tela = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_operacao = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_subtração = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_multiplicação = new System.Windows.Forms.Button();
            this.btn_divisão = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_ponto = new System.Windows.Forms.Button();
            this.calculo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(14, 340);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(75, 59);
            this.btn_0.TabIndex = 0;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // txt_tela
            // 
            this.txt_tela.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_tela.Enabled = false;
            this.txt_tela.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tela.Location = new System.Drawing.Point(15, 15);
            this.txt_tela.Name = "txt_tela";
            this.txt_tela.ReadOnly = true;
            this.txt_tela.Size = new System.Drawing.Size(317, 53);
            this.txt_tela.TabIndex = 16;
            this.txt_tela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(14, 275);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 59);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(95, 275);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 59);
            this.btn_2.TabIndex = 2;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(176, 275);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 59);
            this.btn_3.TabIndex = 3;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_igual.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_igual.Location = new System.Drawing.Point(176, 340);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(75, 59);
            this.btn_igual.TabIndex = 10;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = false;
            this.btn_igual.Click += new System.EventHandler(this.Btn_igual_Click);
            // 
            // btn_operacao
            // 
            this.btn_operacao.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_operacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_operacao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_operacao.Location = new System.Drawing.Point(257, 275);
            this.btn_operacao.Name = "btn_operacao";
            this.btn_operacao.Size = new System.Drawing.Size(75, 124);
            this.btn_operacao.TabIndex = 11;
            this.btn_operacao.Text = "+";
            this.btn_operacao.UseVisualStyleBackColor = false;
            this.btn_operacao.Click += new System.EventHandler(this.Operacao_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(176, 210);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 59);
            this.btn_6.TabIndex = 6;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(95, 210);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 59);
            this.btn_5.TabIndex = 5;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(14, 210);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 59);
            this.btn_4.TabIndex = 4;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // btn_subtração
            // 
            this.btn_subtração.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_subtração.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtração.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_subtração.Location = new System.Drawing.Point(257, 210);
            this.btn_subtração.Name = "btn_subtração";
            this.btn_subtração.Size = new System.Drawing.Size(75, 59);
            this.btn_subtração.TabIndex = 12;
            this.btn_subtração.Text = "-";
            this.btn_subtração.UseVisualStyleBackColor = false;
            this.btn_subtração.Click += new System.EventHandler(this.Operacao_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(176, 145);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 59);
            this.btn_9.TabIndex = 9;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(95, 145);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 59);
            this.btn_8.TabIndex = 8;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(14, 145);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 59);
            this.btn_7.TabIndex = 7;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // btn_multiplicação
            // 
            this.btn_multiplicação.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_multiplicação.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplicação.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_multiplicação.Location = new System.Drawing.Point(257, 145);
            this.btn_multiplicação.Name = "btn_multiplicação";
            this.btn_multiplicação.Size = new System.Drawing.Size(75, 59);
            this.btn_multiplicação.TabIndex = 13;
            this.btn_multiplicação.Text = "x";
            this.btn_multiplicação.UseVisualStyleBackColor = false;
            this.btn_multiplicação.Click += new System.EventHandler(this.Operacao_Click);
            // 
            // btn_divisão
            // 
            this.btn_divisão.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_divisão.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divisão.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_divisão.Location = new System.Drawing.Point(257, 80);
            this.btn_divisão.Name = "btn_divisão";
            this.btn_divisão.Size = new System.Drawing.Size(75, 59);
            this.btn_divisão.TabIndex = 14;
            this.btn_divisão.Text = "/";
            this.btn_divisão.UseVisualStyleBackColor = false;
            this.btn_divisão.Click += new System.EventHandler(this.Operacao_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_limpar.Location = new System.Drawing.Point(15, 80);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(236, 59);
            this.btn_limpar.TabIndex = 15;
            this.btn_limpar.Text = "CE";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.Btn_limpar_Click);
            // 
            // btn_ponto
            // 
            this.btn_ponto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_ponto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ponto.Location = new System.Drawing.Point(95, 340);
            this.btn_ponto.Name = "btn_ponto";
            this.btn_ponto.Size = new System.Drawing.Size(75, 59);
            this.btn_ponto.TabIndex = 17;
            this.btn_ponto.Text = ".";
            this.btn_ponto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ponto.UseVisualStyleBackColor = false;
            this.btn_ponto.Click += new System.EventHandler(this.Numeros_Click);
            // 
            // calculo
            // 
            this.calculo.AutoSize = true;
            this.calculo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.calculo.Location = new System.Drawing.Point(17, 24);
            this.calculo.Name = "calculo";
            this.calculo.Size = new System.Drawing.Size(0, 37);
            this.calculo.TabIndex = 18;
            // 
            // CALCULADORA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(344, 408);
            this.Controls.Add(this.calculo);
            this.Controls.Add(this.btn_ponto);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_divisão);
            this.Controls.Add(this.btn_multiplicação);
            this.Controls.Add(this.btn_subtração);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_operacao);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.txt_tela);
            this.Controls.Add(this.btn_0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CALCULADORA";
            this.ShowIcon = false;
            this.Text = "CALCULADORA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.TextBox txt_tela;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_operacao;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_subtração;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_multiplicação;
        private System.Windows.Forms.Button btn_divisão;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_ponto;
        private System.Windows.Forms.Label calculo;
    }
}

