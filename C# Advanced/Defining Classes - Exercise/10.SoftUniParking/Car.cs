using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Car
    {
        public Car(string make, string model, int horsePower, string registratioNumber)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistratioNumber = registratioNumber;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistratioNumber { get; set; }

        public override string ToString()
        {
            string result =
                $"Make: {this.Make}{Environment.NewLine}" +
                $"Model: {this.Model}{Environment.NewLine}" +
                $"HorsePower: {this.HorsePower}{Environment.NewLine}" +
                $"RegistrationNumber: {this.RegistratioNumber}";

            return result.Trim();
        }
    }
}
