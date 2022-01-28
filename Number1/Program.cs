using System;

namespace Number1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) 4 reqemli eded verilib.Bu ededin eveline 7 reqemini , axirinada 8 reqemini artir. Example1: 333 = 73338

            Console.Write("Input a 4-digit number: ");
            var value = Console.ReadLine();

            int a = Convert.ToInt32(value);

            bool IsSucceed = a >= 1000 && a < 10000;

            if (!IsSucceed)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            int b = (a + 70000) * 10 + 8;

            Console.WriteLine($"The new number: {b}");

        }
    }
}
