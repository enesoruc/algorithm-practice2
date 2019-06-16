using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCreater
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] values = { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","R","S","T","U","V","Y","Z",
                                "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","r","s","t","u","v","y","z"};

            string[] chars = new string[6];
            int[] values2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] intdizi = new int[2];
            Random rnd = new Random();
            Console.Write("Üretilen şifre:  ");

            for (int i = 0; i < 6; i++)
            {
                chars[i] = values[rnd.Next(0, 45)];
                Console.Write(chars[i]);
            }
            for (int j = 0; j < 2; j++)
            {
                intdizi[j] = values2[rnd.Next(0, 10)];
                Console.Write(intdizi[j]);
            }
            Console.ReadKey();
        }
    }
}
