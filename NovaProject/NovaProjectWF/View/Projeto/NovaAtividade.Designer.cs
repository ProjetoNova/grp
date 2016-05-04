namespace NovaProjectWF.View.Projeto
{
    partial class NovaAtividade
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
            this.btnLiberar = new System.Windows.Forms.Button();
            this.dtFim = new System.Windows.Forms.TextBox();
            this.txtFase = new System.Windows.Forms.TextBox();
            this.txtProjeto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbSituacao = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.txtEstimado = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtPrevista = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cbAtribuidoPara = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPrioridade = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTipoAtividade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridEvolucao = new System.Windows.Forms.DataGridView();
            this.txtComentario = new System.Windows.Forms.RichTextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEvolucao)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 525);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnLiberar);
            this.tabPage1.Controls.Add(this.dtFim);
            this.tabPage1.Controls.Add(this.txtFase);
            this.tabPage1.Controls.Add(this.txtProjeto);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.cbSituacao);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.dtPrevista);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.dtInicio);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.cbAtribuidoPara);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cbPrioridade);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cbTipoAtividade);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lblId);
            this.tabPage1.Controls.Add(this.btnSalvar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Atividade";
            // 
            // btnLiberar
            // 
            this.btnLiberar.BackColor = System.Drawing.Color.Red;
            this.btnLiberar.Location = new System.Drawing.Point(97, 6);
            this.btnLiberar.Name = "btnLiberar";
            this.btnLiberar.Size = new System.Drawing.Size(113, 23);
            this.btnLiberar.TabIndex = 44;
            this.btnLiberar.Text = "Liberar Atividade";
            this.btnLiberar.UseVisualStyleBackColor = false;
            this.btnLiberar.Click += new System.EventHandler(this.btnLiberar_Click);
            // 
            // dtFim
            // 
            this.dtFim.Enabled = false;
            this.dtFim.Location = new System.Drawing.Point(9, 391);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(138, 20);
            this.dtFim.TabIndex = 43;
            // 
            // txtFase
            // 
            this.txtFase.Enabled = false;
            this.txtFase.Location = new System.Drawing.Point(546, 47);
            this.txtFase.Name = "txtFase";
            this.txtFase.Size = new System.Drawing.Size(255, 20);
            this.txtFase.TabIndex = 42;
            // 
            // txtProjeto
            // 
            this.txtProjeto.Enabled = false;
            this.txtProjeto.Location = new System.Drawing.Point(156, 45);
            this.txtProjeto.Name = "txtProjeto";
            this.txtProjeto.Size = new System.Drawing.Size(293, 20);
            this.txtProjeto.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Situação *";
            // 
            // cbSituacao
            // 
            this.cbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSituacao.FormattingEnabled = true;
            this.cbSituacao.Location = new System.Drawing.Point(6, 183);
            this.cbSituacao.Name = "cbSituacao";
            this.cbSituacao.Size = new System.Drawing.Size(144, 21);
            this.cbSituacao.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(9, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(97, 66);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "#";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maskedTextBox3);
            this.groupBox2.Controls.Add(this.txtEstimado);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(7, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 69);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tempo";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(54, 37);
            this.maskedTextBox3.Mask = "00:00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(42, 20);
            this.maskedTextBox3.TabIndex = 2;
            this.maskedTextBox3.ValidatingType = typeof(System.DateTime);
            // 
            // txtEstimado
            // 
            this.txtEstimado.Location = new System.Drawing.Point(8, 37);
            this.txtEstimado.Mask = "00:00";
            this.txtEstimado.Name = "txtEstimado";
            this.txtEstimado.Size = new System.Drawing.Size(42, 20);
            this.txtEstimado.TabIndex = 1;
            this.txtEstimado.Text = "0100";
            this.txtEstimado.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Estimado * / Gasto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 374);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Data Fim *";
            // 
            // dtPrevista
            // 
            this.dtPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPrevista.Location = new System.Drawing.Point(7, 347);
            this.dtPrevista.Name = "dtPrevista";
            this.dtPrevista.Size = new System.Drawing.Size(140, 20);
            this.dtPrevista.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Data Prevista *";
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(7, 308);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(140, 20);
            this.dtInicio.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Data Início *";
            // 
            // cbAtribuidoPara
            // 
            this.cbAtribuidoPara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAtribuidoPara.FormattingEnabled = true;
            this.cbAtribuidoPara.Location = new System.Drawing.Point(6, 264);
            this.cbAtribuidoPara.Name = "cbAtribuidoPara";
            this.cbAtribuidoPara.Size = new System.Drawing.Size(141, 21);
            this.cbAtribuidoPara.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Prioridade *";
            // 
            // cbPrioridade
            // 
            this.cbPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrioridade.FormattingEnabled = true;
            this.cbPrioridade.Location = new System.Drawing.Point(6, 223);
            this.cbPrioridade.Name = "cbPrioridade";
            this.cbPrioridade.Size = new System.Drawing.Size(141, 21);
            this.cbPrioridade.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Atribuído para *";
            // 
            // cbTipoAtividade
            // 
            this.cbTipoAtividade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoAtividade.FormattingEnabled = true;
            this.cbTipoAtividade.Location = new System.Drawing.Point(6, 143);
            this.cbTipoAtividade.Name = "cbTipoAtividade";
            this.cbTipoAtividade.Size = new System.Drawing.Size(145, 21);
            this.cbTipoAtividade.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tipo de Atividade *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fase do Projeto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Projeto:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Location = new System.Drawing.Point(157, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 376);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(7, 20);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(631, 350);
            this.txtDescricao.TabIndex = 12;
            this.txtDescricao.Text = "";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(76, 91);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 15;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(15, 6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Título: *";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(156, 91);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(645, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "(Campos com * são obrigatórios)";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEnviar);
            this.tabPage2.Controls.Add(this.txtComentario);
            this.tabPage2.Controls.Add(this.gridEvolucao);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(808, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Evolução";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridEvolucao
            // 
            this.gridEvolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEvolucao.Location = new System.Drawing.Point(6, 6);
            this.gridEvolucao.Name = "gridEvolucao";
            this.gridEvolucao.Size = new System.Drawing.Size(796, 399);
            this.gridEvolucao.TabIndex = 0;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(7, 412);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(707, 81);
            this.txtComentario.TabIndex = 1;
            this.txtComentario.Text = "";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(720, 411);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(82, 81);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // NovaAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 549);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Name = "NovaAtividade";
            this.Text = "Atividade";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEvolucao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipoAtividade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.ComboBox cbPrioridade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbAtribuidoPara;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtPrevista;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox txtEstimado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbSituacao;
        private System.Windows.Forms.TextBox txtFase;
        private System.Windows.Forms.TextBox txtProjeto;
        private System.Windows.Forms.TextBox dtFim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLiberar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.RichTextBox txtComentario;
        private System.Windows.Forms.DataGridView gridEvolucao;
    }
}