using NovaProjectWF.Controllers.SessaoController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaProjectWF.View.Utilitarios
{
    class Janela
    {
        //Metodo para controle de exibicao das telas do sistema
        public static void Exibir(Form tela, Form parent, bool Controle)
        {

            if (Controle && !SessaoSistema.Administrador)
            {
                Mensagem.Erro("Você não tem permissão para acessar essa tela");
                return;
            }

            if (tela == null)
            {
                return;
            }

            if (parent != null)
            {
                tela.MdiParent = parent;
            }

            tela.StartPosition = FormStartPosition.CenterScreen;

            if (tela.FormBorderStyle.Equals(FormBorderStyle.Sizable))
            {
                tela.FormBorderStyle = FormBorderStyle.FixedSingle;
                tela.MaximizeBox = false;
            }

            if (tela.WindowState == FormWindowState.Minimized)
            {
                tela.WindowState = FormWindowState.Normal;
            }
            else if(tela.WindowState == FormWindowState.Maximized
                || tela.WindowState == FormWindowState.Normal)
            {
                tela.Focus();
            }
            else
            {
                tela.Show();
            }
        }

        //retorna true se a janela estiver fechada
        public static bool Fechada(Form parent, Type tipoTela)
        {
            bool retorno = false;

            if (JanelaAberta(parent, tipoTela) == null)
            {
                retorno = true;
            }

            return retorno;
        }

        public static Form JanelaAberta(Form parent, Type tipoTela)
        {
            Form retorno = null;

            foreach (Form form in parent.MdiChildren)
            {
                if (form.GetType().Equals(tipoTela))
                {
                    retorno = form;
                }
            }

            return retorno;
        }

    }
}
