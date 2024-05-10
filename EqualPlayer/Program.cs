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
            Player Ana2 = new Player(PlayerClass.Tank, "Ana");

            setOfPlayers.Add(Ana);
            setOfPlayers.Add(Paulo);
            setOfPlayers.Add(Ana2);

            foreach (Player p in setOfPlayers)
            {
                Console.WriteLine($"{p.Name} is a {p.PClass}");
            }
        }
    }
}
