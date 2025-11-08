using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PaymentSystem.Core.Enums;
using PaymentSystem.Core.Implementations;
using PaymentSystem.Core.Interfaces;

namespace PaymentSystem.Core.Factory
{
    public class PaymentStrategyFactory : IPaymentStrategyFactory
    {
        private readonly IPaymentGateway _gateway;
        private readonly IServiceProvider _provider;

        public PaymentStrategyFactory(IPaymentGateway gateway)
        {
            _gateway = gateway;
        }

        public IPaymentStrategy Create(PaymentType type)
        {
            return type switch
            {
                PaymentType.Card => new CardPaymentStrategy(_gateway),
                PaymentType.Boleto => new BoletoPaymentStrategy(_gateway),
                PaymentType.Pix => new PixPaymentStrategy(_gateway),
                _ => throw new NotImplementedException($"Tipo de pagamento não suportado {type}.")
            };
        }

    }
}