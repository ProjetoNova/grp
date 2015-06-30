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
                tela.WindowState = FormWindowState.Maximized;
                tela.Show();
            }
        }

        //retorna true se a janela estiver fechada
        public static bool Fechada(Form tela)
        {
            return (tela == null || tela.Disposing);
        }
    }
}
