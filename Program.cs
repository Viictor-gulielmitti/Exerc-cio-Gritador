using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto;

            Console.WriteLine("Digite alguma coisa:");
            texto = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Gritador:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{texto}".ToUpper());
        }
    }
}
