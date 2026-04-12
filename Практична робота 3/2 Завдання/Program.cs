namespace _2_Завдання
{
    internal class Program
    {
        static void Main()
        {
            string path = "Test";

            string[] files = Directory.GetFiles(path);
            string[] dirs = Directory.GetDirectories(path);

            Console.WriteLine("Файли:");
            foreach (string f in files)
            {
                FileInfo fi = new FileInfo(f);
                Console.WriteLine(fi.Name + " | " + fi.Length + " bytes | " + fi.CreationTime);
            }

            Console.WriteLine("\nПапки:");
            foreach (string d in dirs)
            {
                Console.WriteLine(d);
            }
        }
    }
}
