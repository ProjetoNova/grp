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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridEquipe = new System.Windows.Forms.DataGridView();
            this.btnExcluirUsuario = new System.Windows.Forms.Button();
            this.btnIncluirUsuario = new System.Windows.Forms.Button();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtPrevista = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gridAtividade = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridFase = new System.Windows.Forms.DataGridView();
            this.btnAtividade = new System.Windows.Forms.Button();
            this.btnEditarFase = new System.Windows.Forms.Button();
            this.btnNovaFase = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gridAnexos = new System.Windows.Forms.DataGridView();
            this.btnEnviarArquivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEscolherArquivo = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.txtPlanoProjeto = new RicherTextBox.RicherTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipe)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtividade)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFase)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnexos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(13, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 518);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.lblStatus);
            this.tabPage1.Controls.Add(this.dtFim);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.cbSituacao);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtDescricao);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dtPrevista);
            this.tabPage1.Controls.Add(this.dtInicio);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Projeto";
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
            this.dtFim.Location = new System.Drawing.Point(512, 87);
            this.dtFim.Mask = "00/00/0000";
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(68, 20);
            this.dtFim.TabIndex = 22;
            this.dtFim.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Data Fim:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridEquipe);
            this.groupBox2.Controls.Add(this.btnExcluirUsuario);
            this.groupBox2.Controls.Add(this.btnIncluirUsuario);
            this.groupBox2.Location = new System.Drawing.Point(9, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(791, 368);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipe do Projeto";
            // 
            // gridEquipe
            // 
            this.gridEquipe.AllowUserToAddRows = false;
            this.gridEquipe.AllowUserToDeleteRows = false;
            this.gridEquipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEquipe.Location = new System.Drawing.Point(7, 50);
            this.gridEquipe.Name = "gridEquipe";
            this.gridEquipe.ReadOnly = true;
            this.gridEquipe.Size = new System.Drawing.Size(778, 312);
            this.gridEquipe.TabIndex = 2;
            // 
            // btnExcluirUsuario
            // 
            this.btnExcluirUsuario.Location = new System.Drawing.Point(89, 19);
            this.btnExcluirUsuario.Name = "btnExcluirUsuario";
            this.btnExcluirUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirUsuario.TabIndex = 1;
            this.btnExcluirUsuario.Text = "Excluir";
            this.btnExcluirUsuario.UseVisualStyleBackColor = true;
            // 
            // btnIncluirUsuario
            // 
            this.btnIncluirUsuario.Location = new System.Drawing.Point(7, 20);
            this.btnIncluirUsuario.Name = "btnIncluirUsuario";
            this.btnIncluirUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirUsuario.TabIndex = 0;
            this.btnIncluirUsuario.Text = "Incluir Colaborador";
            this.btnIncluirUsuario.UseVisualStyleBackColor = true;
            // 
            // cbSituacao
            // 
            this.cbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Location = new System.Drawing.Point(512, 46);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(180, 21);
            this.cbSituacao.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(440, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Situação:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(79, 46);
            this.txtDescricao.MaxLength = 255;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(355, 61);
            this.txtDescricao.TabIndex = 4;
            this.txtDescricao.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Descrição:";
            // 
            // dtPrevista
            // 
            this.dtPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPrevista.Location = new System.Drawing.Point(698, 7);
            this.dtPrevista.Name = "dtPrevista";
            this.dtPrevista.Size = new System.Drawing.Size(102, 20);
            this.dtPrevista.TabIndex = 3;
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(512, 7);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(98, 20);
            this.dtInicio.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data Prevista:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Data Início: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 7);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(357, 20);
            this.txtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.btnAtividade);
            this.tabPage2.Controls.Add(this.btnEditarFase);
            this.tabPage2.Controls.Add(this.btnNovaFase);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(808, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fases do Projeto";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gridAtividade);
            this.groupBox4.Location = new System.Drawing.Point(7, 224);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(795, 262);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Atividade (Selecione uma Fase)";
            // 
            // gridAtividade
            // 
            this.gridAtividade.AllowUserToAddRows = false;
            this.gridAtividade.AllowUserToDeleteRows = false;
            this.gridAtividade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAtividade.Location = new System.Drawing.Point(7, 20);
            this.gridAtividade.Name = "gridAtividade";
            this.gridAtividade.ReadOnly = true;
            this.gridAtividade.Size = new System.Drawing.Size(782, 236);
            this.gridAtividade.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridFase);
            this.groupBox3.Location = new System.Drawing.Point(7, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(795, 181);
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
            this.gridFase.Name = "gridFase";
            this.gridFase.ReadOnly = true;
            this.gridFase.Size = new System.Drawing.Size(782, 155);
            this.gridFase.TabIndex = 0;
            // 
            // btnAtividade
            // 
            this.btnAtividade.Location = new System.Drawing.Point(170, 7);
            this.btnAtividade.Name = "btnAtividade";
            this.btnAtividade.Size = new System.Drawing.Size(75, 23);
            this.btnAtividade.TabIndex = 4;
            this.btnAtividade.Text = "Atividade";
            this.btnAtividade.UseVisualStyleBackColor = true;
            // 
            // btnEditarFase
            // 
            this.btnEditarFase.Location = new System.Drawing.Point(88, 6);
            this.btnEditarFase.Name = "btnEditarFase";
            this.btnEditarFase.Size = new System.Drawing.Size(75, 23);
            this.btnEditarFase.TabIndex = 2;
            this.btnEditarFase.Text = "Editar Fase";
            this.btnEditarFase.UseVisualStyleBackColor = true;
            // 
            // btnNovaFase
            // 
            this.btnNovaFase.Location = new System.Drawing.Point(6, 6);
            this.btnNovaFase.Name = "btnNovaFase";
            this.btnNovaFase.Size = new System.Drawing.Size(75, 23);
            this.btnNovaFase.TabIndex = 1;
            this.btnNovaFase.Text = "Nova Fase";
            this.btnNovaFase.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.txtPlanoProjeto);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(808, 492);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Plano de Projeto";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.gridAnexos);
            this.tabPage4.Controls.Add(this.btnEnviarArquivo);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.btnEscolherArquivo);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(808, 492);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Anexos";
            // 
            // gridAnexos
            // 
            this.gridAnexos.AllowUserToAddRows = false;
            this.gridAnexos.AllowUserToDeleteRows = false;
            this.gridAnexos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAnexos.Location = new System.Drawing.Point(7, 36);
            this.gridAnexos.Name = "gridAnexos";
            this.gridAnexos.ReadOnly = true;
            this.gridAnexos.Size = new System.Drawing.Size(795, 450);
            this.gridAnexos.TabIndex = 77;
            // 
            // btnEnviarArquivo
            // 
            this.btnEnviarArquivo.Enabled = false;
            this.btnEnviarArquivo.Location = new System.Drawing.Point(296, 7);
            this.btnEnviarArquivo.Name = "btnEnviarArquivo";
            this.btnEnviarArquivo.Size = new System.Drawing.Size(107, 23);
            this.btnEnviarArquivo.TabIndex = 67;
            this.btnEnviarArquivo.Text = "Enviar Arquivo";
            this.btnEnviarArquivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nenhum Arquivo Selecionado";
            // 
            // btnEscolherArquivo
            // 
            this.btnEscolherArquivo.Location = new System.Drawing.Point(7, 6);
            this.btnEscolherArquivo.Name = "btnEscolherArquivo";
            this.btnEscolherArquivo.Size = new System.Drawing.Size(119, 23);
            this.btnEscolherArquivo.TabIndex = 76;
            this.btnEscolherArquivo.Text = "Escolher Arquivo...";
            this.btnEscolherArquivo.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(94, 12);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
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
            // open
            // 
            this.open.FileName = "openFileDialog1";
            // 
            // txtPlanoProjeto
            // 
            this.txtPlanoProjeto.AlignCenterVisible = true;
            this.txtPlanoProjeto.AlignLeftVisible = true;
            this.txtPlanoProjeto.AlignRightVisible = true;
            this.txtPlanoProjeto.BoldVisible = true;
            this.txtPlanoProjeto.BulletsVisible = true;
            this.txtPlanoProjeto.ChooseFontVisible = true;
            this.txtPlanoProjeto.FindReplaceVisible = true;
            this.txtPlanoProjeto.FontColorVisible = true;
            this.txtPlanoProjeto.FontFamilyVisible = true;
            this.txtPlanoProjeto.FontSizeVisible = true;
            this.txtPlanoProjeto.GroupAlignmentVisible = true;
            this.txtPlanoProjeto.GroupBoldUnderlineItalicVisible = true;
            this.txtPlanoProjeto.GroupFontColorVisible = true;
            this.txtPlanoProjeto.GroupFontNameAndSizeVisible = true;
            this.txtPlanoProjeto.GroupIndentationAndBulletsVisible = true;
            this.txtPlanoProjeto.GroupInsertVisible = true;
            this.txtPlanoProjeto.GroupSaveAndLoadVisible = true;
            this.txtPlanoProjeto.GroupZoomVisible = true;
            this.txtPlanoProjeto.INDENT = 10;
            this.txtPlanoProjeto.IndentVisible = true;
            this.txtPlanoProjeto.InsertPictureVisible = true;
            this.txtPlanoProjeto.ItalicVisible = true;
            this.txtPlanoProjeto.LoadVisible = true;
            this.txtPlanoProjeto.Location = new System.Drawing.Point(6, 15);
            this.txtPlanoProjeto.Name = "txtPlanoProjeto";
            this.txtPlanoProjeto.OutdentVisible = true;
            this.txtPlanoProjeto.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1046{\\fonttbl{\\f0\\fnil\\fcharset204 Microsoft" +
    " Sans Serif;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs18\\par\r\n}\r\n";
            this.txtPlanoProjeto.SaveVisible = true;
            this.txtPlanoProjeto.SeparatorAlignVisible = true;
            this.txtPlanoProjeto.SeparatorBoldUnderlineItalicVisible = true;
            this.txtPlanoProjeto.SeparatorFontColorVisible = true;
            this.txtPlanoProjeto.SeparatorFontVisible = true;
            this.txtPlanoProjeto.SeparatorIndentAndBulletsVisible = true;
            this.txtPlanoProjeto.SeparatorInsertVisible = true;
            this.txtPlanoProjeto.SeparatorSaveLoadVisible = true;
            this.txtPlanoProjeto.Size = new System.Drawing.Size(796, 474);
            this.txtPlanoProjeto.TabIndex = 10;
            this.txtPlanoProjeto.ToolStripVisible = true;
            this.txtPlanoProjeto.UnderlineVisible = true;
            this.txtPlanoProjeto.WordWrapVisible = true;
            this.txtPlanoProjeto.ZoomFactorTextVisible = true;
            this.txtPlanoProjeto.ZoomInVisible = true;
            this.txtPlanoProjeto.ZoomOutVisible = true;
            // 
            // NovoProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 571);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tabControl1);
            this.Name = "NovoProjeto";
            this.Text = "Projeto";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEquipe)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAtividade)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFase)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAnexos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnEnviarArquivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEscolherArquivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtPrevista;
        private System.Windows.Forms.DateTimePicker dtInicio;
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
        private System.Windows.Forms.DataGridView gridAnexos;
        private System.Windows.Forms.Button btnAtividade;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView gridFase;
        private System.Windows.Forms.DataGridView gridAtividade;
        private System.Windows.Forms.SaveFileDialog save;
        private System.Windows.Forms.OpenFileDialog open;
        private RicherTextBox.RicherTextBox txtPlanoProjeto;

    }
}