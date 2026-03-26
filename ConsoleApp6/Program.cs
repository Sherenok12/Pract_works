namespace ConsoleApp6
{
     public class Program
    {
        public delegate string TextOperation(string text);

        public string UppperCase(string text)
        {
            return text.ToUpper();
        }

        public string Chars(string text)
        {
            return "Кількість символів: " + text.Length;
        }

        public string Words(string text)
        {
            return "Кількість слів: " + text.Split(' ').Length;
        }

        public void ProcessFile(string input, string output, TextOperation operation)
        {
            string[] lines = File.ReadAllLines(input);

            using (StreamWriter writer = new StreamWriter(output, true))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(operation(line));
                }
            }
        }
        
    }
}