namespace NovaProjectWF.View.Projeto
{
    partial class Atividades
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
            this.gridAtividade = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbMinhas = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtividade)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAtividade
            // 
            this.gridAtividade.AllowUserToAddRows = false;
            this.gridAtividade.AllowUserToDeleteRows = false;
            this.gridAtividade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAtividade.Location = new System.Drawing.Point(13, 88);
            this.gridAtividade.MultiSelect = false;
            this.gridAtividade.Name = "gridAtividade";
            this.gridAtividade.ReadOnly = true;
            this.gridAtividade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAtividade.Size = new System.Drawing.Size(657, 332);
            this.gridAtividade.TabIndex = 0;
            this.gridAtividade.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAtividade_CellDoubleClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(598, 39);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 24;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(383, 41);
            this.txtPesquisa.MaxLength = 50;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(209, 20);
            this.txtPesquisa.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 12);
            this.label1.TabIndex = 25;
            this.label1.Text = "(Para pesquisar por id insira um # antes do numero)";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(283, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(302, 39);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 27;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Checked = true;
            this.rbTodas.Location = new System.Drawing.Point(250, 12);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(121, 17);
            this.rbTodas.TabIndex = 28;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas as Atividades";
            this.rbTodas.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Pesquisar Em:";
            // 
            // rbMinhas
            // 
            this.rbMinhas.AutoSize = true;
            this.rbMinhas.Location = new System.Drawing.Point(378, 12);
            this.rbMinhas.Name = "rbMinhas";
            this.rbMinhas.Size = new System.Drawing.Size(111, 17);
            this.rbMinhas.TabIndex = 30;
            this.rbMinhas.Text = "Minhas Atividades";
            this.rbMinhas.UseVisualStyleBackColor = true;
            // 
            // Atividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 427);
            this.Controls.Add(this.rbMinhas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbTodas);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.gridAtividade);
            this.Name = "Atividades";
            this.Text = "Atividades";
            ((System.ComponentModel.ISupportInitialize)(this.gridAtividade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAtividade;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbMinhas;
    }
}