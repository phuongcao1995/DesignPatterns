using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class DashCam : ICamera
    {
        public void Record()
        {
            Console.WriteLine("Dash cam record");
        }
    }
}
