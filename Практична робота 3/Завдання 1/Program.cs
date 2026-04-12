namespace _1_Завдання
{
    class Program
    {
        static void Main()
        {
            string path = "story.txt";

            int lines = 0;
            int words = 0;
            int chars = 0;

            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    lines++;
                    chars += line.Length;

                    string[] w = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    words += w.Length;
                }
            }

            using (StreamWriter sw = new StreamWriter("report.txt"))
            {
                sw.WriteLine("Рядки: " + lines);
                sw.WriteLine("Кількість слів: " + words);
                sw.WriteLine("Кількість символів: " + chars);
            }

            Console.WriteLine("Запис у файлі");
        }
    }
}
