namespace PaymentDetail.Data;

using Microsoft.EntityFrameworkCore;
using Models;

public class PaymentDetailDbContext : DbContext
{
    public PaymentDetailDbContext(DbContextOptions<PaymentDetailDbContext> options)
    : base(options)
    {
        
    }

    public DbSet<PaymentDetail> PaymentDetails { get; set; } = null!;
}