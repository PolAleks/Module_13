using System.Collections;

namespace Task_13_2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var months = new[]
            {
               "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };

            var numbers = new[]
            {
               1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
            };
            
            ArrayList array = new ArrayList();
            
            for (int i = 0; i < months.Length; i++)
            {
                array.Add(months[i]);
                array.Add(numbers[i]);
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}