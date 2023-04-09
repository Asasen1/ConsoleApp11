using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rubles = 100;
            var dollars = 10;
            var euro = 3;

            var courseDollars = 80.5;
            var courseEuro = 90.32;
            int whatConvert, count, inConvert;

            Console.WriteLine("Что вы хотите конвертировать? \n1-рубли \n2-доллары \n3-евро");
            whatConvert = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько?");
            count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Во что вы конвертировать? \n1-рубли \n2-доллары \n3-евро");
            inConvert = Convert.ToInt32(Console.ReadLine());
        }
        static int Converter (int whatConvert, int inConvert)
        {
            return 
        }
    }
}

