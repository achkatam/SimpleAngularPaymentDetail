namespace PaymentDetail.Server.Controllers;

using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using ViewModels;

public class PaymentDetailController : ApiController
{
    private readonly IPaymentDetail paymentDetailService;

    public PaymentDetailController(IPaymentDetail paymentDetailService)
    {
        this.paymentDetailService = paymentDetailService;
    }

    [HttpGet]
    public async Task<IEnumerable<AllPaymentDetails>> GetAll()
    {
       var allPaymentDetails =  await paymentDetailService.GetAllAsync();

       return allPaymentDetails;
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<GetById?>> GetById(Guid id)
    {
        var paymentDetail = await paymentDetailService.GetByIdAsync(id);

        if (paymentDetail == null)
        {
            return NotFound();
        }

        return paymentDetail;
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> Create(CreatePaymentDetail model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await paymentDetailService.AddAsync(model);

        return CreatedAtAction(nameof(GetById), new { id = model.Id }, model);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult> Delete(Guid id)
    {
        var paymentDetail = await paymentDetailService.GetByIdAsync(id);

        if (paymentDetail == null)
        {
            return NotFound();
        }

        await paymentDetailService.DeleteAsync(id);

        return NoContent();
    }
}