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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoAtividadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.situaçãoAtividadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meusProjetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoProjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhasAtividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhaContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarEmCascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladoALadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharTudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timeStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.projetosToolStripMenuItem,
            this.contaToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.janelasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(680, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.tipoUsuarioToolStripMenuItem,
            this.tipoAtividadeToolStripMenuItem,
            this.situaçãoAtividadeToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // tipoUsuarioToolStripMenuItem
            // 
            this.tipoUsuarioToolStripMenuItem.Name = "tipoUsuarioToolStripMenuItem";
            this.tipoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.tipoUsuarioToolStripMenuItem.Text = "Tipo Usuario";
            this.tipoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.tipoUsuarioToolStripMenuItem_Click);
            // 
            // tipoAtividadeToolStripMenuItem
            // 
            this.tipoAtividadeToolStripMenuItem.Name = "tipoAtividadeToolStripMenuItem";
            this.tipoAtividadeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.tipoAtividadeToolStripMenuItem.Text = "Tipo Atividade";
            this.tipoAtividadeToolStripMenuItem.Click += new System.EventHandler(this.tipoAtividadeToolStripMenuItem_Click);
            // 
            // situaçãoAtividadeToolStripMenuItem
            // 
            this.situaçãoAtividadeToolStripMenuItem.Name = "situaçãoAtividadeToolStripMenuItem";
            this.situaçãoAtividadeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.situaçãoAtividadeToolStripMenuItem.Text = "Situação Atividade";
            this.situaçãoAtividadeToolStripMenuItem.Click += new System.EventHandler(this.situaçãoAtividadeToolStripMenuItem_Click);
            // 
            // projetosToolStripMenuItem
            // 
            this.projetosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meusProjetosToolStripMenuItem,
            this.novoProjetoToolStripMenuItem,
            this.minhasAtividadesToolStripMenuItem});
            this.projetosToolStripMenuItem.Name = "projetosToolStripMenuItem";
            this.projetosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.projetosToolStripMenuItem.Text = "Projetos";
            // 
            // meusProjetosToolStripMenuItem
            // 
            this.meusProjetosToolStripMenuItem.Name = "meusProjetosToolStripMenuItem";
            this.meusProjetosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.meusProjetosToolStripMenuItem.Text = "Projetos";
            this.meusProjetosToolStripMenuItem.Click += new System.EventHandler(this.meusProjetosToolStripMenuItem_Click);
            // 
            // novoProjetoToolStripMenuItem
            // 
            this.novoProjetoToolStripMenuItem.Name = "novoProjetoToolStripMenuItem";
            this.novoProjetoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.novoProjetoToolStripMenuItem.Text = "Novo Projeto";
            this.novoProjetoToolStripMenuItem.Click += new System.EventHandler(this.novoProjetoToolStripMenuItem_Click);
            // 
            // minhasAtividadesToolStripMenuItem
            // 
            this.minhasAtividadesToolStripMenuItem.Name = "minhasAtividadesToolStripMenuItem";
            this.minhasAtividadesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.minhasAtividadesToolStripMenuItem.Text = "Minhas Atividades";
            this.minhasAtividadesToolStripMenuItem.Click += new System.EventHandler(this.minhasAtividadesToolStripMenuItem_Click);
            // 
            // contaToolStripMenuItem
            // 
            this.contaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minhaContaToolStripMenuItem,
            this.alterarSenhaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            this.contaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.contaToolStripMenuItem.Text = "Conta";
            // 
            // minhaContaToolStripMenuItem
            // 
            this.minhaContaToolStripMenuItem.Name = "minhaContaToolStripMenuItem";
            this.minhaContaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.minhaContaToolStripMenuItem.Text = "Minha Conta";
            this.minhaContaToolStripMenuItem.Click += new System.EventHandler(this.minhaContaToolStripMenuItem_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.ajudaToolStripMenuItem1});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.ajudaToolStripMenuItem.Text = "Sobre";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.inicioToolStripMenuItem.Text = "Tela de Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem1
            // 
            this.ajudaToolStripMenuItem1.Name = "ajudaToolStripMenuItem1";
            this.ajudaToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.ajudaToolStripMenuItem1.Text = "Sobre o Sistema";
            this.ajudaToolStripMenuItem1.Click += new System.EventHandler(this.ajudaToolStripMenuItem1_Click);
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarEmCascataToolStripMenuItem,
            this.ladoALadToolStripMenuItem,
            this.minimizarTudoToolStripMenuItem,
            this.restaurarTudoToolStripMenuItem,
            this.fecharTudoToolStripMenuItem});
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.janelasToolStripMenuItem.Text = "Janela";
            // 
            // visualizarEmCascataToolStripMenuItem
            // 
            this.visualizarEmCascataToolStripMenuItem.Name = "visualizarEmCascataToolStripMenuItem";
            this.visualizarEmCascataToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.visualizarEmCascataToolStripMenuItem.Text = "Visualizar em Cascata";
            this.visualizarEmCascataToolStripMenuItem.Click += new System.EventHandler(this.visualizarEmCascataToolStripMenuItem_Click);
            // 
            // ladoALadToolStripMenuItem
            // 
            this.ladoALadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verticalToolStripMenuItem,
            this.horizontalToolStripMenuItem});
            this.ladoALadToolStripMenuItem.Name = "ladoALadToolStripMenuItem";
            this.ladoALadToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ladoALadToolStripMenuItem.Text = "Lado a Lado";
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // minimizarTudoToolStripMenuItem
            // 
            this.minimizarTudoToolStripMenuItem.Name = "minimizarTudoToolStripMenuItem";
            this.minimizarTudoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.minimizarTudoToolStripMenuItem.Text = "Minimizar Tudo";
            this.minimizarTudoToolStripMenuItem.Click += new System.EventHandler(this.minimizarTudoToolStripMenuItem_Click);
            // 
            // restaurarTudoToolStripMenuItem
            // 
            this.restaurarTudoToolStripMenuItem.Name = "restaurarTudoToolStripMenuItem";
            this.restaurarTudoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.restaurarTudoToolStripMenuItem.Text = "Restaurar Tudo";
            this.restaurarTudoToolStripMenuItem.Click += new System.EventHandler(this.restaurarTudoToolStripMenuItem_Click);
            // 
            // fecharTudoToolStripMenuItem
            // 
            this.fecharTudoToolStripMenuItem.Name = "fecharTudoToolStripMenuItem";
            this.fecharTudoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.fecharTudoToolStripMenuItem.Text = "Fechar Tudo";
            this.fecharTudoToolStripMenuItem.Click += new System.EventHandler(this.fecharTudoToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timeStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 394);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(680, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timeStatus
            // 
            this.timeStatus.Name = "timeStatus";
            this.timeStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MenuPrincipal
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(680, 416);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova Project - Sistema de Gerencimento de Projetos";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem situaçãoAtividadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minhasAtividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel timeStatus;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarEmCascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladoALadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizarTudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarTudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharTudoToolStripMenuItem;
    }
}