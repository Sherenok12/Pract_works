using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Main1
    {
        public static void Main(string[] args)
        {
            Program program = new Program();
            string input = "textPD22.txt";
            string output = "resultPD22.txt";

            File.WriteAllText(output, ""); 

            program.ProcessFile(input, output, program.UppperCase);
            program.ProcessFile(input, output, program.Chars);
            program.ProcessFile(input, output, program.Words);

            Console.WriteLine("Результати у файлі");
        }
    }
}