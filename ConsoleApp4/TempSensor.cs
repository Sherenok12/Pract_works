using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class TempSensor
    {
        public event Action<int> tempChanged;

        public void SetTemp(int t)
        {
            Console.WriteLine("\n Нова температура:: " + t);

            if (tempChanged != null)
            {
                tempChanged(t);
            }
        }
    }
}
