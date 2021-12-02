﻿using ExercicioApiEcommerce.DTOs;
using ExercicioApiEcommerce.Enumeradores;
using System;

namespace ExercicioApiEcommerce.DTOs
{
    public class PagamentoDTO : Validator
    {
        public Guid IdPedido { get; set; }
        public EFormaPagamento FormaPagamento { get; set; }
        public PagamentoPixDTO? PagamentoPix { get; set; }
        public PagamentoBoletoDTO? PagamentoBoleto { get; set; }
        public PagamentoCartoDebitoDTO? PagamentoCartaoDebito { get; set; }
        public PagamentoCartaoCreditoDTO? PagamentoCartaoCredito { get; set; }

        public override void Validar()
        {
            Valido = true;

            if(FormaPagamento != EFormaPagamento.CartaoDebito &&
               FormaPagamento != EFormaPagamento.CartaoCredito &&
               FormaPagamento != EFormaPagamento.Pix &&
               FormaPagamento != EFormaPagamento.Boleto)
               Valido = false;

            if (PagamentoPix is null &&
                PagamentoBoleto is null &&
                PagamentoCartaoDebito is null &&
                PagamentoCartaoCredito is null)
                Valido = false;

        }

    }
}
