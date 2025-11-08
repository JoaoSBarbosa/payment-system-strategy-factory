using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentSystem.Core.Interfaces;

namespace PaymentSystem.Core.Implementations
{
    public class FakePaymentGateway : IPaymentGateway
    {
        public async Task<string> ProcessPaymentAsync(object payload, CancellationToken cancellationToken = default)
        {
            // Simulação de processamento
            await Task.Delay(1000, cancellationToken);
            return Guid.NewGuid().ToString("N")[..12].ToUpper(); // Gera um ID fake
        }
    }
}