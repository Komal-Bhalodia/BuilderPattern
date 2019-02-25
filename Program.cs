using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicalBuilder builder;
            ShopVehicle shopVehicle = new ShopVehicle();
            builder = new MotorCycleBuilder();
            shopVehicle.ConstructParts(builder);
            builder.productVehicle.ShowDetails();

            builder = new CarBuilder();
            shopVehicle.ConstructParts(builder);
            builder.productVehicle.ShowDetails();

            builder = new TruckBuilder();
            shopVehicle.ConstructParts(builder);
            builder.productVehicle.ShowDetails();

            Console.ReadLine();
        }
    }
}
