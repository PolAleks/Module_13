using System.Collections;
using System.Data.SqlTypes;

namespace Task_13_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = @"Text1.txt";

            char[] separator = { ' ', '\r', '\n' };

            string text = File.ReadAllText(path);

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

            string[] words = noPunctuationText.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string,int> wordsCountRepeat = new Dictionary<string,int>();

            foreach ( string word in words )
            {
                if (wordsCountRepeat.ContainsKey(word))
                    wordsCountRepeat[word]++;
                else
                    wordsCountRepeat.TryAdd(word, 1);
            }

            wordsCountRepeat = wordsCountRepeat.OrderByDescending(c => c.Value).ToDictionary(c => c.Key, c => c.Value);

            for (int i = 0; i < 10 ; i++)
            {
                Console.WriteLine($"Слово \"{wordsCountRepeat.ElementAt(i).Key}\" " +
                                  $"встречается в тексте {wordsCountRepeat.ElementAt(i).Value} раз");
            }
        }
    }
}