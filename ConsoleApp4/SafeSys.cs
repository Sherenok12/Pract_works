using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class SafeSys
    {
        public void Sub(TempSensor s)
        {
            s.tempChanged += Check;
        }

        void Check(int t)
        {
            if (t > 40)
                Console.WriteLine("Перегрів!");
            else if (t < 5)
                Console.WriteLine(" Ризик замерзання!");
        }
    }
}
