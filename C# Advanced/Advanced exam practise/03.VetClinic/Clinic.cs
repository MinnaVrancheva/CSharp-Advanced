using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> data;

        public Clinic (int capacity)
        {
            data = new List<Pet> ();
            Capacity = capacity;
        }
        public int Capacity { get; set; }
        public List<Pet> Data { get { return data; } }
        public int Count => data.Count;

        public void Add(Pet pet)
        {
            if (data.Count < Capacity)
            {
                data.Add (pet);
            }
        }

        public bool Remove(string name)
        {
            if (data.Where(pet => pet.Name == name).Any())
            {
                data.RemoveAll (pet => pet.Name == name);
                return true;
            }
            return false;
        }

        public Pet GetPet(string name, string owner)
        {
            if (data.Where (pet => pet.Name == name).Any() && data.Where(pet => pet.Owner == owner).Any())
            {
                return data.FirstOrDefault (pet => pet.Name == name && pet.Owner == owner);
            }
            return null;
        }

        public Pet GetOldestPet()
        {
            return data.OrderByDescending(pet => pet.Age).FirstOrDefault();
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The clinic has the following patients:");

            foreach (Pet pet in data)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
