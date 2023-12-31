﻿namespace PaymentDetail.Data.Models;

using System.ComponentModel.DataAnnotations;

using static Common.EntityValidations.PaymentValidations;
public class PaymentDetail
{
    public PaymentDetail()
    {
        this.Id = Guid.NewGuid();
    }

    [Key]
    public Guid Id { get; init; }

    [Required]
    [MaxLength(CARD_OWNER_NAME_MAX_LENGTH)]
    public string CardOwnerName { get; init; } = null!;

    [Required]
    [MaxLength(CARD_NUMBER_MAX_LENGTH)]
    public string CardNumber { get; init; } = null!;

    [RegularExpression(DATE_PATTERN, ErrorMessage = "Follow the pattern MM/yy")]
    public string ExpirationDate { get; init; } = null!;

    [Required]
    [MaxLength(SECURITY_CODE_MAX_LENGTH)]
    [RegularExpression(CVV_PATTERN)]
    public string CVV { get; init; } = null!;
}