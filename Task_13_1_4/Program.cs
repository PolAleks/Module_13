namespace Task_13_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] instance = new int[] {5, 2, 3, 4};

            Console.WriteLine(IsSorted(instance));
        }
        static bool IsSorted(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                    return false;
            }
            return true;
        }
    }
}