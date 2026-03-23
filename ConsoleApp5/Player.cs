using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Player
    {
        public event Action<int, int> DamageTaken; 
        public int Health { get; private set; }

        public Player(int startHealth)
        {
            Health = startHealth;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;

            if (Health < 0)
                Health = 0;

            Console.WriteLine("\n Отримано урон: " + damage);

            if (DamageTaken != null)
            {
                DamageTaken(damage, Health);
            }
        }
    }
}
