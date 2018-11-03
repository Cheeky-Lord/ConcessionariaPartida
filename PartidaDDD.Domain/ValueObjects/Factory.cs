namespace PartidaDDD.Domain.ValueObjects
{
    public class Factory
    {
        public string Chassis { get; private set; }
        public int Doors { get; private set; }
        public bool HydraulicSteering { get; private set; }
        public bool Automatic { get; private set; }

        public Factory(string chassis, int doors, bool hydraulicSteering, bool automatic)
        {
            Chassis = chassis;
            Doors = doors;
            HydraulicSteering = hydraulicSteering;
            Automatic = automatic;
        }
    }
}
