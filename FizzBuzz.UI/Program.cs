using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var buzzer = new FizzBuzzer();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(buzzer.GetValue(i));
            }

            Console.ReadLine();
        }
    }
}
