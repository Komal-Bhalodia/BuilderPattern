using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    abstract class VehicalBuilder
    { 
        public ProductVehicle productVehicle;
      
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildFrames();
        public abstract void BuildDoors();
  
    }

    class MotorCycleBuilder : VehicalBuilder
    {
     
        public MotorCycleBuilder()
        {
            productVehicle = new ProductVehicle("MotorCycle");
        }

        public override void BuildEngine()
        {
            productVehicle["Engine"] = "500 cc";
        }

        public override void BuildWheels()
        {
            productVehicle["Wheel"] = "2";
        }

        public override void BuildFrames()
        {
            productVehicle["Frame"] = "MotorCycle Frame";
        }

        public override void BuildDoors()
        {
            productVehicle["Door"] = "0";
        }

    }

    class CarBuilder : VehicalBuilder
    {
        public CarBuilder()
        {
            productVehicle = new ProductVehicle("Car");
        }

        public override void BuildEngine()
        {
            productVehicle["Engine"] = "2500 cc";
        }

        public override void BuildWheels()
        {
            productVehicle["Wheel"] = "4";
        }

        public override void BuildFrames()
        {
            productVehicle["Frame"] = "Car Frame";
        }

        public override void BuildDoors()
        {
            productVehicle["Door"] = "4";
        }

    }

    class TruckBuilder : VehicalBuilder
    {

        public TruckBuilder()
        {
            productVehicle = new ProductVehicle("Truck");
        }
        public override void BuildEngine()
        {
            productVehicle["Engine"] = "4500 cc";
        }

        public override void BuildWheels()
        {
            productVehicle["Wheel"] = "8";
        }

        public override void BuildFrames()
        {
            productVehicle["Frame"] = "TruckFrame";
        }

        public override void BuildDoors()
        {
            productVehicle["Door"] = "3";
        }

    }
}
