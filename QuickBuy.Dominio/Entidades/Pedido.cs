﻿using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        public int FormaPagamentoId { get; set; }
        public virtual ICollection<ItemPedido> ItensPedido { get; set; } 

        public override void Validate()
        {
            LimparMensagensDeValidacao();

            if (!ItensPedido.Any()) // Pedido deve ter pelo menos um item de pedido
                AdicionarMensagemDeValidacao("Aviso: Item de Pedido não pode ficar vazio!");

            if (string.IsNullOrEmpty(CEP))
                AdicionarMensagemDeValidacao("Aviso: CEP precisa ser preenchido!");

            if (FormaPagamentoId == 0)
                AdicionarMensagemDeValidacao("Aviso: Não foi informada a forma de pagamento!");
        }
    }
}
