
using PaymentSystem.Core.DTOs;
using PaymentSystem.Core.Enums;
using PaymentSystem.Core.Interfaces;
using PaymentSystem.Core.Models;

namespace PaymentSystem.Core.Implementations
{
    public class BoletoPaymentStrategy : IPaymentStrategy
    {

        private readonly IPaymentGateway _gateway;
        public PaymentType PaymentType => PaymentType.Boleto;
        public BoletoPaymentStrategy(IPaymentGateway gateway)
        {
            _gateway = gateway;
        }

        public async Task<PaymentResult> PayAsync(PaymentRequest request, CancellationToken cancellationToken = default)
        {
            if (request.Amount <= 0) return new PaymentResult { Sucess = false, Message = "Valor inválido" };

            // gera boleto 
            var txId = await _gateway.ProcessPaymentAsync(new { request.Amount, request.Description }, cancellationToken);
            return new PaymentResult { Sucess = true, TransactionId = txId, Message = "Boleto gerado com sucesso" };
        }
    }
}