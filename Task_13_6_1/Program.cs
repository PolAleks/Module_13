using System.Diagnostics;

namespace Task_13_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"Text1.txt";

            char[] separator = { ' ', '\r', '\n' };

            string text = File.ReadAllText(path);

            string[] words = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            List<string> list = new List<string>();

            var stopWatch = Stopwatch.StartNew();
            foreach ( string word in words )
            {
                list.Insert(0, word);
            }
            Console.WriteLine($"Время заполнения коллекции List<T> методом вставки: {stopWatch.Elapsed.TotalSeconds:f5}");

            LinkedList<string> linkedList = new LinkedList<string>();

            stopWatch.Restart();
            foreach ( string word in words )
            {
                linkedList.AddFirst(word);
            }
            Console.WriteLine($"Время заполнения коллекции LinkedList<T> методом вставки: {stopWatch.Elapsed.TotalSeconds:f5}");
        }
    }
}