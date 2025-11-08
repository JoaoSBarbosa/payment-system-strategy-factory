using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSystem.Core.DTOs
{
    public record PaymentRequest(decimal Amount, string Description);
}