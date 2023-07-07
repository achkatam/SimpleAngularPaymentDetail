namespace PaymentDetail.ViewModels;

using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

public class AllPaymentDetails
{
    public AllPaymentDetails()
    {
        this.Id = Guid.NewGuid();
    }
    
    public Guid Id { get; init; }

    public string CardOwnerName { get; init; } = null!;

    public string CardNumber { get; init; } = null!;
    
    public string ExpirationDate { get; init; } = null!;

    public string CVV { get; init; } = null!;
}