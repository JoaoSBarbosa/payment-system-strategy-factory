
namespace PaymentSystem.Core.Models
{
    /*
    *
    */
    public class PaymentResult
    {
        public bool Sucess { get; init; }
        public string Message { get; init; } = string.Empty;
        public string? TransactionId { get; init; }
    }
}