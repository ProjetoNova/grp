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

            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //string rtfText; //string to save to db
            //TextRange tr = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    tr.Save(ms, DataFormats.Rtf);
            //    rtfText = Encoding.ASCII.GetString(ms.ToArray());
            //}
        }

    }
}
