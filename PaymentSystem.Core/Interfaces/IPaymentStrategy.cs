using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentSystem.Core.DTOs;
using PaymentSystem.Core.Enums;
using PaymentSystem.Core.Models;

namespace PaymentSystem.Core.Interfaces
{
    public interface IPaymentStrategy
    {
        PaymentType PaymentType { get; }
        Task<PaymentResult> PayAsync(PaymentRequest request, CancellationToken cancellationToken = default);
    }
}