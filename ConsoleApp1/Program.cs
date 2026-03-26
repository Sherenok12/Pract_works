namespace ConsoleApp1
{
    public delegate void MessageEventHandler(string message);
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string logFile = "logPD22.txt";

            File.WriteAllText(logFile, "");

            var publisher = new MessagePublisher();
            var log = new FileLogger(logFile);

            log.Subscribe(publisher);

            Console.WriteLine("Введіть текст 4 рази:");

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Введіть рядок {i + 1}: ");
                string input = Console.ReadLine();

                publisher.Send(input);
            }

            Console.WriteLine($"Запис у файлі");
        }
    }
}