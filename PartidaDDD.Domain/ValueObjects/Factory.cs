namespace PartidaDDD.Domain.ValueObjects
{
    public class Factory
    {
        public string Origin { get; private set; }
        public string Chassis { get; private set; }
        public int Doors { get; private set; }
        public string Steering { get; private set; }
        public string Transmission { get; private set; }
        public bool EletricWindow { get; private set; }
        public string Color { get; private set; }

        public Factory(string origin, string chassis, int doors, string steering, string transmission, bool eletricWindow, string color)
        {
            Origin = origin;
            Chassis = chassis;
            Doors = doors;
            Steering = steering;
            Transmission = transmission;
            EletricWindow = eletricWindow;
            Color = color;
        }
    }
}
