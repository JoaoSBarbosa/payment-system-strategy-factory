using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentSystem.Core.Enums;

namespace PaymentSystem.Core.Interfaces
{
    public interface IPaymentStrategyFactory
    {
        IPaymentStrategy Create(PaymentType type);
    }
}