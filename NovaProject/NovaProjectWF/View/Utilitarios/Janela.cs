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
        public static void Exibir(Form tela, Form parent)
        {
            if (parent != null)
            {
                tela.MdiParent = parent;
            }

            tela.StartPosition = FormStartPosition.CenterScreen;

            if (!tela.FormBorderStyle.Equals(FormBorderStyle.None))
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
            bool retorno = true;

            foreach (Form form in parent.MdiChildren)
            {
                if (form.GetType().Equals(tipoTela))
                {
                    retorno = false;
                }
            }

            return retorno;
        }


    }
}
