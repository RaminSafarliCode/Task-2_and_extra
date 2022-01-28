using System;

namespace Number11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11) 4 dene 5 reqemli eded verilib.Her I ededin ustune III ededi gel.II ededin usutune IV eeddi gel.
            //    Sonra cavablari vur birbirine. Alinan neticeden III ededin 3 % -ni cix.

            Console.Write("Input a 5-digits number: ");
            var value1 = Console.ReadLine();

            Console.Write("Input a 5-digits number: ");
            var value2 = Console.ReadLine();

            Console.Write("Input a 5-digits number: ");
            var value3 = Console.ReadLine();

            Console.Write("Input a 5-digits number: ");
            var value4 = Console.ReadLine();

            int a = Convert.ToInt32(value1);
            int b = Convert.ToInt32(value2);
            int c = Convert.ToInt32(value3);
            int d = Convert.ToInt32(value4);

            bool IsSucceed = a >= 10000 && a < 100000 && b >= 10000 && b < 100000 && c >= 10000 && c < 100000 && d >= 10000 && d < 100000;

            if (!IsSucceed)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            int x = a + c;
            Console.WriteLine($"Sum of first and third number: {x}");
            
            int y = b + d;
            Console.WriteLine($"Sum of second and fourth number: {y}");

            int z = x * y;
            Console.WriteLine($"Multiplication of sums: {z}");

            double result = z - c * 0.03;
            Console.WriteLine($"The final result: {result}");

        }
    }
}
