using System;

namespace Number13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13) 5 dene eded verilib.Bunlardan 3 denesi 5 reqemli. 2 denesi ise 3 reqemlidir. 5 reqemli ededlerin 5 % tap ,neticeleri vur bir birine.
            //    Sonra 3 reqemli ededlerin 3 % tap ,neticeleri topla. Sonra yekunda alinan iki cavalarin her birinin 10 % -ni tapib topla.

            Console.Write("Input a 5-digits number: ");
            var value1 = Console.ReadLine();

            Console.Write("Input a 5-digits number: ");
            var value2 = Console.ReadLine();

            Console.Write("Input a 5-digits number: ");
            var value3 = Console.ReadLine();

            Console.Write("Input a 3-digits number: ");
            var value4 = Console.ReadLine();

            Console.Write("Input a 3-digits number: ");
            var value5 = Console.ReadLine();

            int a = Convert.ToInt32(value1);
            int b = Convert.ToInt32(value2);
            int c = Convert.ToInt32(value3);
            int d = Convert.ToInt32(value4);
            int e = Convert.ToInt32(value5);

            bool IsSucceed = a >= 10000 && a < 100000 && b >= 10000 && b < 100000 && c >= 10000 && c < 100000 && d >= 100 && d < 1000 && e >= 100 && e < 1000;

            if (!IsSucceed)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            double firstStep = (a * 0.05) * (b * 0.05) * (c * 0.05);
            Console.WriteLine($"The first result: {firstStep}");

            double secondStep = (d * 0.03) + (e * 0.03);
            Console.WriteLine($"The second result: {secondStep}");

            double lastStep = (firstStep * 0.1) + (secondStep * 0.1);
            Console.WriteLine($"The final result: {lastStep}");


        }
    }
}
