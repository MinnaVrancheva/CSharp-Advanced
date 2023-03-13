using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Trainer
    {
        //public Trainer(string name)
        //{
        //    Name = name;
        //}
        
        //public Trainer(string name,List<Pokemon> pokemons) : this(name)
        //{
        //    Pokemons = pokemons;
        //}
        public Trainer(string name)
        {
            Name = name;
            Pokemons = new();
        }

        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public void FilterTrainersByPokemonElement(string command2)
        {
            if (Pokemons.Any(p => p.PokemonElement == command2))
            {
                Badges += 1;
            }
            else
            {
                for (int i = 0; i < Pokemons.Count; i++)
                {
                    Pokemon currentPokemon = Pokemons[i];
                    currentPokemon.PokemonHealth -= 10;

                    if (currentPokemon.PokemonHealth <= 0)
                    {
                        Pokemons.Remove(currentPokemon);
                    }
                }
            }
        }
    }
}
