using PaymentSystem.Core.DTOs;
using PaymentSystem.Core.Enums;
using PaymentSystem.Core.Factory;
using PaymentSystem.Core.Implementations;
using PaymentSystem.Core.Interfaces;

namespace PlaymentSystem.App;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Pagamentos ===");

        IPaymentGateway gateway = new FakePaymentGateway();
        var factory = new PaymentStrategyFactory(gateway);

        System.Console.WriteLine("Digite o valor do pagamento: R$ ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal amount) || amount <= 0)
        {
            Console.WriteLine("Valor inválido.");
            return;
        }
        Console.WriteLine("\nSelecione o tipo de pagamento:");
        Console.WriteLine("1 - Cartão");
        Console.WriteLine("2 - Boleto");
        Console.WriteLine("3 - Pix");
        Console.Write("> ");

        if (!int.TryParse(Console.ReadLine(), out int option) || option < 1 || option > 3)
        {
            Console.WriteLine("Opção inválida.");
            return;
        }

        var type = (PaymentType)option;
        var strategy = factory.Create(type);

        var request = new PaymentRequest
        {
            Amount = amount,
            PaymentType = type,
            Description = $"Pagamento de R$ {amount} via {type}"

        };

        if (type == PaymentType.Pix)
        {
            Console.Write("\nInforme a chave PIX: ");
            request.PixKey = Console.ReadLine();
        }
        Console.WriteLine("\nProcessando pagamento...\n");
        var result = await strategy.PayAsync(request);

        Console.WriteLine("=== RESULTADO ===");
        Console.WriteLine($"Sucesso: {(result.Sucess ? "✅ SIM" : "❌ NÃO")}");
        Console.WriteLine($"Mensagem: {result.Message}");
        if (!string.IsNullOrWhiteSpace(result.TransactionId))
            Console.WriteLine($"ID da Transação: {result.TransactionId}");
        Console.WriteLine("==============================");


    }
}
