namespace Task_13_3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cageOne = new HashSet<string>()
            {
               "Волк", "Медведь" , "Тигр", "Кабан"
            };

            var cageTwo = new HashSet<string>()
            {
               "Бык", "Лошадь" , "Баран", "Кабан", "Коза"
            };

            Console.WriteLine("До удаление Кабана:");
            PrintCollection(cageOne);

            //cageOne.Remove("Кабан");
            cageOne.ExceptWith(cageTwo);

            Console.WriteLine("После удаления Кабана:");
            PrintCollection(cageOne);
        }

        static void PrintCollection(HashSet<string> collection)
        {
            foreach (var item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}