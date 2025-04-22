namespace Bibioteca
{
    partial class Emprestando
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
            this.CBX_Livro = new System.Windows.Forms.ComboBox();
            this.CBX_Funcionario = new System.Windows.Forms.ComboBox();
            this.CBX_Usuario = new System.Windows.Forms.ComboBox();
            this.LBL_Livro = new System.Windows.Forms.Label();
            this.LBL_Funcionario = new System.Windows.Forms.Label();
            this.LBL_Usuario = new System.Windows.Forms.Label();
            this.BTN_Emprs = new System.Windows.Forms.Button();
            this.BTN_Cance = new System.Windows.Forms.Button();
            this.DTP_devolucao = new System.Windows.Forms.DateTimePicker();
            this.LBL_devolucao = new System.Windows.Forms.Label();
            this.LBL_Status = new System.Windows.Forms.Label();
            this.CBX_status = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CBX_Livro
            // 
            this.CBX_Livro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Livro.FormattingEnabled = true;
            this.CBX_Livro.Location = new System.Drawing.Point(12, 48);
            this.CBX_Livro.Name = "CBX_Livro";
            this.CBX_Livro.Size = new System.Drawing.Size(121, 21);
            this.CBX_Livro.TabIndex = 0;
            // 
            // CBX_Funcionario
            // 
            this.CBX_Funcionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Funcionario.FormattingEnabled = true;
            this.CBX_Funcionario.Location = new System.Drawing.Point(153, 48);
            this.CBX_Funcionario.Name = "CBX_Funcionario";
            this.CBX_Funcionario.Size = new System.Drawing.Size(121, 21);
            this.CBX_Funcionario.TabIndex = 1;
            // 
            // CBX_Usuario
            // 
            this.CBX_Usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Usuario.FormattingEnabled = true;
            this.CBX_Usuario.Location = new System.Drawing.Point(292, 48);
            this.CBX_Usuario.Name = "CBX_Usuario";
            this.CBX_Usuario.Size = new System.Drawing.Size(121, 21);
            this.CBX_Usuario.TabIndex = 2;
            // 
            // LBL_Livro
            // 
            this.LBL_Livro.AutoSize = true;
            this.LBL_Livro.Location = new System.Drawing.Point(13, 32);
            this.LBL_Livro.Name = "LBL_Livro";
            this.LBL_Livro.Size = new System.Drawing.Size(30, 13);
            this.LBL_Livro.TabIndex = 3;
            this.LBL_Livro.Text = "Livro";
            // 
            // LBL_Funcionario
            // 
            this.LBL_Funcionario.AutoSize = true;
            this.LBL_Funcionario.Location = new System.Drawing.Point(150, 29);
            this.LBL_Funcionario.Name = "LBL_Funcionario";
            this.LBL_Funcionario.Size = new System.Drawing.Size(62, 13);
            this.LBL_Funcionario.TabIndex = 4;
            this.LBL_Funcionario.Text = "Funcionario";
            // 
            // LBL_Usuario
            // 
            this.LBL_Usuario.AutoSize = true;
            this.LBL_Usuario.Location = new System.Drawing.Point(289, 32);
            this.LBL_Usuario.Name = "LBL_Usuario";
            this.LBL_Usuario.Size = new System.Drawing.Size(43, 13);
            this.LBL_Usuario.TabIndex = 5;
            this.LBL_Usuario.Text = "Usuario";
            // 
            // BTN_Emprs
            // 
            this.BTN_Emprs.Location = new System.Drawing.Point(12, 176);
            this.BTN_Emprs.Name = "BTN_Emprs";
            this.BTN_Emprs.Size = new System.Drawing.Size(200, 23);
            this.BTN_Emprs.TabIndex = 6;
            this.BTN_Emprs.Text = "Emprestar";
            this.BTN_Emprs.UseVisualStyleBackColor = true;
            this.BTN_Emprs.Click += new System.EventHandler(this.BTN_Emprs_Click);
            // 
            // BTN_Cance
            // 
            this.BTN_Cance.Location = new System.Drawing.Point(218, 176);
            this.BTN_Cance.Name = "BTN_Cance";
            this.BTN_Cance.Size = new System.Drawing.Size(204, 23);
            this.BTN_Cance.TabIndex = 7;
            this.BTN_Cance.Text = "Cancelar";
            this.BTN_Cance.UseVisualStyleBackColor = true;
            this.BTN_Cance.Click += new System.EventHandler(this.BTN_Cance_Click);
            // 
            // DTP_devolucao
            // 
            this.DTP_devolucao.Location = new System.Drawing.Point(12, 105);
            this.DTP_devolucao.Name = "DTP_devolucao";
            this.DTP_devolucao.Size = new System.Drawing.Size(410, 20);
            this.DTP_devolucao.TabIndex = 8;
            // 
            // LBL_devolucao
            // 
            this.LBL_devolucao.AutoSize = true;
            this.LBL_devolucao.Location = new System.Drawing.Point(13, 89);
            this.LBL_devolucao.Name = "LBL_devolucao";
            this.LBL_devolucao.Size = new System.Drawing.Size(59, 13);
            this.LBL_devolucao.TabIndex = 9;
            this.LBL_devolucao.Text = "Devolução";
            // 
            // LBL_Status
            // 
            this.LBL_Status.AutoSize = true;
            this.LBL_Status.Location = new System.Drawing.Point(16, 132);
            this.LBL_Status.Name = "LBL_Status";
            this.LBL_Status.Size = new System.Drawing.Size(43, 13);
            this.LBL_Status.TabIndex = 10;
            this.LBL_Status.Text = "Satatus";
            // 
            // CBX_status
            // 
            this.CBX_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_status.FormattingEnabled = true;
            this.CBX_status.Location = new System.Drawing.Point(12, 149);
            this.CBX_status.Name = "CBX_status";
            this.CBX_status.Size = new System.Drawing.Size(410, 21);
            this.CBX_status.TabIndex = 11;
            // 
            // Emprestando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 204);
            this.Controls.Add(this.CBX_status);
            this.Controls.Add(this.LBL_Status);
            this.Controls.Add(this.LBL_devolucao);
            this.Controls.Add(this.DTP_devolucao);
            this.Controls.Add(this.BTN_Cance);
            this.Controls.Add(this.BTN_Emprs);
            this.Controls.Add(this.LBL_Usuario);
            this.Controls.Add(this.LBL_Funcionario);
            this.Controls.Add(this.LBL_Livro);
            this.Controls.Add(this.CBX_Usuario);
            this.Controls.Add(this.CBX_Funcionario);
            this.Controls.Add(this.CBX_Livro);
            this.Name = "Emprestando";
            this.Text = "Emprestando";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBX_Livro;
        private System.Windows.Forms.ComboBox CBX_Funcionario;
        private System.Windows.Forms.ComboBox CBX_Usuario;
        private System.Windows.Forms.Label LBL_Livro;
        private System.Windows.Forms.Label LBL_Funcionario;
        private System.Windows.Forms.Label LBL_Usuario;
        private System.Windows.Forms.Button BTN_Emprs;
        private System.Windows.Forms.Button BTN_Cance;
        private System.Windows.Forms.DateTimePicker DTP_devolucao;
        private System.Windows.Forms.Label LBL_devolucao;
        private System.Windows.Forms.Label LBL_Status;
        private System.Windows.Forms.ComboBox CBX_status;
    }
}