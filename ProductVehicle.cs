using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class ProductVehicle
    {
        private string vehicleType;
        Dictionary<string,string> parts = new Dictionary<string, string>();

        public ProductVehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        public string this[string key]
        {
            get { return parts[key]; }
            set { parts[key] = value; }
        }
        public void ShowDetails()
        {
            Console.WriteLine("---------------Information-------------");
            Console.WriteLine("Vehicle type :  {0} " , vehicleType );
            Console.WriteLine("Engine :  {0} " , parts["Engine"]);
            Console.WriteLine("Wheels :  {0} " , parts["Wheel"]);
            Console.WriteLine("Frames :  {0} " , parts["Frame"]);
            Console.WriteLine("Doors  :  {0} " , parts["Door"]);
        }
    }
}
