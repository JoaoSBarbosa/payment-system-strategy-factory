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
    public class PixPaymentStrategy : IPaymentStrategy
    {
        public PaymentType PaymentType => PaymentType.Pix;

        private readonly IPaymentGateway _gateway;
        public PixPaymentStrategy(IPaymentGateway gateway)
        {
            _gateway = gateway;
        }

        public async Task<PaymentResult> PayAsync(PaymentRequest request, CancellationToken cancellationToken = default)
        {

            if (request.Amount <= 0) return new PaymentResult { Sucess = false, Message = "Valor inválido" };
            if (string.IsNullOrWhiteSpace(request.PixKey)) return new PaymentResult { Sucess = false, Message = "Chave PIX ausente" };

            var txId = await _gateway.ProcessPaymentAsync(new { request.Amount, request.Description, request.PixKey }, cancellationToken);


            return new PaymentResult { Sucess = true, TransactionId = txId, Message = $"Pagamento via PIX de R$ {request.Amount} realizado com sucesso para chave {request.PixKey}" };



        }


    }


}