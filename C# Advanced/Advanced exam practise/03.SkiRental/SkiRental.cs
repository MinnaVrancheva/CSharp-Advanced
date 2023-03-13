using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        private List<Ski> data;

        public SkiRental()
        {
            data = new List<Ski>();
        }
        public SkiRental(string name, int capacity) : this()
        {
            Name = name;
            Capacity = capacity;
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => data.Count;

        public void Add(Ski ski)
        {
            if (data.Count < Capacity)
            {
                data.Add(ski);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            if (data.Where(ski => ski.Manufacturer == manufacturer).Any() && data.Where(ski => ski.Model == model).Any()) 
            {
                data.RemoveAll(ski => ski.Manufacturer == manufacturer && ski.Model == model);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Ski GetNewestSki()
        {
            return this.data.OrderByDescending(s => s.Year).FirstOrDefault();
        }

        public Ski GetSki(string manufacturer, string model)
        {
            return data.Where(s => s.Manufacturer == manufacturer).Where(s => s.Model == model).FirstOrDefault();
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {this.Name}:");
            foreach (var item in data)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }
    }
}
