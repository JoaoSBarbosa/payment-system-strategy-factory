using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentSystem.Core.DTOs;
using PaymentSystem.Core.Enums;
using PaymentSystem.Core.Interfaces;
using PaymentSystem.Core.Models;

namespace PaymentSystem.Core.Implementations
{
    public class CardPaymentStrategy : IPaymentStrategy
    {
        private readonly IPaymentGateway _gateway;
        public PaymentType PaymentType => PaymentType.Card;

        public CardPaymentStrategy(IPaymentGateway gateway)
        {
            _gateway = gateway;
        }
        public async Task<PaymentResult> PayAsync(PaymentRequest request, CancellationToken cancellationToken = default)
        {
            if (request.Amount <= 0) return new PaymentResult { Sucess = false, Message = "Valor inválido" };

            // simulando -> chamada de gateway real com os dados do cartão (payload simplificado)
            var txId = await _gateway.ProcessPaymentAsync(new { request.Amount, request.Description }, cancellationToken);

            return new PaymentResult { Sucess = true, TransactionId = txId, Message = "Pagamento com cartão realizado com sucesso" };
        }
    }
}