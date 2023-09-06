namespace UnitTestExample.Entities
{
    public class Address
    {
        public Address(Guid id, string line1, string line2, string city, string state, string postalCode, string country)
        {
            Id = id;
            Line1 = line1;
            Line2 = line2;
            City = city;
            State = state;
            PostalCode = postalCode;
            Country = country;
        }

        public bool IsValid()
        {
            if(PostalCode.Length != 8)
            {
                return false;
            }

            return true;
        }

        public Guid Id { get; private set; }
        public string Line1 { get; private set; }
        public string Line2 { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string PostalCode { get; private set; }
        public string Country { get; private set; }
    }
}
