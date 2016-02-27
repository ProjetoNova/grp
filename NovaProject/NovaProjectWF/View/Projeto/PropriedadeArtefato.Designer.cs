namespace NovaProjectWF.View.Projeto
{
    partial class PropriedadeArtefato
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.btnSalvarArquivo = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.lblProjeto = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arquivo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamanho: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data do Artefato:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Responsável: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Projeto: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtObs);
            this.groupBox1.Location = new System.Drawing.Point(16, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 112);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observações:";
            // 
            // txtObs
            // 
            this.txtObs.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtObs.Location = new System.Drawing.Point(7, 20);
            this.txtObs.MaxLength = 500;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(344, 86);
            this.txtObs.TabIndex = 0;
            this.txtObs.Text = "";
            // 
            // btnSalvarArquivo
            // 
            this.btnSalvarArquivo.Location = new System.Drawing.Point(16, 164);
            this.btnSalvarArquivo.Name = "btnSalvarArquivo";
            this.btnSalvarArquivo.Size = new System.Drawing.Size(98, 23);
            this.btnSalvarArquivo.TabIndex = 6;
            this.btnSalvarArquivo.Text = "Baixar Arquivo...";
            this.btnSalvarArquivo.UseVisualStyleBackColor = true;
            this.btnSalvarArquivo.Click += new System.EventHandler(this.btnSalvarArquivo_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(153, 311);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(108, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "label6";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(108, 39);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(35, 13);
            this.lblTamanho.TabIndex = 9;
            this.lblTamanho.Text = "label6";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(108, 71);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 13);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "label6";
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Location = new System.Drawing.Point(108, 101);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(35, 13);
            this.lblResponsavel.TabIndex = 11;
            this.lblResponsavel.Text = "label6";
            // 
            // lblProjeto
            // 
            this.lblProjeto.AutoSize = true;
            this.lblProjeto.Location = new System.Drawing.Point(108, 134);
            this.lblProjeto.Name = "lblProjeto";
            this.lblProjeto.Size = new System.Drawing.Size(35, 13);
            this.lblProjeto.TabIndex = 12;
            this.lblProjeto.Text = "label6";
            // 
            // PropriedadeArtefato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(385, 341);
            this.Controls.Add(this.lblProjeto);
            this.Controls.Add(this.lblResponsavel);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnSalvarArquivo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PropriedadeArtefato";
            this.Text = "Propriedades do Artefato";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtObs;
        private System.Windows.Forms.Button btnSalvarArquivo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.Label lblProjeto;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}