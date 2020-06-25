using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> MensagensValidacao { get; set; }
        private List<string> MensagemValidacao 
        { 
            get { return MensagensValidacao ?? (MensagensValidacao = new List<string>()); } 
        }

        public abstract void Validate();
        protected void LimparMensagensDeValidacao()
        {
            MensagemValidacao.Clear();
        }
        protected void AdicionarMensagemDeValidacao(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }
        protected bool EhValido
        {
            get { return !MensagemValidacao.Any() ; }
        }
    }
}
