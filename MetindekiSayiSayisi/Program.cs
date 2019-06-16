using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetindekiSayiSayisi
{
    class Program
    {
        static void Main(string[] args)
        {
            string defaultValue = string.Empty;
            Console.WriteLine("Metin giriniz");
            defaultValue = Console.ReadLine();
            int sayac = 0;
            int letter = 0;
            for (int i = 0; i < defaultValue.Length; i++)
            {
                letter = Convert.ToChar(defaultValue[i]);
                if (letter >= 48 && letter <= 57)
                {
                    sayac++;
                }

            }
            Console.WriteLine($" Girdiğiniz metinde\"{sayac}\" adet sayı bulunmaktadır");

            Console.ReadKey();
        }
    }
}
