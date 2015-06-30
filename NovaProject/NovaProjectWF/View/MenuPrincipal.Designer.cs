namespace NovaProjectWF.View
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoAtividadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meusProjetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoProjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhaContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.projetosToolStripMenuItem,
            this.contaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.tipoUsuarioToolStripMenuItem,
            this.tipoAtividadeToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // tipoUsuarioToolStripMenuItem
            // 
            this.tipoUsuarioToolStripMenuItem.Name = "tipoUsuarioToolStripMenuItem";
            this.tipoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tipoUsuarioToolStripMenuItem.Text = "Tipo Usuario";
            this.tipoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.tipoUsuarioToolStripMenuItem_Click);
            // 
            // tipoAtividadeToolStripMenuItem
            // 
            this.tipoAtividadeToolStripMenuItem.Name = "tipoAtividadeToolStripMenuItem";
            this.tipoAtividadeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tipoAtividadeToolStripMenuItem.Text = "Tipo Atividade";
            this.tipoAtividadeToolStripMenuItem.Click += new System.EventHandler(this.tipoAtividadeToolStripMenuItem_Click);
            // 
            // projetosToolStripMenuItem
            // 
            this.projetosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meusProjetosToolStripMenuItem,
            this.novoProjetoToolStripMenuItem});
            this.projetosToolStripMenuItem.Name = "projetosToolStripMenuItem";
            this.projetosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.projetosToolStripMenuItem.Text = "Projetos";
            // 
            // meusProjetosToolStripMenuItem
            // 
            this.meusProjetosToolStripMenuItem.Name = "meusProjetosToolStripMenuItem";
            this.meusProjetosToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.meusProjetosToolStripMenuItem.Text = "Meus Projetos";
            // 
            // novoProjetoToolStripMenuItem
            // 
            this.novoProjetoToolStripMenuItem.Name = "novoProjetoToolStripMenuItem";
            this.novoProjetoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.novoProjetoToolStripMenuItem.Text = "Novo Projeto";
            // 
            // contaToolStripMenuItem
            // 
            this.contaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minhaContaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            this.contaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.contaToolStripMenuItem.Text = "Conta";
            // 
            // minhaContaToolStripMenuItem
            // 
            this.minhaContaToolStripMenuItem.Name = "minhaContaToolStripMenuItem";
            this.minhaContaToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.minhaContaToolStripMenuItem.Text = "Minha Conta";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 26);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPrincipal";
            this.Text = "Nova Project";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoAtividadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meusProjetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoProjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minhaContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}