using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovaProjectWF.View.Conta;
using System.Data.Entity;

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
            Application.Run(new Login());
            Database.SetInitializer(new NovaProjectWF.Dao.Contexto.MyInitializer());
        }
    }
}
