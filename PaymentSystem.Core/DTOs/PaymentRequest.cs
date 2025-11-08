using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentSystem.Core.Enums;

namespace PaymentSystem.Core.DTOs
{
    public class PaymentRequest()
    {
        public decimal Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public PaymentType PaymentType { get; set; }

        // Dados específicos do pagamento
        public string? PixKey { get; set; }
        public string? CardNumber { get; set; }
        public string? CardHolder { get; set; }
        public string? BoletoNumber { get; set; }
    }
}