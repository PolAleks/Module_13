namespace Task_13_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pathDestination = Path.Combine(path, "cdev_Text.txt");

            char[] separator  = { ' ', '\r', '\n'};

            string text = File.ReadAllText(pathDestination);

            string[] words = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            
            Console.WriteLine($"Количество слов в файле: {words.Length}");
        }
    }
}