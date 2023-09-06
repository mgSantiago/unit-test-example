namespace UnitTestExample.UseCases.User
{
    public sealed record AddressCommand(string Line1, string Line2, string City, string State, string PostalCode, string Country)
    {
    }
}
