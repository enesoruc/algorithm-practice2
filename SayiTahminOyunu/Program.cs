using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zorluk seviyesi seçiniz:\n1-Kolay\n2-Orta\n3-Zor");
            Console.Write("seçim :");
            Random rnd = new Random();
            int counter = 10;
            int secim = 0;
            bool parse = int.TryParse(Console.ReadLine(), out secim);
            int sayi = 0;
            int tahmin;
            if (parse)
            {
                if (secim == 1 || secim == 2 || secim == 3)
                {
                    switch (secim)
                    {
                        case 1:
                            sayi = rnd.Next(1, 11);

                            break;
                        case 2:
                            sayi = rnd.Next(1, 101);

                            break;
                        case 3:
                            sayi = rnd.Next(1, 1001);
                            break;
                    }
                    Console.WriteLine($"Üretilen Sayı : {sayi}");
                    Console.WriteLine("Bir tahmin giriniz");
                    do
                    {
                        tahmin = 0;
                        bool parse2 = int.TryParse(Console.ReadLine(), out tahmin);

                        if (parse2 && sayi > tahmin)
                        {
                            Console.WriteLine("Üretilen sayı daha büyük tekrar deneyiniz");
                        }
                        else if (parse2 && sayi < tahmin)
                        {
                            Console.WriteLine("Üretilen sayı daha küçük tekrar deneyiniz");
                        }
                        counter--;

                    } while ((sayi != tahmin) && counter > 0);


                    if (tahmin == sayi)
                    {
                        Console.WriteLine("\nDoğru Tahmin... Tebrikler Güzel Oyundu");
                        Console.WriteLine("Çıkmak İçin Tekrar Enter Tuşu'na Basınız. Yine Bekleriz...");
                    }
                }
                else if (secim != 1 || secim != 2 || secim != 3)
                {
                    Console.WriteLine("Hatalı seçim");
                }
            }

            else
            {
                Console.WriteLine("Geçersiz Giriş");
            }
            Console.ReadKey();
        }
    }
}
