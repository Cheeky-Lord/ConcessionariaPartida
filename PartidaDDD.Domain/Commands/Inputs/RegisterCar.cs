using PartidaDDD.Shared.Commands;
using System;

namespace PartidaDDD.Domain.Commands.Inputs
{
    public class RegisterCar : ICommand
    {
        public string Origin { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Chassis { get; set; }
        public int Doors { get; set; }
        public string Steering { get; set; }
        public string Transmission { get; set; }
        public bool EletronicWindow { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
    }
}
