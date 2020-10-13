namespace DesignPatterns.FactoryMethod
{
    public class BodyCam : ICamera
    {
        public void Record()
        {
            Console.WriteLine("Body cam record");
        }
    }
}
