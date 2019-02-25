using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class ShopVehicle
    {
        public void ConstructParts(VehicalBuilder vehicalBuilder)
        {
            vehicalBuilder.BuildEngine();
            vehicalBuilder.BuildWheels();
            vehicalBuilder.BuildFrames();
            vehicalBuilder.BuildDoors();

        }
    }
}
