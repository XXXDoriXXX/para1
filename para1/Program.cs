using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1 {
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введіть перше дійсне число:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введіть друге дійсне число:");
            double y = double.Parse(Console.ReadLine());

            double sum = x + y;
            double product = x * y;
            double arithmeticMean = (x + y) / 2;
            double geometricMean = Math.Sqrt(x * y);

            Console.WriteLine("Сума: " + sum);
            Console.WriteLine("Добуток: " + product);
            Console.WriteLine("Середнє арифметичне: " + arithmeticMean);
            Console.WriteLine("Середнє геометричне: " + geometricMean);

        }
    }

}


