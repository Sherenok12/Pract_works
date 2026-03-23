using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Screen
    {
        public void Sub(TempSensor s)
        {
            s.tempChanged += Show;
        }
        void Show(int t)
        {
            Console.WriteLine("Температура: " + t);
        }

    }
}
