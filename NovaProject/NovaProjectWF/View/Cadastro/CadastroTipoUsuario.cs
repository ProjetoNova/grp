using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NovaProjectWF.Models;
using NovaProjectWF.View.Utilitarios;
using NovaProjectWF.Dao;

namespace NovaProjectWF.View.Cadastro
{
    public partial class CadastroTipoUsuario : Form
    {

        public CadastroTipoUsuario()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim() == string.Empty) 
            {
                Mensagem.Erro("Nome não pode ser Nulo!");
            }
            else
            {
                TipoUsuario tipoUsuario = new TipoUsuario();

                tipoUsuario.descricao = txtNome.Text.Trim();

                CRUDTipoUsuario crud = new CRUDTipoUsuario();

                crud.insert(tipoUsuario);
            }
        }
    }
}
