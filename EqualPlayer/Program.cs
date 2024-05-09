using System;
using System.Collections.Generic;

namespace EqualPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Player> setOfPlayers = new HashSet<Player>();
            Player Ana = new Player(PlayerClass.Tank, "Ana");
            Player Paulo = new Player(PlayerClass.Slayer, "Paulo");

            setOfPlayers.Add(Ana);
            setOfPlayers.Add(Paulo);
            setOfPlayers.Add(Ana);

            foreach (Player p in setOfPlayers)
            {
                Console.WriteLine($"{p.Name} is a {p.PClass}");
            }
        }
    }
}
