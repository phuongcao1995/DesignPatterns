namespace DesignPatterns.FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PoliceOfficer policeOfficer = new PoliceOfficerFactory();
            var cammera1 = policeOfficer.GetCamera("body");
            var cammera2 = policeOfficer.GetCamera("dasd");
            cammera1.Record();
            cammera2.Record();
            Console.ReadKey();
        }
    }
}
