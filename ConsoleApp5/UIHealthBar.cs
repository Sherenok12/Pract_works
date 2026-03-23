using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class UIHealthBar
    {
        public void Subscribe(Player player)
        {
            player.DamageTaken += UpdateUI;
        }

        void UpdateUI(int damage, int health)
        {
            Console.WriteLine("Поточне HP: " + health);
        }
    }
}
