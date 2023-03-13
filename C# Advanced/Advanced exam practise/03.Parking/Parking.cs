using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> data;
        private string type;
        private int capacity;
        public Parking()
        {
            data = new List<Car>();
        }
        public Parking(string type, int capacity) : this()
        {
            Type = type;
            Capacity = capacity;
        }

        public string Type { get { return type; } set { type = value; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }
        public List<Car> Data { get { return data; } }
        public int Count => data.Count;

        public void Add(Car car)
        {
            if (data.Count < Capacity)
            {
                data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            if (Data.Where(c => c.Manufacturer == manufacturer).Any() && Data.Where(c => c.Model == model).Any())
            {
                Data.RemoveAll(car => car.Manufacturer == manufacturer && car.Model == model);
                return true;
            }
            return false;
        }

        public Car GetLatestCar()
        {
            if (data == null)
            {
                return null;
            }
            return data.OrderByDescending(car => car.Year).FirstOrDefault();
        }

        public Car GetCar(string manufacturer, string model)
        {
            if (Data.Where(c => c.Manufacturer == manufacturer).Any() && Data.Where(c => c.Model == model).Any())
            {
                return data.FirstOrDefault(car => car.Manufacturer == manufacturer && car.Model == model);
            }
            return null;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {this.Type}:");
            foreach (var car in this.data)
            {
                sb.AppendLine(car.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
