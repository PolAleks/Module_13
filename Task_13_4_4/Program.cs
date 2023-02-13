namespace Task_13_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new Dictionary<string, Contact>()
            {
                { "Игорь", new(79990000000, "igor@example.com") },
                { "Андрей", new (79990000001, "andrew@example.com") }
            };
            PrintPhoneBook(phoneBook);

            phoneBook.TryAdd("Светлана", new Contact(79991234567, "svetlana@ya.ru"));
            PrintPhoneBook(phoneBook);

            if (phoneBook.TryGetValue("Светлана", out Contact contact))
                contact.PhoneNumber = 79780203344;
            PrintPhoneBook(phoneBook);

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