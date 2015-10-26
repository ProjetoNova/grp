namespace NovaProjectWF.View.Projeto
{
    partial class NovoProjeto
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPlano = new System.Windows.Forms.TabPage();
            this.txtPlanoProjeto = new System.Windows.Forms.RichTextBox();
            this.tabProjeto = new System.Windows.Forms.TabPage();
            this.dtPrevista = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.lblId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPapel = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.gridEquipe = new System.Windows.Forms.DataGridView();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.btnIncluirUsuario = new System.Windows.Forms.Button();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabFase = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEditarAtividade = new System.Windows.Forms.Button();
            this.btnNovaAtividade = new System.Windows.Forms.Button();
            this.gridAtividade = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridFase = new System.Windows.Forms.DataGridView();
            this.btnEditarFase = new System.Windows.Forms.Button();
            this.btnNovaFase = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPlano.SuspendLayout();
            this.tabProjeto.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipe)).BeginInit();
            this.tabFase.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtividade)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFase)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPlano);
            this.tabControl1.Controls.Add(this.tabProjeto);
            this.tabControl1.Controls.Add(this.tabFase);
            this.tabControl1.Location = new System.Drawing.Point(12, 81);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 478);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPlano
            // 
            this.tabPlano.BackColor = System.Drawing.SystemColors.Control;
            this.tabPlano.Controls.Add(this.txtPlanoProjeto);
            this.tabPlano.Location = new System.Drawing.Point(4, 22);
            this.tabPlano.Name = "tabPlano";
            this.tabPlano.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlano.Size = new System.Drawing.Size(808, 452);
            this.tabPlano.TabIndex = 2;
            this.tabPlano.Text = "Plano de Projeto";
            // 
            // txtPlanoProjeto
            // 
            this.txtPlanoProjeto.Location = new System.Drawing.Point(0, 0);
            this.txtPlanoProjeto.Name = "txtPlanoProjeto";
            this.txtPlanoProjeto.Size = new System.Drawing.Size(812, 492);
            this.txtPlanoProjeto.TabIndex = 0;
            this.txtPlanoProjeto.Text = "";
            // 
            // tabProjeto
            // 
            this.tabProjeto.BackColor = System.Drawing.SystemColors.Control;
            this.tabProjeto.Controls.Add(this.dtPrevista);
            this.tabProjeto.Controls.Add(this.dtInicio);
            this.tabProjeto.Controls.Add(this.lblStatus);
            this.tabProjeto.Controls.Add(this.dtFim);
            this.tabProjeto.Controls.Add(this.label2);
            this.tabProjeto.Controls.Add(this.groupBox2);
            this.tabProjeto.Controls.Add(this.txtDescricao);
            this.tabProjeto.Controls.Add(this.label6);
            this.tabProjeto.Controls.Add(this.label5);
            this.tabProjeto.Controls.Add(this.label4);
            this.tabProjeto.Location = new System.Drawing.Point(4, 22);
            this.tabProjeto.Name = "tabProjeto";
            this.tabProjeto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProjeto.Size = new System.Drawing.Size(808, 452);
            this.tabProjeto.TabIndex = 0;
            this.tabProjeto.Text = "Projeto";
            // 
            // dtPrevista
            // 
            this.dtPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPrevista.Location = new System.Drawing.Point(722, 7);
            this.dtPrevista.Name = "dtPrevista";
            this.dtPrevista.Size = new System.Drawing.Size(78, 20);
            this.dtPrevista.TabIndex = 29;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(554, 7);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(78, 20);
            this.dtInicio.TabIndex = 28;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(47, 55);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Id:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(698, 93);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 23;
            // 
            // dtFim
            // 
            this.dtFim.Enabled = false;
            this.dtFim.Location = new System.Drawing.Point(554, 55);
            this.dtFim.Mask = "00/00/0000";
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(68, 20);
            this.dtFim.TabIndex = 22;
            this.dtFim.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(478, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Data Fim:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPapel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbUsuario);
            this.groupBox2.Controls.Add(this.gridEquipe);
            this.groupBox2.Controls.Add(this.btnExcluirUsuario);
            this.groupBox2.Controls.Add(this.btnIncluirUsuario);
            this.groupBox2.Location = new System.Drawing.Point(9, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(791, 359);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipe do Projeto";
            // 
            // cbPapel
            // 
            this.cbPapel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPapel.FormattingEnabled = true;
            this.cbPapel.Location = new System.Drawing.Point(388, 22);
            this.cbPapel.Name = "cbPapel";
            this.cbPapel.Size = new System.Drawing.Size(235, 21);
            this.cbPapel.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(345, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Papel:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Usuário:";
            // 
            // cbUsuario
            // 
            this.cbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(59, 23);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(280, 21);
            this.cbUsuario.TabIndex = 3;
            // 
            // gridEquipe
            // 
            this.gridEquipe.AllowUserToAddRows = false;
            this.gridEquipe.AllowUserToDeleteRows = false;
            this.gridEquipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEquipe.Location = new System.Drawing.Point(7, 50);
            this.gridEquipe.MultiSelect = false;
            this.gridEquipe.Name = "gridEquipe";
            this.gridEquipe.ReadOnly = true;
            this.gridEquipe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEquipe.Size = new System.Drawing.Size(778, 303);
            this.gridEquipe.TabIndex = 2;
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.Location = new System.Drawing.Point(710, 21);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirUsuario.TabIndex = 1;
            this.btnExcluirUsuario.Text = "Excluir";
            this.btnExcluirUsuario.UseVisualStyleBackColor = true;
            this.btnExcluirUsuario.Click += new System.EventHandler(this.btnExcluirUsuario_Click);
            // 
            // btnIncluirUsuario
            // 
            this.btnIncluirUsuario.Location = new System.Drawing.Point(629, 21);
            this.btnIncluirUsuario.Name = "btnIncluirUsuario";
            this.btnIncluirUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirUsuario.TabIndex = 0;
            this.btnIncluirUsuario.Text = "Incluir Colaborador";
            this.btnIncluirUsuario.UseVisualStyleBackColor = true;
            this.btnIncluirUsuario.Click += new System.EventHandler(this.btnIncluirUsuario_Click);
            // 
            // cbSituacao
            // 
            this.cbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Location = new System.Drawing.Point(644, 52);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(180, 21);
            this.cbSituacao.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(567, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Situação: *";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(79, 10);
            this.txtDescricao.MaxLength = 300;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(393, 61);
            this.txtDescricao.TabIndex = 4;
            this.txtDescricao.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Descrição: *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(640, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data Prevista: *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data Início: *";
            // 
            // txtNome
            // 
            this.txtNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNome.Location = new System.Drawing.Point(143, 55);
            this.txtNome.MaxLength = 70;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(403, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome: *";
            // 
            // tabFase
            // 
            this.tabFase.BackColor = System.Drawing.SystemColors.Control;
            this.tabFase.Controls.Add(this.groupBox4);
            this.tabFase.Controls.Add(this.groupBox3);
            this.tabFase.Controls.Add(this.btnEditarFase);
            this.tabFase.Controls.Add(this.btnNovaFase);
            this.tabFase.Location = new System.Drawing.Point(4, 22);
            this.tabFase.Name = "tabFase";
            this.tabFase.Padding = new System.Windows.Forms.Padding(3);
            this.tabFase.Size = new System.Drawing.Size(808, 452);
            this.tabFase.TabIndex = 1;
            this.tabFase.Text = "Fases do Projeto";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEditarAtividade);
            this.groupBox4.Controls.Add(this.btnNovaAtividade);
            this.groupBox4.Controls.Add(this.gridAtividade);
            this.groupBox4.Location = new System.Drawing.Point(7, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(795, 264);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Atividade (Selecione uma Fase)";
            // 
            // btnEditarAtividade
            // 
            this.btnEditarAtividade.Location = new System.Drawing.Point(111, 19);
            this.btnEditarAtividade.Name = "btnEditarAtividade";
            this.btnEditarAtividade.Size = new System.Drawing.Size(98, 23);
            this.btnEditarAtividade.TabIndex = 6;
            this.btnEditarAtividade.Text = "Editar Atividade";
            this.btnEditarAtividade.UseVisualStyleBackColor = true;
            this.btnEditarAtividade.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNovaAtividade
            // 
            this.btnNovaAtividade.Location = new System.Drawing.Point(7, 19);
            this.btnNovaAtividade.Name = "btnNovaAtividade";
            this.btnNovaAtividade.Size = new System.Drawing.Size(98, 23);
            this.btnNovaAtividade.TabIndex = 5;
            this.btnNovaAtividade.Text = "Incluir Atividade";
            this.btnNovaAtividade.UseVisualStyleBackColor = true;
            this.btnNovaAtividade.Click += new System.EventHandler(this.btnAtividade_Click);
            // 
            // gridAtividade
            // 
            this.gridAtividade.AllowUserToAddRows = false;
            this.gridAtividade.AllowUserToDeleteRows = false;
            this.gridAtividade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAtividade.Location = new System.Drawing.Point(7, 48);
            this.gridAtividade.MultiSelect = false;
            this.gridAtividade.Name = "gridAtividade";
            this.gridAtividade.ReadOnly = true;
            this.gridAtividade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAtividade.Size = new System.Drawing.Size(782, 213);
            this.gridAtividade.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridFase);
            this.groupBox3.Location = new System.Drawing.Point(7, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(795, 143);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fases";
            // 
            // gridFase
            // 
            this.gridFase.AllowUserToAddRows = false;
            this.gridFase.AllowUserToDeleteRows = false;
            this.gridFase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFase.Location = new System.Drawing.Point(7, 20);
            this.gridFase.MultiSelect = false;
            this.gridFase.Name = "gridFase";
            this.gridFase.ReadOnly = true;
            this.gridFase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFase.Size = new System.Drawing.Size(782, 114);
            this.gridFase.TabIndex = 0;
            this.gridFase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridFase_CellContentClick);
            // 
            // btnEditarFase
            // 
            this.btnEditarFase.Location = new System.Drawing.Point(88, 6);
            this.btnEditarFase.Name = "btnEditarFase";
            this.btnEditarFase.Size = new System.Drawing.Size(75, 23);
            this.btnEditarFase.TabIndex = 2;
            this.btnEditarFase.Text = "Editar Fase";
            this.btnEditarFase.UseVisualStyleBackColor = true;
            this.btnEditarFase.Click += new System.EventHandler(this.btnEditarFase_Click);
            // 
            // btnNovaFase
            // 
            this.btnNovaFase.Location = new System.Drawing.Point(6, 6);
            this.btnNovaFase.Name = "btnNovaFase";
            this.btnNovaFase.Size = new System.Drawing.Size(75, 23);
            this.btnNovaFase.TabIndex = 1;
            this.btnNovaFase.Text = "Nova Fase";
            this.btnNovaFase.UseVisualStyleBackColor = true;
            this.btnNovaFase.Click += new System.EventHandler(this.btnNovaFase_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(94, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // NovoProjeto
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 571);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSituacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NovoProjeto";
            this.Text = "Projeto";
            this.tabControl1.ResumeLayout(false);
            this.tabPlano.ResumeLayout(false);
            this.tabProjeto.ResumeLayout(false);
            this.tabProjeto.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipe)).EndInit();
            this.tabFase.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAtividade)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProjeto;
        private System.Windows.Forms.TabPage tabFase;
        private System.Windows.Forms.TabPage tabPlano;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.Button btnNovaFase;
        private System.Windows.Forms.Button btnEditarFase;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIncluirUsuario;
        private System.Windows.Forms.Button btnExcluirUsuario;
        private System.Windows.Forms.DataGridView gridEquipe;
        private System.Windows.Forms.MaskedTextBox dtFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView gridFase;
        private System.Windows.Forms.DataGridView gridAtividade;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.ComboBox cbPapel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEditarAtividade;
        private System.Windows.Forms.Button btnNovaAtividade;
        private System.Windows.Forms.RichTextBox txtPlanoProjeto;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtPrevista;

    }
}