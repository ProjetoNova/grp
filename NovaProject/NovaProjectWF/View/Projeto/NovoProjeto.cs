using NovaProjectWF.Models.Enumerados;
using NovaProjectWF.View.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaProjectWF.View.Projeto
{
    public partial class NovoProjeto : Form
    {
        public NovoProjeto()
        {
            InitializeComponent();

            cbSituacao.DataSource = SituacaoProjeto.GetList();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {


        }

    }
}
