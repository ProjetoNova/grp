using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using NovaProjectWF.View.Conta;
using NovaProjectWF.View;
using System.Data.Entity;
using NovaProjectWF.Controllers.CadastroController;


namespace NovaProjectWF
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Iniciando frmSplash = new Iniciando();
            frmSplash.Show();
            Application.DoEvents();

            Database.SetInitializer(new NovaProjectWF.Dao.Contexto.MyInitializer());

            UsuarioController control = new UsuarioController();
            TipoUsuarioController tControl = new TipoUsuarioController();
            SituacaoAtividadeController saControl = new SituacaoAtividadeController();
            TipoAtividadeController taControl = new TipoAtividadeController();

            if (control.TodosOsDados().Count == 0)
            {
                tControl.Salvar("0", "Administrador", true, true);
                control.Salvar("0", "Sistema", "", "", "", "sistema", "1234", "1234", "", true, 1, true);
                saControl.Salvar("0", "Não Iniciada", true, false);
                saControl.Salvar("0", "Iniciada", true, false);
                saControl.Salvar("0", "Concluída", true, true);
                taControl.Salvar("0", "Desenvolvimento", true);

            }

            frmSplash.Dispose();
            Application.Run(new Login());
        }
    }
}
