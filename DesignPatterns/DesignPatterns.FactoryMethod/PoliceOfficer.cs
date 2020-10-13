namespace DesignPatterns.FactoryMethod
{
    public abstract class PoliceOfficer
    {
        public abstract ICamera GetCamera(string type);
    }
}
