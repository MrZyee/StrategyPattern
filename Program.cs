using System;

namespace StrategyPattern 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n (from 1 to 4): ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 1)
            {
                var context = new GeneratorContext(new PowerPoint());
                context.GenerateFile();
            }
            else if (n == 2)
            {
                var context = new GeneratorContext(new Word());
                context.GenerateFile();
            }
            else if (n == 3)
            {
                var context = new GeneratorContext(new Excel());
                context.GenerateFile();
            }
            else if (n == 4)
            {
                var context = new GeneratorContext(new Pdf());
                context.GenerateFile();
            }
        }
    }
}