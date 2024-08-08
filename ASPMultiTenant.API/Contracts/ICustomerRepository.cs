using ASPMultiTenant.API.Dtos;
using ASPMultiTenant.API.Entities;

namespace ASPMultiTenant.API.Contracts;

public interface ICustomerRepository
{
    Task<Customer> AddAsync(CustomerRequest request);
}