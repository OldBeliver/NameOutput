using System;

namespace NameOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string referenceLine = "";
            string symbolsLine = "";
            
            char symbol;
            string symbolVariants = "@ # $ % ^ & * | /";          

            Console.WriteLine($"Сегодня на доске почета лучших учеников яЮниор появится Ваше имя.");
            Console.WriteLine($"Введите свое имя:");
            name = Console.ReadLine().ToUpper();

            Console.WriteLine($"Введите один символ для рамочки, например: {symbolVariants}");
            symbol = Convert.ToChar(Console.Read());

            referenceLine = $"{symbol} {name} {symbol}";

            for (int i = 0; i < referenceLine.Length; i++)
            {
                symbolsLine += symbol;
            }

            Console.WriteLine(symbolsLine);
            Console.WriteLine(referenceLine);
            Console.WriteLine(symbolsLine);
        }
    }
}
