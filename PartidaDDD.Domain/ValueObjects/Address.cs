namespace PartidaDDD.Domain.ValueObjects
{
    public class Address
    {
        public string Number { get; private set; }
        public string CEP { get; private set; }
        public string Street { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }

        public Address(string number, string cEP, string street, string neighborhood, string city, string state)
        {
            Number = number;
            CEP = cEP;
            Street = street;
            Neighborhood = neighborhood;
            City = city;
            State = state;
        }
    }
}
