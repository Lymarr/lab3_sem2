using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using task_2;

public class Program
{
    public static void Main()
    {

        string path = @"C:\KNUTE2\OOP\json_files\";


        string category = "Books";
        double minPrice = 10.0;


        Func<string, bool> filterCriteria = fileName =>
        {

            List<Product> products = ReadJsonFile<List<Product>>(Path.Combine(path, fileName));


            Predicate<Product> filter = p => p.Category == category && p.Price >= minPrice;
            List<Product> filteredProducts = products.FindAll(filter);


            Console.WriteLine("Результати {0}:", fileName);
            foreach (Product product in filteredProducts)
            {
                DisplayProduct(product);
            }


            return true;
        };


        string[] fileNames = Directory.GetFiles(path, "*.json");
        Array.ForEach(fileNames, fileName =>
        {
            if (filterCriteria(fileName))
            {
                Console.WriteLine();
            }
        });
    }

    public static T ReadJsonFile<T>(string filePath)
    {
        using (StreamReader r = new StreamReader(filePath))
        {
            string json = r.ReadToEnd();
            return JsonConvert.DeserializeObject<T>(json);
        }
    }


    public static void DisplayProduct(Product product)
    {
        Console.WriteLine("{0} - {1} - {2} UAH", product.Name, product.Category, product.Price);
    }
}

