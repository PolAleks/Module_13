using System.Collections.Concurrent;

namespace Task_13_5_8
{
    internal class Program
    {
       // объявим потокобезопасную очередь(полностью идентична обычной очереди, но
       // позволяет безопасный доступ
       // из разных потоков)
       public static ConcurrentQueue<string> words = new ConcurrentQueue<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в очередь.");
            Console.WriteLine();

            //  запустим обработку очереди в отдельном потоке
            StartQueueProcessing();

            while (true)
            {
                var input = Console.ReadLine();

                words.Enqueue(input); // ИЗМЕНИТЬ ЗДЕСЬ
            }
        }

        // метод, который обрабатывает и разбирает нашу очередь в отдельном потоке
        // ( для выполнения задания изменять его не нужно )
        static void StartQueueProcessing()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                while (true)
                {
                    Thread.Sleep(5000);
                    if (words.TryDequeue(out var element))
                        Console.WriteLine("======>  " + element + " прошел очередь");
                }

            }).Start();
        }
    }
}