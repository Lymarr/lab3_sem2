using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string fileName = @"C:\KNUTE2\OOP\transactions.csv";
        string dateFormat = "yyyy-MM-dd";

        using (StreamReader reader = new StreamReader(fileName))
        {
            reader.ReadLine();

            var dailySums = new Dictionary<DateTime, double>();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                string[] parts = line.Split(',');

                DateTime date = DateTime.ParseExact(parts[0], dateFormat, null);
                double amount = double.Parse(parts[1]);

                DateTime dateOnly = date.Date;
                if (!dailySums.ContainsKey(dateOnly))
                {
                    dailySums[dateOnly] = amount;
                }
                else
                {
                    dailySums[dateOnly] += amount;
                }
            }

            foreach (var dailySum in dailySums)
            {
                Console.WriteLine("{0}: {1}", dailySum.Key.ToString(dateFormat), dailySum.Value);
            }
        }
    }
}
