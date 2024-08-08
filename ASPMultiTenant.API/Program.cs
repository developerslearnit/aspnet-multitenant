using ASPMultiTenant.API.Contracts;
using ASPMultiTenant.API.Endpoints;
using ASPMultiTenant.API.Persistence;
using ASPMultiTenant.API.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppDbConnection")));

builder.Services.AddTransient<ICustomerRepository, CustomerRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapCustomerEndpoints();

app.Run();


