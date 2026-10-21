using System;
using System.Collections.Generic;
using System.Linq;

class Pokemon
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public int Level { get; set; }
    public int Attack { get; set; }
}

class PokemonLINQLab
{
    static void Main()
    {
        var pokemons = new List<Pokemon>
        {
            new Pokemon { Id = 1, Name = "Bulbasaur", Type = "Grass", Level = 15, Attack = 49 },
            new Pokemon { Id = 2, Name = "Charmander", Type = "Fire", Level = 36, Attack = 52 },
            new Pokemon { Id = 3, Name = "Squirtle", Type = "Water", Level = 10, Attack = 48 },
            new Pokemon { Id = 4, Name = "Pikachu", Type = "Electric", Level = 22, Attack = 55 },
            new Pokemon { Id = 5, Name = "Eevee", Type = "Normal", Level = 25, Attack = 55 },
            new Pokemon { Id = 6, Name = "Psyduck", Type = "Water", Level = 20, Attack = 52 },
            new Pokemon { Id = 7, Name = "Growlithe", Type = "Fire", Level = 24, Attack = 70 },
            new Pokemon { Id = 8, Name = "Snorlax", Type = "Normal", Level = 30, Attack = 110 }
        };

        // Find Pokemon ready to evolve
        var readyToEvolve = from p in pokemons
                            where p.Level >= 16
                            orderby p.Level
                            select p;

        // Display Pokemon ready to evolve
        Console.WriteLine("Pokemon Ready to Evolve:");

        // Print each Pokemon ready to evolve
        foreach (var p in readyToEvolve)
        {
            Console.WriteLine($"Name: {p.Name}, Type: {p.Type}, Level: {p.Level}");
        }

        // Find Pokemon with Attack of 50 or higher
        var strongPokemon = (from p in pokemons
                             where p.Attack >= 50
                             select p).ToList();

        // Sort strong Pokemon alphabetically by name
        var sortedPokemon = (from p in strongPokemon
                             orderby p.Name
                             select p).ToList();

        Console.WriteLine("\nStrong Pokemon (Attack 50 or Higher), Alphabetical Order:");

        // Print strong Pokemon and their Attack stats
        foreach (var p in sortedPokemon)
        {
            Console.WriteLine($"Name: {p.Name}, Type: {p.Type}, Attack: {p.Attack}");
        }

        // Find Water Pokemon and sort by Level from highest to lowest
        var waterPokemon = (from p in pokemons
                            where p.Type == "Water"
                            orderby p.Level descending
                            select p).ToList();

        Console.WriteLine("\nWater Pokemon (Highest Level First):");

        // Print Water Pokemon and their Levels
        foreach (var p in waterPokemon)
        {
            Console.WriteLine($"Name: {p.Name}, Type: {p.Type}, Level: {p.Level}");
        }
    }
}
