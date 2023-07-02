namespace PaymentDetail.Services.Contracts;

using ViewModels.PaymentDetails;

public interface IPaymentDetailService
{
    // Get all payment details
    Task<IEnumerable<AllCardsViewModel>> GetAllAsync();


    // Get payment detail by id
    Task<CardById> GetPaymentByIdAsync(Guid id);


    // Create payment detail
    Task<CreateRequestModel> GetCreateAsync();

    Task CreateAsync(CreateRequestModel model);

    // Delete payment detail
    Task DeleteAsync(Guid id);
}