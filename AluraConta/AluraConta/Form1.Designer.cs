namespace AluraConta
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
            this.button1 = new System.Windows.Forms.Button();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbTextoSaldo = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoTotalizador = new System.Windows.Forms.TextBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.labelContas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboDestino = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Transferir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(309, 199);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(156, 20);
            this.textoTitular.TabIndex = 1;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(309, 63);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(156, 20);
            this.textoSaldo.TabIndex = 2;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(309, 173);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(156, 20);
            this.textoNumero.TabIndex = 3;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(249, 202);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 4;
            this.lbNome.Text = "Nome";
            // 
            // lbTextoSaldo
            // 
            this.lbTextoSaldo.AutoSize = true;
            this.lbTextoSaldo.Location = new System.Drawing.Point(250, 66);
            this.lbTextoSaldo.Name = "lbTextoSaldo";
            this.lbTextoSaldo.Size = new System.Drawing.Size(34, 13);
            this.lbTextoSaldo.TabIndex = 5;
            this.lbTextoSaldo.Text = "Saldo";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(250, 176);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(44, 13);
            this.lbNumero.TabIndex = 6;
            this.lbNumero.Text = "Número";
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(309, 229);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(156, 20);
            this.textoValor.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Totalizador";
            // 
            // textoTotalizador
            // 
            this.textoTotalizador.Location = new System.Drawing.Point(309, 262);
            this.textoTotalizador.Name = "textoTotalizador";
            this.textoTotalizador.Size = new System.Drawing.Size(156, 20);
            this.textoTotalizador.TabIndex = 10;
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(309, 106);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(156, 21);
            this.comboContas.TabIndex = 11;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // labelContas
            // 
            this.labelContas.AutoSize = true;
            this.labelContas.Location = new System.Drawing.Point(225, 109);
            this.labelContas.Name = "labelContas";
            this.labelContas.Size = new System.Drawing.Size(76, 13);
            this.labelContas.TabIndex = 12;
            this.labelContas.Text = "Contas Origem";
            this.labelContas.Click += new System.EventHandler(this.labelContas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Contas Destino";
            // 
            // comboDestino
            // 
            this.comboDestino.FormattingEnabled = true;
            this.comboDestino.Location = new System.Drawing.Point(309, 133);
            this.comboDestino.Name = "comboDestino";
            this.comboDestino.Size = new System.Drawing.Size(156, 21);
            this.comboDestino.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboDestino);
            this.Controls.Add(this.labelContas);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.textoTotalizador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoValor);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.lbTextoSaldo);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbTextoSaldo;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoTotalizador;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Label labelContas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboDestino;
        private System.Windows.Forms.Button button2;
    }
}

