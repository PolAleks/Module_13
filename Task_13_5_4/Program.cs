namespace Task_13_5_4
{
    internal class Program
    {
        public static Stack<string> words = new Stack<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            Console.WriteLine();

            string message = String.Empty;
            while (true)
            {
                var input = Console.ReadLine();

                if (String.IsNullOrEmpty(input))
                    continue;
                else if (input == "pop")
                {
                    words.TryPop(out message);
                    Console.WriteLine($"Удален элемент *{message}* из стека");
                }
                else if (input == "peek")
                {
                    words.TryPeek(out message);
                    Console.WriteLine($"Первый элемент в стеке: {message}");
                }else           
                    words.Push(input); 

                Console.WriteLine("В стеке:");

                ShowCollection(words);
            }
        }
        static void ShowCollection<T>(Stack<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 50));
        }
    }
}