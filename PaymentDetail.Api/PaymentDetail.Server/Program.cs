using Microsoft.EntityFrameworkCore;
using PaymentDetail.Data;
using PaymentDetail.Services;
using PaymentDetail.Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen()
    .AddDbContext<PaymentDetailDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")))
    .AddScoped<IPaymentDetail, PaymentDetailService>()
    .AddCors();


var app = builder.Build();

app.UseCors(options =>
{
    options
        .WithOrigins("http://localhost:4200")
        .AllowAnyMethod()
        .AllowAnyHeader();
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app
        .UseDeveloperExceptionPage()
        .UseSwagger()
        .UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();