using PartidaDDD.Domain.ValueObjects;
using PartidaDDD.Shared.Entities;

namespace PartidaDDD.Domain.Entities
{
    public class Car : Entity
    {
        public string Model { get; private set; }
        public string Brand { get; private set; }
        public Factory Factory { get; private set; }
        public int Year { get; private set; }
        public string Image { get; private set; }
        public double Price { get; private set; }

        public Car(string model, string brand, Factory factory, int year, string image, double price)
        {
            Model = model;
            Brand = brand;
            Factory = factory;
            Year = year;
            Image = image;
            Price = price;
        }

        public Car(string model, string brand, int year, double price, string image)
        {
            Model = model;
            Brand = brand;
            Year = year;
            Price = price;
            Image = image;
        }

        public Car(string model, string brand, int year)
        {
            Model = model;
            Brand = brand;
            Year = year;
        }
    }
}
