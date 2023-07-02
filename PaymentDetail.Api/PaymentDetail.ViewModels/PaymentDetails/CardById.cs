namespace PaymentDetail.ViewModels.PaymentDetails;
 

public class CardById
{
    public CardById()
    {
        this.Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }

    public string CardOwnerName { get; init; } = null!;

    public string CardNumber { get; init; } = null!;

    public DateTime ExpirationDate { get; init; } 

    public string SecurityCode { get; init; } = null!;
}