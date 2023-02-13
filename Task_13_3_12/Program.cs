namespace Task_13_3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = string.Empty;
            char[] symbols = { ' ', '.', ',' };
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            do
            {
                str = Console.ReadLine();

                HashSet<char> set = new HashSet<char>(str.ToHashSet<char>());

                PrintCollection(set, "Была введена строка: ");

                if (set.Overlaps(symbols))
                    Console.WriteLine("Строка содержит символы");

                if (set.Overlaps(numbers))
                    Console.WriteLine("Строка содержит цифры");

            } while (true);
        }
        static void PrintCollection<T>(HashSet<T> collection, string message)
        {
            Console.WriteLine(message);
            foreach (var item in collection)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}