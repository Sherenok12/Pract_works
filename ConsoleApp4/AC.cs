using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class AC
    {
        public void Sub(TempSensor s)
        {
            s.tempChanged += Work;
        }

        void Work(int t)
        {
            if (t < 17)
                Console.WriteLine("Увімкнено обігрів");
            else if (t <= 25)
                Console.WriteLine("Вимкнено");
            else
                Console.WriteLine("Увімкнено охолодження");
        }
    }
}
