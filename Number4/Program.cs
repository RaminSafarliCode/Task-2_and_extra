using System;

namespace Number4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4) 3 reqemli eded verilib.Bu ededin axirina 7 artir.Sonra cavabin 7 % tap;

            Console.Write("Input a 3-digits number: ");
            var value = Console.ReadLine();        

            int a = Convert.ToInt32(value);

            bool IsSucceed = a >= 100 && a < 1000;

            if (!IsSucceed)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            int b = a * 10 + 7;
            Console.WriteLine($"The new number: {b}");

            double c = b * 0.07;
            Console.WriteLine($"7 percent of the number: {c}");
        }
    }
}
