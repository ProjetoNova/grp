﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovaProjectWF.View.Cadastro;
using NovaProjectWF.View.Conta;
using NovaProjectWF.View.Projeto;
using NovaProjectWF.View.Utilitarios;

namespace NovaProjectWF.View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {

            DialogResult result =
               Mensagem.Confirmacao("Fechar Sistema", "Tem certeza que deseja sair do Sistema?");
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {
                //nao ta funcionando
            }
            
        }

        //Menu Cadastro de Usuario
        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario cadUsuario = new CadastroUsuario();

            cadUsuario.Show();
        }

        //Menu Cadastro de Tipo de Usuario
        private void tipoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroTipoUsuario cadTipUsuario = new CadastroTipoUsuario();

            cadTipUsuario.Show();
        }

        //Menu Cadastro de Tipo de Atividade
        private void tipoAtividadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroTipoAtividade cadTipoAtividade = new CadastroTipoAtividade();

            cadTipoAtividade.Show();
        }
        
        //Menu Meus Projetos
        private void meusProjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeusProjetos meusProjetos = new MeusProjetos();

            meusProjetos.Show();
        }

        //Menu Novo Projeto
        private void novoProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovoProjeto novoProj = new NovoProjeto();

            novoProj.Show();
        }

        //Menu Minha Conta
        private void minhaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MinhaConta minhaConta = new MinhaConta();

            minhaConta.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //IMPLEMENTAR METODO DE LOGOUT
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

       
    }
}