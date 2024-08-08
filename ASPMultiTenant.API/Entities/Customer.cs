namespace ASPMultiTenant.API.Entities;

public partial class Customer
{
    private Customer() { }
    public Guid CustomerId { get; private set; } = Guid.NewGuid();
    public string FirstName { get; private set; } = default!;
    public string LastName { get; private set; } = default!;
    public string Email { get; private set; } = default!;

    public Customer(Guid customerId,string firstname,string lastName,string email)
    {
        CustomerId = customerId;
        FirstName = firstname;

        LastName = lastName;
        Email = email;
    }
}