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
            double coureseDollarToRubbles = 70.5;
            double coureseEuroToRubbles = 80.3;
            double courseDollarToEuro = 0.8;
            Console.WriteLine("Какую валюту вы хотите конвертировать? Введите на выбор: \nдоллар \nрубль \nевро");
            string currency = Console.ReadLine();

            switch (currency)
            {
                case "доллар":
                    Console.WriteLine("Ввведите колличество долларов:");
                    double dollarsAmmount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Во что вы хотите конвертировать? \nрубль \nевро");
                    string convert = Console.ReadLine();
                    if (convert == "рубль")
                        Console.Write($"У Вас {dollarsAmmount * coureseDollarToRubbles} рублей. ");
                    else
                        Console.Write($"У Вас {dollarsAmmount * courseDollarToEuro} евро. ");
                    break;
                case "евро":
                    Console.WriteLine("Ввведите колличество евро:");
                    double euroAmmount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Во что вы хотите конвертировать? \nрубль \nдоллар");
                    string convert2 = Console.ReadLine();
                    if (convert2 == "рубль")
                        Console.Write($"У Вас {euroAmmount * coureseEuroToRubbles} рублей. ");
                    else
                        Console.Write($"У Вас {euroAmmount / courseDollarToEuro} долларов. ");
                    break;
                case "рубль":
                    Console.WriteLine("Ввведите колличество рублей:");
                    double rublesAmmount = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Во что вы хотите конвертировать? \nевро \nдоллар");
                    string convert3 = Console.ReadLine();
                    if (convert3 == "евро")
                        Console.Write($"У Вас {rublesAmmount / coureseEuroToRubbles} евро. ");
                    else
                        Console.Write($"У Вас {rublesAmmount / coureseDollarToRubbles} долларов. ");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}

