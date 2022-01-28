using System;

namespace Number2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) 3 reqemli eded verilib.Bu ededin axirina hemin ededdin ozunu yapishdir.example: 333 = 333333;

            Console.Write("Input a 3-digits number: ");
            var value = Console.ReadLine();

            int a = Convert.ToInt32(value);

            bool IsSucceed = a >= 100 && a < 1000;

            if (!IsSucceed)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            int b = a * 1000 + a;

            Console.WriteLine($"The new number: {b}");
        }
    }
}
