using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukKucukHarf
{
    class Program
    {
        static void Main(string[] args)
        {
            string defaultValue = string.Empty;
            string changedValue = string.Empty;
            Console.WriteLine("Değiştirilecek metini giriniz");
            defaultValue = Console.ReadLine();
            int letter = 0;
            for (int i = 0; i < defaultValue.Length; i++)
            {
                letter = Convert.ToChar(defaultValue[i]);
                if (letter >= 64 && letter <= 91)
                {
                    changedValue += Convert.ToChar(letter + 32);
                }
                else if (letter >= 96 && letter <= 123)
                {
                    changedValue += Convert.ToChar(letter - 32);
                }
            }
            Console.WriteLine(changedValue);
            Console.ReadKey();
        }
    }
}
