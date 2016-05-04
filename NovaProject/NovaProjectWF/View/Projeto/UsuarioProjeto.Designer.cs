namespace NovaProjectWF.View.Projeto
{
    partial class UsuarioProjeto
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
            this.cbPapel = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.btnIncluirUsuario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtInclusao = new System.Windows.Forms.DateTimePicker();
            this.dtSaida = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.cbAtivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbPapel
            // 
            this.cbPapel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPapel.FormattingEnabled = true;
            this.cbPapel.Location = new System.Drawing.Point(109, 51);
            this.cbPapel.Name = "cbPapel";
            this.cbPapel.Size = new System.Drawing.Size(280, 21);
            this.cbPapel.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Papel:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Usuário:";
            // 
            // cbUsuario
            // 
            this.cbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(109, 9);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(280, 21);
            this.cbUsuario.TabIndex = 9;
            // 
            // btnIncluirUsuario
            // 
            this.btnIncluirUsuario.Location = new System.Drawing.Point(41, 180);
            this.btnIncluirUsuario.Name = "btnIncluirUsuario";
            this.btnIncluirUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirUsuario.TabIndex = 7;
            this.btnIncluirUsuario.Text = "Salvar";
            this.btnIncluirUsuario.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Data Inclusão:";
            // 
            // dtInclusao
            // 
            this.dtInclusao.Location = new System.Drawing.Point(110, 91);
            this.dtInclusao.Name = "dtInclusao";
            this.dtInclusao.Size = new System.Drawing.Size(279, 20);
            this.dtInclusao.TabIndex = 14;
            // 
            // dtSaida
            // 
            this.dtSaida.Location = new System.Drawing.Point(110, 127);
            this.dtSaida.Name = "dtSaida";
            this.dtSaida.Size = new System.Drawing.Size(279, 20);
            this.dtSaida.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Data Saída:";
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.Location = new System.Drawing.Point(133, 180);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirUsuario.TabIndex = 8;
            this.btnExcluirUsuario.Text = "Cancelar";
            this.btnExcluirUsuario.UseVisualStyleBackColor = true;
            // 
            // cbAtivo
            // 
            this.cbAtivo.AutoSize = true;
            this.cbAtivo.Location = new System.Drawing.Point(109, 157);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(50, 17);
            this.cbAtivo.TabIndex = 17;
            this.cbAtivo.Text = "Ativo";
            this.cbAtivo.UseVisualStyleBackColor = true;
            // 
            // UsuarioProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 218);
            this.Controls.Add(this.cbAtivo);
            this.Controls.Add(this.dtSaida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtInclusao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPapel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.btnExcluirUsuario);
            this.Controls.Add(this.btnIncluirUsuario);
            this.Name = "UsuarioProjeto";
            this.Text = "UsuarioProjeto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPapel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Button btnIncluirUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtInclusao;
        private System.Windows.Forms.DateTimePicker dtSaida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.CheckBox cbAtivo;
    }
}