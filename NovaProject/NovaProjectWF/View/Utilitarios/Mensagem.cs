﻿using System;
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
    public class Mensagem
    {
        //Mensagem de Confirmacao
        public static DialogResult Confirmacao()
        {
            //mensagem do tipo pergunta
            string mensagem = "Você deseja realizar esta operação?";
            //titulo da janela
            string titulo = "Confirmação";

            return Confirmacao(titulo, mensagem);
        }

        //Mensagem de Confirmacao
        public static DialogResult Confirmacao(string titulo, string mensagem)
        {
            MessageBoxButtons botao = MessageBoxButtons.YesNo;

            DialogResult resultado = MessageBox.Show(mensagem, titulo, botao);

            return resultado;
        }

        //Mensagem de Aviso
        public static void Aviso(string mensagem)
        {
            MessageBox.Show(mensagem, "Aviso", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        //Mensagem de Erro
        public static void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Mensagem de Informacao
        public static void Informacao(string mensagem)
        {
            MessageBox.Show(mensagem, "Informacao",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
