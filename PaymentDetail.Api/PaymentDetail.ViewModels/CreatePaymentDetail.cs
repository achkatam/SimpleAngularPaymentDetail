namespace PaymentDetail.ViewModels;

using System.ComponentModel.DataAnnotations;

using static Common.EntityValidations.PaymentValidations;

public class CreatePaymentDetail
{
    public CreatePaymentDetail()
    {
        this.Id = Guid.NewGuid();
    }

    [Key]
    public Guid Id { get; init; }

    [Required]
    [StringLength(CARD_OWNER_NAME_MAX_LENGTH, MinimumLength = CARD_OWNER_NAME_MIN_LENGTH)]
    public string CardOwnerName { get; init; } = null!;

    [Required]
    [StringLength(CARD_NUMBER_MAX_LENGTH, MinimumLength = CARD_NUMBER_MIN_LENGTH)]
    public string CardNumber { get; init; } = null!;

    [RegularExpression(DATE_PATTERN, ErrorMessage = "Follow the pattern MM/yy")]
    public string ExpirationDate { get; init; } = null!;

    [Required]
    [StringLength(SECURITY_CODE_MAX_LENGTH, MinimumLength = SECURITY_CODE_MIN_LENGTH)]
    [RegularExpression(CVV_PATTERN)]
    public string CVV { get; init; } = null!;
}