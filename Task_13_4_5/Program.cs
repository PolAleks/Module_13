using System.Diagnostics;

namespace Task_13_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary

            var phoneBook = new Dictionary<string, Contact>()
            {
                { "Игорь", new(79990000000, "igor@example.com") },
                { "Андрей", new (79990000001, "andrew@example.com") }
            };
            PrintPhoneBook(phoneBook);

            double result = 0;
            for (int i = 0; i < 10; i++) 
            {
                var stopWatch = Stopwatch.StartNew();
                phoneBook.TryAdd("Светлана", new Contact(79991234567, "svetlana@ya.ru"));
                result += stopWatch.Elapsed.TotalMilliseconds;
            }
            Console.WriteLine($"Средняе время выполнения TryAdd в Dictionary: {(result / 20):f5}");
            #endregion

            #region SortedDictionary

            var phoneBookSorted = new SortedDictionary<string, Contact>()
            {
                { "Игорь", new(79990000000, "igor@example.com") },
                { "Андрей", new (79990000001, "andrew@example.com") }
            };

            for (int i = 0; i < 10; i++)
            {
                var stopWatch = Stopwatch.StartNew();
                phoneBookSorted.TryAdd("Светлана", new Contact(79991234567, "svetlana@ya.ru"));
                result += stopWatch.Elapsed.TotalMilliseconds;
            }
            Console.WriteLine($"Средняе время выполнения TryAdd в SortedDictionary: {(result / 20):f5}");
            #endregion
        }

        static void PrintPhoneBook(Dictionary<string, Contact> phoneBook)
        {
            foreach (var contact in phoneBook)
            {
                Console.WriteLine($"{contact.Key} - тел.: {contact.Value.PhoneNumber}");
            }
            Console.WriteLine(new string('-', 50));
        }
    }
}