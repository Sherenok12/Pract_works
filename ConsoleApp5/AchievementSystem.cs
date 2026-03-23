using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class AchievementSystem
    {
        public void Subscribe(Player player)
        {
            player.DamageTaken += CheckAchievements;
        }

        void CheckAchievements(int damage, int health)
        {
            if (health <= 50)
                Console.WriteLine("Half Health");

            if (health <= 0)
                Console.WriteLine("First Death");
        }
    }
}
