using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarfDegistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.Write("Değiştirmek istediğiniz metin: ");
            string value = string.Empty;
            value = Console.ReadLine();
            Console.Write("değiştirmek istediğiniz harfi giriniz: ");
            char degis = Convert.ToChar(Console.ReadLine());
            Console.Write("{0} yerine konulacak harfi giriniz: ", degis);
            char degis2 = Convert.ToChar(Console.ReadLine());
            Console.Write("Metnin son hali: ");
            string clearedValue = string.Empty;
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == degis)
                {
                    clearedValue += degis2;
                    while (value[i] == degis)
                    {
                        i++;
                    }
                    i--;
                }
                else
                {
                    clearedValue += value[i];
                }
            }
            Console.WriteLine(clearedValue);
            Console.ReadKey();
        }
    }
}
