namespace Task_13_3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Подсчитайте, сколько уникальных символов в этом " +
                "предложении, используя HashSet<T>, учитывая знаки препинания, " +
                "но не учитывая пробелы в начале и в конце предложения.";

            HashSet<char> set = new HashSet<char>(str.ToHashSet<char>());

            PrintCollection(set);

            char[] symbols = {' ', '.', ',' };
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            if(set.Overlaps(symbols))
                Console.WriteLine("Строка содержит символы");

            if (set.Overlaps(numbers)) 
                Console.WriteLine("Строка содержит цифры");
        }
        static void PrintCollection<T>(HashSet<T> collection)
        {
            foreach (var item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    }
}