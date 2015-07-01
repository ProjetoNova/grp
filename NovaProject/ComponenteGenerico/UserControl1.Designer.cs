namespace ComponenteGenerico
{
    partial class UserControl1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Component Designer

        /// <summary>
        /// Método necessário para o suporte do Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGNovo = new System.Windows.Forms.Button();
            this.btnGEditar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnGPesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGNovo
            // 
            this.btnGNovo.Location = new System.Drawing.Point(3, 5);
            this.btnGNovo.Name = "btnGNovo";
            this.btnGNovo.Size = new System.Drawing.Size(77, 24);
            this.btnGNovo.TabIndex = 0;
            this.btnGNovo.Text = "Novo";
            this.btnGNovo.UseVisualStyleBackColor = true;
            // 
            // btnGEditar
            // 
            this.btnGEditar.Location = new System.Drawing.Point(86, 5);
            this.btnGEditar.Name = "btnGEditar";
            this.btnGEditar.Size = new System.Drawing.Size(86, 24);
            this.btnGEditar.TabIndex = 1;
            this.btnGEditar.Text = "Editar";
            this.btnGEditar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnGPesquisar
            // 
            this.btnGPesquisar.Location = new System.Drawing.Point(361, 5);
            this.btnGPesquisar.Name = "btnGPesquisar";
            this.btnGPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnGPesquisar.TabIndex = 3;
            this.btnGPesquisar.Text = "Pesquisar";
            this.btnGPesquisar.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGPesquisar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGEditar);
            this.Controls.Add(this.btnGNovo);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(439, 33);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGNovo;
        private System.Windows.Forms.Button btnGEditar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnGPesquisar;
    }
}
