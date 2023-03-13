using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        private List<Fish> fish;
        public Net(string material, int capacity)
        {
            Material = material;
            Capacity = capacity;
            fish = new List<Fish>();
        }

        public string Material { get; set; }

        public int Capacity { get; set; }

        public List<Fish> Fish { get { return fish; } }

        public int Count => Fish.Count;

        public string AddFish(Fish fish)
        {
            if (Fish.Count == Capacity)
            {
                return $"Fishing net is full.";
            }
            else if (fish.FishType == null || fish.FishType == " ")
            {
                return $"Invalid fish.";
            }
            else if (fish.Length <= 0 || fish.Weight <= 0)
            {
                return $"Invalid fish.";
            }

            Fish.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";
        }

        public bool ReleaseFish(double weight)
        {
            if (Fish.Where(fish => fish.Weight == weight).Any())
            {
                Fish.RemoveAll(fish => fish.Weight == weight);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Fish GetFish(string fishType)
        {
            return Fish.Where(fish => fish.FishType == fishType).FirstOrDefault();
        }

        public Fish GetBiggestFish()
        {
            return Fish.OrderByDescending(fish => fish.Weight).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {this.Material}:");

            foreach (var fish in Fish.OrderByDescending(fish => fish.Length))
            {
                sb.AppendLine(fish.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
