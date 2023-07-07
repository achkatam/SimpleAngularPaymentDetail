namespace PaymentDetail.Services.Contracts;

using ViewModels;

public interface IPaymentDetail
{
    // Get All
    Task<IEnumerable<AllPaymentDetails>> GetAllAsync();

    // Get By Id
    Task<GetById?> GetByIdAsync(Guid id);

    // Create and add new in the db
    Task AddAsync(CreatePaymentDetail model);

    // Delete by id
    Task DeleteAsync(Guid id);
}