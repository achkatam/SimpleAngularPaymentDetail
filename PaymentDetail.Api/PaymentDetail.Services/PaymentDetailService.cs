namespace PaymentDetail.Services;

using Microsoft.EntityFrameworkCore;

using Contracts;
using Data;
using Data.Models;
using ViewModels.PaymentDetails;

public class PaymentDetailService : IPaymentDetailService
{
    private readonly PaymentDetailDbContext dbContext;

    public PaymentDetailService(PaymentDetailDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<IEnumerable<AllCardsViewModel>> GetAllAsync()
    {
        var allPayments = await this.dbContext
            .PaymentDetails
            .Select(p => new AllCardsViewModel()
            {
                Id = p.Id,
                CardOwnerName = p.CardOwnerName,
                CardNumber = p.CardNumber,
                ExpirationDate = p.ExpirationDate,
                SecurityCode = p.SecurityCode
            })
            .ToListAsync();

        return allPayments;
    }

    public async Task<CardById> GetPaymentByIdAsync(Guid id)
    {
        var paymentById = await this.dbContext
            .PaymentDetails
            .Where(p => p.Id == id)
            .Select(p => new CardById()
            { 
                CardOwnerName = p.CardOwnerName,
                CardNumber = p.CardNumber,
                ExpirationDate = p.ExpirationDate,
                SecurityCode = p.SecurityCode
            })
            .FirstOrDefaultAsync();

        return paymentById;
    }

    public async Task<CreateRequestModel> GetCreateAsync()
    {
        var modelToCreate = new CreateRequestModel();

        return modelToCreate;
    }

    public async Task CreateAsync(CreateRequestModel modelToCreate)
    {
        var paymentToCreate = new PaymentDetail()
        {
            CardOwnerName = modelToCreate.CardOwnerName,
            CardNumber = modelToCreate.CardNumber,
            ExpirationDate = modelToCreate.ExpirationDate,
            SecurityCode = modelToCreate.SecurityCode
        };

        await this.dbContext.PaymentDetails.AddAsync(paymentToCreate);
        await this.dbContext.SaveChangesAsync();
    }


    public async Task DeleteAsync(Guid id)
    {
        var paymentToDelete = this.dbContext
            .PaymentDetails
            .FirstOrDefault(p => p.Id == id);

        this.dbContext.PaymentDetails.Remove(paymentToDelete);
        await this.dbContext.SaveChangesAsync();
    }
}