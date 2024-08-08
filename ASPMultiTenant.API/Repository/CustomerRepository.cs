using ASPMultiTenant.API.Contracts;
using ASPMultiTenant.API.Dtos;
using ASPMultiTenant.API.Entities;
using ASPMultiTenant.API.Persistence;

namespace ASPMultiTenant.API.Repository;

public class CustomerRepository: ICustomerRepository
{
    private readonly AppDbContext _context;
    public CustomerRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Customer> AddAsync(CustomerRequest request)
    {

        var customer = new Customer(Guid.NewGuid(), request.FirstName,request.LastName,request.Email);

        await _context.AddAsync(customer);

        await _context.SaveChangesAsync();

        return customer;
    }
}