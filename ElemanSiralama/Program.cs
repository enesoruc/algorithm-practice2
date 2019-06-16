using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElemanSiralama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç tane eleman gireceksiniz");
            Console.Write("Eleman Adedi: ");
            int length = 0;
            bool parse = int.TryParse(Console.ReadLine(), out length);
            object[] numbers = new object[length];
            if (parse)
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write($"{i + 1}. Eleman : ");
                    numbers[i] = (Console.ReadLine());
                }

                for (int i = 0; i < length; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(numbers[i]);
                        Console.Write("\t");

                    }
                    else
                    {
                        Console.WriteLine(numbers[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Geçerli bir adet giriniz");
            }
            Console.ReadKey();
        }
    }
}
