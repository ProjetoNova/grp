﻿namespace NovaProjectWF.View
{
    partial class Inicio
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
            this.btnNovoProjeto = new System.Windows.Forms.Button();
            this.btnAtividades = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblFechar = new System.Windows.Forms.Label();
            this.btnProjetos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seja Bem Vindo!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "O que gostaria de fazer?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNovoProjeto
            // 
            this.btnNovoProjeto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovoProjeto.Location = new System.Drawing.Point(110, 225);
            this.btnNovoProjeto.Name = "btnNovoProjeto";
            this.btnNovoProjeto.Size = new System.Drawing.Size(191, 35);
            this.btnNovoProjeto.TabIndex = 2;
            this.btnNovoProjeto.Text = "Novo Projeto...";
            this.btnNovoProjeto.UseVisualStyleBackColor = false;
            this.btnNovoProjeto.Click += new System.EventHandler(this.btnNovoProjeto_Click);
            // 
            // btnAtividades
            // 
            this.btnAtividades.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAtividades.Location = new System.Drawing.Point(110, 283);
            this.btnAtividades.Name = "btnAtividades";
            this.btnAtividades.Size = new System.Drawing.Size(191, 35);
            this.btnAtividades.TabIndex = 3;
            this.btnAtividades.Text = "Minhas Atividades...";
            this.btnAtividades.UseVisualStyleBackColor = false;
            this.btnAtividades.Click += new System.EventHandler(this.btnVerProjetos_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSair.Location = new System.Drawing.Point(110, 338);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(191, 35);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair do Sistema";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblFechar
            // 
            this.lblFechar.AutoSize = true;
            this.lblFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechar.Location = new System.Drawing.Point(384, 9);
            this.lblFechar.Name = "lblFechar";
            this.lblFechar.Size = new System.Drawing.Size(17, 17);
            this.lblFechar.TabIndex = 5;
            this.lblFechar.Text = "X";
            this.lblFechar.Click += new System.EventHandler(this.lblFechar_Click);
            // 
            // btnProjetos
            // 
            this.btnProjetos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProjetos.Location = new System.Drawing.Point(110, 170);
            this.btnProjetos.Name = "btnProjetos";
            this.btnProjetos.Size = new System.Drawing.Size(191, 35);
            this.btnProjetos.TabIndex = 6;
            this.btnProjetos.Text = "Projetos...";
            this.btnProjetos.UseVisualStyleBackColor = false;
            this.btnProjetos.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(413, 433);
            this.ControlBox = false;
            this.Controls.Add(this.btnProjetos);
            this.Controls.Add(this.lblFechar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAtividades);
            this.Controls.Add(this.btnNovoProjeto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNovoProjeto;
        private System.Windows.Forms.Button btnAtividades;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblFechar;
        private System.Windows.Forms.Button btnProjetos;
    }
}