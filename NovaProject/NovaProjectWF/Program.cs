using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovaProjectWF.View.Conta;
using NovaProjectWF.Models;
using NovaProjectWF.Dao;

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

            //using (var ctx = new Contexto())
            //{
            //    Projeto stud = new Projeto() ;

            //    ctx.Projeto.Add(stud);
            //    ctx.SaveChanges();
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
