using System;
using System.Collections.Generic;

namespace PokeAPIClient
{
    public class Game
    {
        public List<PlayerCharacter> Players { get; set; }
        public List<NPC> NonPlayerCharacters { get; set; }

        public Game()
        {

        }

        public void NewGame()
        {
            Program.PrintDialogue(Program.ReadDialogue("introDialogue.txt"));
            PlayerCharacter player1 = new PlayerCharacter();
        }
    }

    public class Character
    {
        public string Name { get; }
//        public List<Pokemon> Pokemon { get; private set; }
//        public List<Item> Items { get; private set; }
//        public PlayerStats Stats { get; private set; }
//        public PokemonBox Box { get; private set; }

        public Character()
        {
            Console.WriteLine("Please enter a name for your character: ");
            Name = Console.ReadLine();
            Console.WriteLine(Name);
        }
    }
    
    public class PlayerCharacter : Character
    {
        public PlayerCharacter() : base()
        {

        }

    }
    
    public class NPC : Character
    {
        public NPC() : base()
        {

        }
    }
}
