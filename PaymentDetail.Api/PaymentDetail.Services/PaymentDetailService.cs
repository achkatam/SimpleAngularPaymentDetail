namespace PaymentDetail.Services;

using Contracts;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using ViewModels;

public class PaymentDetailService : IPaymentDetail
{
    private readonly PaymentDetailDbContext dbContext;

    public PaymentDetailService(PaymentDetailDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<IEnumerable<AllPaymentDetails>> GetAllAsync()
    => await dbContext.PaymentDetails
        .Select(x => new AllPaymentDetails
        {
            Id = x.Id,
            CardOwnerName = x.CardOwnerName,
            CardNumber = x.CardNumber,
            ExpirationDate = x.ExpirationDate,
            CVV = x.CVV
        })
        .ToListAsync();

    public async Task<GetById?> GetByIdAsync(Guid id)
    => await dbContext.PaymentDetails
        .Where(x => x.Id == id)
        .Select(x => new GetById
        {
            Id = x.Id,
            CardOwnerName = x.CardOwnerName,
            CardNumber = x.CardNumber,
            ExpirationDate = x.ExpirationDate,
            CVV = x.CVV
        })
        .FirstOrDefaultAsync();

    public async Task AddAsync(CreatePaymentDetail model)
    {
        var toAdd = new PaymentDetail
        {
            CardOwnerName = model.CardOwnerName,
            CardNumber = model.CardNumber,
            ExpirationDate = model.ExpirationDate,
            CVV = model.CVV
        };

        await dbContext.PaymentDetails.AddAsync(toAdd);
        await dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        dbContext.PaymentDetails.Remove(await dbContext.PaymentDetails.FindAsync(id));
        await dbContext.SaveChangesAsync();
    }
}