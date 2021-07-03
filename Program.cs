using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var resaut = Number(Console.ReadLine());
            }
            Console.ReadKey();
            
        }
        static string Number(string numbers)
        {
            Console.WriteLine("Введите чисто. Например: 42 55 50 83");
            var number = Console.ReadLine()
            .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse);

            foreach (var n in number)
            {
                Console.WriteLine(n);               
            }
            return number.ToString();
        }
    }
}
