namespace Task_13_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var phoneBook = new List<Contact>()
            {
                new ("Игорь", 79990000000, "igor@example.com"),
                new ("Андрей", 79990000001, "andrew@example.com")
            };

            Console.WriteLine(AddUnique(new Contact("Петр", 79787871933, "petr@ya.ru"), phoneBook));
        }

        static bool AddUnique(Contact contact, List<Contact> phoneBook)
        {
            if (!phoneBook.Contains(contact)) 
                phoneBook.Add(contact);
            else
                return false;
            phoneBook.Sort((a, b) => String.Compare(a.Name, b.Name,StringComparison.Ordinal));
            foreach(var item in phoneBook)
            {
                Console.WriteLine($"Имя: {item.Name}, тел.: {item.PhoneNumber}");
            }
            return true;
        }
    }
}