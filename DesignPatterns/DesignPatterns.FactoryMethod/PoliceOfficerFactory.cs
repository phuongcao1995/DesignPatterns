using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class PoliceOfficerFactory : PoliceOfficer
    {
        public override ICamera GetCamera(string type)
        {
            if (type == "body")
            {
                return new BodyCam();
            }
            else
            {
                return new DashCam();
            }
        }
    }
}
