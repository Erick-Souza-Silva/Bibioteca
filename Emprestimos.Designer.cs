namespace Bibioteca
{
    partial class Emprestimos
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
            this.LBO_Emprestimos = new System.Windows.Forms.ListBox();
            this.LBL_livro = new System.Windows.Forms.Label();
            this.Txt_livro = new System.Windows.Forms.TextBox();
            this.LBL_Funcionario = new System.Windows.Forms.Label();
            this.LBL_Usario = new System.Windows.Forms.Label();
            this.Txt_Funcionario = new System.Windows.Forms.TextBox();
            this.Txt_Usario = new System.Windows.Forms.TextBox();
            this.BTN_emprestar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBO_Emprestimos
            // 
            this.LBO_Emprestimos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LBO_Emprestimos.FormattingEnabled = true;
            this.LBO_Emprestimos.Location = new System.Drawing.Point(350, 12);
            this.LBO_Emprestimos.Name = "LBO_Emprestimos";
            this.LBO_Emprestimos.Size = new System.Drawing.Size(409, 208);
            this.LBO_Emprestimos.TabIndex = 0;
            this.LBO_Emprestimos.SelectedIndexChanged += new System.EventHandler(this.LBO_Emprestimos_SelectedIndexChanged);
            // 
            // LBL_livro
            // 
            this.LBL_livro.AutoSize = true;
            this.LBL_livro.Location = new System.Drawing.Point(12, 21);
            this.LBL_livro.Name = "LBL_livro";
            this.LBL_livro.Size = new System.Drawing.Size(30, 13);
            this.LBL_livro.TabIndex = 1;
            this.LBL_livro.Text = "Livro";
            // 
            // Txt_livro
            // 
            this.Txt_livro.Location = new System.Drawing.Point(15, 37);
            this.Txt_livro.Name = "Txt_livro";
            this.Txt_livro.Size = new System.Drawing.Size(158, 20);
            this.Txt_livro.TabIndex = 2;
            // 
            // LBL_Funcionario
            // 
            this.LBL_Funcionario.AutoSize = true;
            this.LBL_Funcionario.Location = new System.Drawing.Point(12, 71);
            this.LBL_Funcionario.Name = "LBL_Funcionario";
            this.LBL_Funcionario.Size = new System.Drawing.Size(62, 13);
            this.LBL_Funcionario.TabIndex = 3;
            this.LBL_Funcionario.Text = "Funcionario";
            // 
            // LBL_Usario
            // 
            this.LBL_Usario.AutoSize = true;
            this.LBL_Usario.Location = new System.Drawing.Point(12, 120);
            this.LBL_Usario.Name = "LBL_Usario";
            this.LBL_Usario.Size = new System.Drawing.Size(37, 13);
            this.LBL_Usario.TabIndex = 4;
            this.LBL_Usario.Text = "Usario";
            // 
            // Txt_Funcionario
            // 
            this.Txt_Funcionario.Location = new System.Drawing.Point(12, 87);
            this.Txt_Funcionario.Name = "Txt_Funcionario";
            this.Txt_Funcionario.Size = new System.Drawing.Size(161, 20);
            this.Txt_Funcionario.TabIndex = 5;
            // 
            // Txt_Usario
            // 
            this.Txt_Usario.Location = new System.Drawing.Point(12, 136);
            this.Txt_Usario.Name = "Txt_Usario";
            this.Txt_Usario.Size = new System.Drawing.Size(161, 20);
            this.Txt_Usario.TabIndex = 6;
            // 
            // BTN_emprestar
            // 
            this.BTN_emprestar.Location = new System.Drawing.Point(12, 175);
            this.BTN_emprestar.Name = "BTN_emprestar";
            this.BTN_emprestar.Size = new System.Drawing.Size(303, 23);
            this.BTN_emprestar.TabIndex = 7;
            this.BTN_emprestar.Text = "Emprestar";
            this.BTN_emprestar.UseVisualStyleBackColor = true;
            this.BTN_emprestar.Click += new System.EventHandler(this.BTN_emprestar_Click);
            // 
            // Emprestimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 227);
            this.Controls.Add(this.BTN_emprestar);
            this.Controls.Add(this.Txt_Usario);
            this.Controls.Add(this.Txt_Funcionario);
            this.Controls.Add(this.LBL_Usario);
            this.Controls.Add(this.LBL_Funcionario);
            this.Controls.Add(this.Txt_livro);
            this.Controls.Add(this.LBL_livro);
            this.Controls.Add(this.LBO_Emprestimos);
            this.Name = "Emprestimos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBO_Emprestimos;
        private System.Windows.Forms.Label LBL_livro;
        private System.Windows.Forms.TextBox Txt_livro;
        private System.Windows.Forms.Label LBL_Funcionario;
        private System.Windows.Forms.Label LBL_Usario;
        private System.Windows.Forms.TextBox Txt_Funcionario;
        private System.Windows.Forms.TextBox Txt_Usario;
        private System.Windows.Forms.Button BTN_emprestar;
    }
}

