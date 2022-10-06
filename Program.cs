using System;

namespace NameOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string line = "";
            string symbolVariants = "@ # $ % ^ & * | /";

            char symbol;

            int lengthLine;
            int additionalOffset = 4;


            Console.WriteLine($"Сегодня на доске почета лучших учеников яЮниор появится Ваше имя.");
            Console.WriteLine($"Введите свое имя:");
            name = Console.ReadLine().ToUpper();

            Console.WriteLine($"Введите один символ для рамочки, например: {symbolVariants}");
            symbol = Convert.ToChar(Console.Read());

            lengthLine = name.Length + additionalOffset;

            for (int i = 0; i < lengthLine; i++)
            {
                line += symbol;
            }

            Console.WriteLine(line);
            Console.WriteLine($"{symbol} {name} {symbol}");
            Console.WriteLine(line);
        }
    }
}
