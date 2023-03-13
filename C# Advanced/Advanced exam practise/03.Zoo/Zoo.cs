using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zoo
{
    public class Zoo
    {
        public Zoo(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Animals = new List<Animal>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public List<Animal> Animals { get; set; }
        public int Count => Animals.Count; 

        public string AddAnimal(Animal animal)
        {
            if (Animals.Count == Capacity)
            {
                return $"The zoo is full.";
            }
            else if (animal.Species == null || animal.Species == " ")
            {
                return $"Invalid animal species.";
            }
            else if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                return $"Invalid animal diet.";
            }

            Animals.Add(animal);
            return $"Successfully added {animal.Species} to the zoo.";
        }

        public int RemoveAnimals(string species)
        {
            int count = Animals.Count;
            Animals.RemoveAll(animal => animal.Species == species);
            count = count - Animals.Count;
            return count;
        }

        public List<Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> animalByDiet = new List<Animal>();
            foreach (Animal animal in Animals)
            {
                if (animal.Diet.Equals(diet))
                {
                    animalByDiet.Add(animal);
                }
            }
            return animalByDiet;
        }

        public Animal GetAnimalByWeight(double weight)
        {
            return Animals.FirstOrDefault(animal => animal.Weight == weight);
        }

        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            return
                $"There are {Animals.Where(a => a.Length >= minimumLength && a.Length <= maximumLength).Count()} animals with a length between {minimumLength} and {maximumLength} meters.";
        }

    }
}
