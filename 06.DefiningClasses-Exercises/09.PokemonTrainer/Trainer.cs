using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons;

        public Trainer(string name)
        {
            Name = name;
            Pokemons = new List<Pokemon>();
        }

        public string Name { get => name; set => name = value; }
        public int NumberOfBadges { get => numberOfBadges; set => numberOfBadges = value; }
        public List<Pokemon> Pokemons { get => pokemons; set => pokemons = value; }
    }
}
