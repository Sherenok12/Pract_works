using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class task3 {
    delegate bool FilterPredicate(int number);

    static void FilterArray(int[] numbers, FilterPredicate predicate)
    {
        foreach (int num in numbers)
        {
            if (predicate(num))
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
    }

   /* static void Main()
    {
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static bool GreaterThanFive(int number)
        {
            return number > 5;
        }

        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Парні числа:");
        FilterArray(numbers, IsEven);

        Console.WriteLine("Числа більше 5:");
        FilterArray(numbers, GreaterThanFive);

        Console.WriteLine("Непарні числа:");
        FilterArray(numbers, n => n % 2 != 0);
    } */

  
}