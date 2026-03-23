using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class SoundSystem
    {
        public void Subscribe(Player player)
        {
            player.DamageTaken += PlaySound;
        }

        void PlaySound(int damage, int health)
        {
            Console.WriteLine("Звук отримання урону");

            if (health <= 20)
                Console.WriteLine("Критичний стан!");
        }
    }
}
