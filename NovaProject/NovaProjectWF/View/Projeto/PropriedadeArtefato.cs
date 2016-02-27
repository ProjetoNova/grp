using NovaProjectWF.Controllers.ProjetoController;
using NovaProjectWF.Dao;
using NovaProjectWF.Models;
using NovaProjectWF.Models.NaoPersistido;
using NovaProjectWF.View.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaProjectWF.View.Projeto
{
    public partial class PropriedadeArtefato : Form
    {
        public PropriedadeArtefato()
        {
            InitializeComponent();
        }

        int id;
        ArtefatosProjeto artefato;

        public void Exibir(Form parent, Object obj)
        {
            artefato = (ArtefatosProjeto)obj;

            id = artefato.IdAnexo;

            this.lblNome.Text = artefato.NomeArquivo;
            this.lblTamanho.Text = artefato.TamanhoArquivo + " Bytes";
            this.lblData.Text = artefato.DataArquivo.ToString();
            this.lblResponsavel.Text = artefato.Responsavel;
            this.lblProjeto.Text = artefato.Projeto;
            this.txtObs.Text = artefato.Observacoes;

            if (Janela.Fechada(parent, this.GetType()))
            {
                Janela.Exibir(this, parent, true);
            }
            else
            {
                Janela.JanelaAberta(parent, this.GetType()).Close();
                Janela.Exibir(this, parent, true);
            }
        }

        private void btnSalvarArquivo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Salvar o Artefato no Computador Local";
            saveFileDialog1.FileName = artefato.NomeArquivo;
            saveFileDialog1.ShowDialog();

            AnexoProjetoDAO anexo = new AnexoProjetoDAO();

            BinaryWriter Writer = null;
            string Name = saveFileDialog1.FileName;
            byte[] Data  = ((AnexoProjeto)anexo.select(artefato.IdAnexo)).Anexo;

            try
            {
                // Create a new stream to write to the file
                Writer = new BinaryWriter(File.OpenWrite(Name));

                // Writer raw data                
                Writer.Write(Data);
                Writer.Flush();
                Writer.Close();
            }
            catch
            {
                MessageBox.Show("Problema ao Salvar Arquivo");
            }

        }
    }
}
