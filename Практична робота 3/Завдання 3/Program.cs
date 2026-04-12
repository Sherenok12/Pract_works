namespace Завдання_3
{
    class Program
    {
        static void Main()
        {
            string path = "Test";

            string bigFile = " ";
            long maxSize = 0;

            foreach (string file in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
            {
                FileInfo fileInfo = new FileInfo(file);

                if (fileInfo.Length > maxSize)
                {
                    maxSize = fileInfo.Length;
                    bigFile = file;
                }
            }

            FileInfo result = new FileInfo(bigFile);

            Console.WriteLine("Ім'я: " +result.Name);
            Console.WriteLine("Розмір: " +result.Length + "байт");
            Console.WriteLine("шлях: " +result.FullName);
        }
    }
}
