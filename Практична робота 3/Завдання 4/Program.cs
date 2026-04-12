namespace Завдання_4
{
    class Program
    {
        static void Main()
        {
            string path = @"КЕШ";

            int count = 0;
            long totalSize = 0;

            foreach (string file in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
            {
                FileInfo fi = new FileInfo(file);

                totalSize += fi.Length;
                fi.Delete();

                count++;
            }

            Console.WriteLine("Видалено файлів: " + count);
            Console.WriteLine("Звільнено місця: " + totalSize + " байт");
        }
    }
}
