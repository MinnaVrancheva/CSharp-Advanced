using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        //private string model;
        
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine; 
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }

        public static Car GetCarProperties(string[] carsProperties, List<Engine> engines)
        {
            Engine engine = engines.Find(x => x.EngineModel == carsProperties[1]);

            Car car = new(carsProperties[0], engine);

            for (int i = 2; i < carsProperties.Length; i++)
            {
                bool isDigit = int.TryParse(carsProperties[i], out int checker);

                if (isDigit)
                {
                    car.Weight = checker;
                }
                else
                {
                    car.Color = carsProperties[i];
                }
            }
            
            return car;
        }

        public override string ToString()
        {
            string weight = Weight == 0 ? "n/a" : Weight.ToString();
            string color = Color ?? "n/a";

            string result =
                $"{Model}:{Environment.NewLine}" +
                $"  {Engine.ToString()}{Environment.NewLine}" +
                $"  Weight: {weight}{Environment.NewLine}" +
                $"  Color: {color}";

            return result;
        }
    }
}
