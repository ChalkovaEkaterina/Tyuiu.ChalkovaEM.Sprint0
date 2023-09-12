using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ChalkovaEM.Srint0.Task4.V0.Lib;

namespace Tyuiu.ChalkovaEM.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Subtraction(10, 5));
            Console.WriteLine(DataService.Multiplication(10, 5));
            Console.WriteLine(DataService.Devision(10, 5));

            Console.ReadKey();
        }
    }
}
