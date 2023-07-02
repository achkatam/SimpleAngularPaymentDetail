namespace PaymentDetail.ViewModels.PaymentDetails;

using System.ComponentModel.DataAnnotations;

using static  Common.EntityValidations.PaymentValidations;
public class CreateRequestModel
{
    public CreateRequestModel()
    {
        this.Id = Guid.NewGuid();
    }

    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(CARD_OWNER_NAME_MAX_LENGTH, MinimumLength = CARD_OWNER_NAME_MIN_LENGTH)]
    public string CardOwnerName { get; init; } = null!;

    [Required]
    [StringLength(CARD_NUMBER_MAX_LENGTH, MinimumLength = CARD_OWNER_NAME_MIN_LENGTH)]
    public string CardNumber { get; init; } = null!;

    [Required]
    [DisplayFormat(DataFormatString = "{MM/YY}", ApplyFormatInEditMode = true)]
    [DataType(DataType.DateTime)]
    public DateTime ExpirationDate { get; init; }  

    [Required]
    [StringLength(SECURITY_CODE_MAX_LENGTH, MinimumLength = SECURITY_CODE_MIN_LENGTH)]
    public string SecurityCode { get; init; } = null!;
}