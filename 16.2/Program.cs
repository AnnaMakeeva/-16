using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

namespace _16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Десериализовать файл «Products.json» из задачи 1. Определить название самого дорогого товара.
            try
            {

                string jsonString = File.ReadAllText("C:/Users/Professional/source/repos/BIM проектирование/Bloc1/Задание 16/16.2/bin//Debug/Products.json");
                string jsonString1 = jsonString;
                Product[] product = JsonSerializer.Deserialize<Product[]>(jsonString1);

                foreach (var item in product)
                {
                    item.DataInput();
                }
                Product[] product1 = JsonSerializer.Deserialize<Product[]>(jsonString1);
                double max = 0;
                string maxName = "";
                foreach (var i in product1)
                {
                    if (i.priceProduct > max)
                    {
                        max = i.priceProduct;
                        maxName = i.nameProduct;
                    }
                }
                Console.WriteLine("\nСамый дорогой товар это - {0}", maxName);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
    class Product

    {
        public int codeProduct { get; set; }
        public string nameProduct { get; set; }
        public double priceProduct { get; set; }
        public void DataInput()

        {
            Console.WriteLine("\nТовар #");
            Console.WriteLine("\n{0}", codeProduct);
            Console.WriteLine(nameProduct);
            Console.WriteLine(priceProduct);
        }

    }
}
