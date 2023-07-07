namespace PaymentDetail.ViewModels;


public class GetById
{
    public GetById()
    {
        this.Id = Guid.NewGuid();
    }
    
    public Guid Id { get; init; }

    public string CardOwnerName { get; init; } = null!;

    public string CardNumber { get; init; } = null!; 
    public string ExpirationDate { get; init; } = null!;

    public string CVV { get; init; } = null!;
}