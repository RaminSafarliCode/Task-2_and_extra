using System;

namespace Number5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5) 4 reqemli eded verilib.Bu ededin evvelin 4 reqemi , axirina ise 44 ededini artir. Alinan cavabin 44 % tap.

            Console.Write("Input a 4-digits number: ");
            var value = Console.ReadLine(); 

            int a = Convert.ToInt32(value);

            bool IsSucceed = a >= 1000 && a < 10000;

            if (!IsSucceed)
            {
                Console.WriteLine("Invalid Number!");

                return;
            }

            int b = (a + 40000) * 100 + 44;
            Console.WriteLine($"The new number: {b}");

            double c = b * 0.44;
            Console.WriteLine($"44 percent of the number: {c}");
        }
    }
}
