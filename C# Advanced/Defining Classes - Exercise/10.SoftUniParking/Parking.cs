using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        private int capacity;
        private Dictionary<string, Car> cars;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            cars = new Dictionary<string, Car>();
        }

        public int Count { get { return this.cars.Count; } }
        public int Capacity { get ; private set; }
        public Dictionary<string, Car> Cars { get { return cars; } set { cars = value; } }

        public string AddCar(Car car)
        {
            if (cars.ContainsKey(car.RegistratioNumber))
            {
                return $"Car with that registration number, already exists!";
            }
            if (cars.Count == capacity)
            {
                return $"Parking is full!";
            }
            
            cars.Add(car.RegistratioNumber, car);

            return $"Successfully added new car {car.Make} {car.RegistratioNumber}";
        }

        public string RemoveCar(string registratioNumber)
        {
            if (!cars.ContainsKey(registratioNumber))
            {
                return $"Car with that registration number, doesn't exist!";
            }

            cars.Remove(registratioNumber);

            return $"Successfully removed {registratioNumber}";
        }

        public Car GetCar (string registratioNumber)
        {
            return cars[registratioNumber];
        }

        public void RemoveSetOfRegistrationNumber(List<string> registatioNumbers)
        {
            foreach (string registratioNumber in registatioNumbers)
            {
                if (cars.ContainsKey(registratioNumber))
                {
                    RemoveCar(registratioNumber);
                }
            }
        }
    }
}
