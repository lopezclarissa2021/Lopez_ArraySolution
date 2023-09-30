using System.Diagnostics;

namespace Lopez_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<string> charList = GetRandomCharacterSet();
            //string charString = string.Join(",", charList);
            //Console.WriteLine(charString);
            sw.Stop();
            Console.WriteLine($"Operation took {sw.Elapsed.Milliseconds.ToString()} milliseconds to run");
        }

        public static List<string> GetRandomCharacterSet()
        {
            var random = new Random();
            HashSet<int> numbers = new HashSet<int>();
            List<string> characters = new List<string>();
            while (numbers.Count < 50)
            {
                int rand = random.Next(65, 122);
                if (rand > 90 && rand < 97)
                {
                    continue;
                }

                if (numbers.Add(rand))
                {
                    characters.Add(Convert.ToChar(rand).ToString());
                }
            }
            return characters;
        }
    }
}