using System.Collections;

namespace Task_13_3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var months = new List<string>()
            {
               "Jan", "Feb", "Mar", "Apr", "May"
            };

            var missing = new ArrayList()
            {
               1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };

            CombiningColection(months, missing);
        }

        static void CombiningColection(List<string> list, ArrayList addList)
        {
            foreach (var item in addList) {
                if (item.GetType() == typeof(string))
                {
                    list.Add((string)item);
                }
            }
            foreach (var item in list) {
                Console.WriteLine(item);
            }
        }
    }
}