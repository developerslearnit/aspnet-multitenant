using ASPMultiTenant.API.Contracts;
using ASPMultiTenant.API.Dtos;

namespace ASPMultiTenant.API.Endpoints;

public static class CustomerEndpoints
{
    public static void MapCustomerEndpoints(this WebApplication app)
    {

        app.MapPost("/customers", async (CustomerRequest request, ICustomerRepository repository) =>
        {
            var customer = await repository.AddAsync(request);

            return Results.Ok(customer);
        }).WithTags("Customers");
    }
}