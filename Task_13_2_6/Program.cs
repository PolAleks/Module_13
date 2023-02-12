using System.Collections;

namespace Task_13_2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var example = new ArrayList()
           {
               1,
               "Самая ",
               "лучшая ",
               "коллекция",
               300,
               23,
               45
            };

            var result = GetArrayList(example);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        static ArrayList GetArrayList(ArrayList list)
        {
            int amount = 0;
            string str = string.Empty;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] is Int32)
                    amount += (int?)list[i] ?? 0;
                else
                    str += (string?)list[i];
            }

            return new ArrayList() { amount, str };
        }
    }
}