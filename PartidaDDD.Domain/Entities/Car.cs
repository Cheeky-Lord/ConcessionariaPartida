using PartidaDDD.Domain.ValueObjects;
using PartidaDDD.Shared.Entities;

namespace PartidaDDD.Domain.Entities
{
    public class Car : Entity
    {
        public string Name { get; private set; }
        public string Brand { get; private set; }
        public Factory Factory { get; private set; }
        public int Year { get; private set; }

        public Car(string name, string brand, Factory factory, int year)
        {
            Name = name;
            Brand = brand;
            Factory = factory;
            Year = year;
        }
    }
}
