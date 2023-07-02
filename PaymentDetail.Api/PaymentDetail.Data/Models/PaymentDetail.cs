namespace PaymentDetail.Data.Models;

using System.ComponentModel.DataAnnotations;

using static Common.EntityValidations.PaymentValidations;
public class PaymentDetail
{
    public PaymentDetail()
    {
        this.Id = Guid.NewGuid();
    }

    [Key]
    public Guid Id{ get; set; }

    [Required]
    [MaxLength(CARD_OWNER_NAME_MAX_LENGTH)]
    public string CardOwnerName { get; init; } = null!;

    [Required]
    [MaxLength(CARD_NUMBER_MAX_LENGTH)]
    public string CardNumber { get; init; } = null!;

    [DisplayFormat(DataFormatString = "{MM/YY}", ApplyFormatInEditMode = true)]
    [DataType(DataType.DateTime)]
    public DateTime ExpirationDate { get; init; }  

    [Required]
    [MaxLength(SECURITY_CODE_MAX_LENGTH)]
    public string SecurityCode { get; init; } = null!;
}