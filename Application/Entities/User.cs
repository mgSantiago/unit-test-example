namespace UnitTestExample.Entities
{
    public class User
    {
        public User(Guid id, string name, int age, IList<Address> addresses)
        {
            Id = id;
            Name = name;
            SetAge(age);
            Addresses = addresses;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public IList<Address> Addresses { get; private set; }

        public bool IsValid()
        {
            if(Addresses == null || !Addresses.Any())
                throw new ArgumentException("Endereço inválido!");

            return true;
        }

        public void SetAge(int age)
        {
            if (Age < 18)
                throw new ArgumentException("Idade deve ser maior que 18 anos");

            Age = age;
        }

        public void AddAddress(Address address)
        {
            if(!address.IsValid())
                throw new ArgumentException("Endereço inválido!");

            Addresses.Add(address);
        }
    }
}
