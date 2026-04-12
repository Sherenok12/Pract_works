namespace Завдання_4_рекурсія
{
    class Program
    {
        static int count = 0;
        static long totalSize = 0;

        static void Main()
        {
            string path = @"КЕШ";

            DeleteFiles(path);

            Console.WriteLine("Видалено файлів: " +count);
            Console.WriteLine("Звільнено місця: " +totalSize + ",fqn");
        }

        static void DeleteFiles(string path)
        {
            foreach (string file in Directory.GetFiles(path))
            {
                FileInfo fileInfo = new FileInfo(file);

                totalSize += fileInfo.Length;
                fileInfo.Delete();

                count++;
            }

            foreach (string dir in Directory.GetDirectories(path))
            {
                DeleteFiles(dir);
            }
        }
    }
}
