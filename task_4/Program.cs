using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        var fileNames = Directory.GetFiles(@"C:\KNUTE2\OOP\text_files");

        Func<string, IEnumerable<string>> tokenizer = text =>
            text.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        Func<IEnumerable<string>, IDictionary<string, int>> wordCounter = words =>
            words.GroupBy(w => w)
                 .ToDictionary(g => g.Key, g => g.Count());

        Action<IDictionary<string, int>> displayStats = stats =>
        {
            Console.WriteLine("Частота слів:");
            foreach (var kvp in stats.OrderByDescending(kvp => kvp.Value))
            {
                Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
            }
        };

        var allWords = new List<string>();
        foreach (var fileName in fileNames)
        {
            var text = File.ReadAllText(fileName);
            var words = tokenizer(text);
            allWords.AddRange(words);
        }

        var stats = wordCounter(allWords);
        displayStats(stats);
    }
}
