namespace Task_13_3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";

            HashSet<char> set = new HashSet<char>(str.ToHashSet<char>());

            Console.WriteLine(set.Count);
        }
    }
}