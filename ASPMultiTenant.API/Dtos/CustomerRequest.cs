namespace ASPMultiTenant.API.Dtos;

public record CustomerRequest(Guid CustomerId, string FirstName, string LastName, string Email);
