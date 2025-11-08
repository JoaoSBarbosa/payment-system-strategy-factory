using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSystem.Core.Interfaces
{

    // representa gateway externo ( strip, banco, etc) 
    public interface IPaymentGateway
    {
        Task<string> ProcessPaymentAsync(object payload, CancellationToken cancellationToken = default);
    }
}