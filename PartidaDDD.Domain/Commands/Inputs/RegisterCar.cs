using PartidaDDD.Shared.Commands;
using System;

namespace PartidaDDD.Domain.Commands.Inputs
{
    public class RegisterCar : ICommand
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Chassis { get; set; }
        public int Doors { get; set; }
        public bool HydraulicSteering { get; set; }
        public bool Automatic { get; set; }
        public int Year { get; set; }
    }
}
