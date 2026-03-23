using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class GameLogger
    {
        public void Subscribe(Player player)
        {
            player.DamageTaken += Log;
        }

        void Log(int damage, int health)
        {
            Console.WriteLine("Урон: " + damage + " HP: " + health);
        }
    }
}
