namespace Area51.Entities
{
    public class Person
    {
        public Person(int id, string name, int age, IList<Address> addresses)
        {
            Id = id;
            Name = name;
            SetAge(age);
            Addresses = addresses;
        }

        public int Id { get; private set; }
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
    }
}
