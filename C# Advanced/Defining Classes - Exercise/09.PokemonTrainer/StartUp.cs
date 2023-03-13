using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses;

public class StartUp
{
    static void Main(string[] args)
    {
        List<Trainer> trainers = new List<Trainer>();
        //List<Pokemon> pokemons  = new List<Pokemon>();
        string command;

        while ((command = Console.ReadLine()) != "Tournament")
        {
            string trainerName = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0];
            string pokemonName = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1];
            string pokemonElement = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[2];
            int pokemonHealth = int.Parse(command.Split(" ", StringSplitOptions.RemoveEmptyEntries)[3]);

            Trainer trainer = trainers.SingleOrDefault(t => t.Name == trainerName);

            if (trainer == null)
            {
                trainer = new(trainerName);
                trainer.Pokemons.Add(new(pokemonName, pokemonElement, pokemonHealth));
                trainers.Add(trainer);
            }
            else
            {
                trainer.Pokemons.Add(new(pokemonName, pokemonElement, pokemonHealth));
            }
        }

        string[] newTrainers;
        string command2;

        while ((command2 = Console.ReadLine()) != "End")
        {
            foreach (Trainer trainer in trainers)
            {
                trainer.FilterTrainersByPokemonElement(command2);
            }
        }

        foreach (Trainer trainer in trainers.OrderByDescending(t => t.Badges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
        }
    }

    
}
