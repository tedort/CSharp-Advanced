using System.Xml.Linq;

namespace _09.PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Trainer> trainers = new List<Trainer>();

            while (input != "Tournament")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Pokemon pokemon = new Pokemon(tokens[1], tokens[2], int.Parse(tokens[3]));
                string trainerName = tokens[0];
                bool included = false;
                foreach (Trainer trainer in trainers)
                {
                    if (trainerName == trainer.Name)
                    {
                        included = true;
                        trainer.Pokemons.Add(pokemon);
                        continue;
                    }
                }
                if (!included || trainers.Count == 0)
                {
                    Trainer trainer = new Trainer(tokens[0]);
                    trainer.Pokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "End")
            {
                if (CheckElement(trainers, input))
                {
                    foreach (Trainer trainer in trainers)
                    {
                        foreach (Pokemon pokemon in trainer.Pokemons)
                        {
                            if (input == pokemon.Element)
                            {
                                trainer.NumberOfBadges++;
                            }
                        }
                    }
                }
                else
                {
                    foreach (Trainer trainer in trainers)
                    {
                        foreach (Pokemon pokemon in trainer.Pokemons.ToList())
                        {
                            pokemon.Health -= 10;
                            if (pokemon.Health <= 0)
                            {
                                trainer.Pokemons.Remove(pokemon);
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }

            trainers = trainers.OrderByDescending(trainer => trainer.NumberOfBadges).ToList();

            foreach (Trainer trainer in trainers)
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }

        public static bool CheckElement(List<Trainer> trainers, string element)
        {
            foreach (Trainer trainer in trainers)
            {
                foreach (Pokemon pokemon in trainer.Pokemons)
                {
                    if (element == pokemon.Element)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
