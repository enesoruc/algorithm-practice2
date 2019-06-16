using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngAlfabe
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            char[] changedValues = new char[26];
            char[] defaultValues = new char[26];
            int lineNumber = 0, counter = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                defaultValues[lineNumber] = i;
                lineNumber++;
            }
            for (int j = 0; j < lineNumber; j++)
            {
                do
                {
                    changedValues[j] = Convert.ToChar(rnd.Next('a', 'z'));
                    counter++;
                } while (defaultValues[j] != changedValues[j]);

                Console.WriteLine($"Alfabe {counter} kadar denemede sonucu oluştu");
            }
        }
    }
}
