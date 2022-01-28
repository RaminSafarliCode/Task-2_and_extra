using System;

namespace NUmber14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14) 6 dene 6 reqemli eded verilib.Evvel hamisini topla.Sonra I ve III ededi bir birine yapishdir ve bir eded al.
            //    I neticeden II neticeni cix.Alinan cavabin 10 % tap.Neticenin uzerine V ve VI ededleri gel. Yekunda alinan cavabin 11 % tap.

            Console.Write("Input a 6-digits number: ");
            var value1 = Console.ReadLine();

            Console.Write("Input a 6-digits number: ");
            var value2 = Console.ReadLine();

            Console.Write("Input a 6-digits number: ");
            var value3 = Console.ReadLine();

            Console.Write("Input a 6-digits number: ");
            var value4 = Console.ReadLine();

            Console.Write("Input a 6-digits number: ");
            var value5 = Console.ReadLine();

            Console.Write("Input a 6-digits number: ");
            var value6 = Console.ReadLine();

            int a = Convert.ToInt32(value1);
            int b = Convert.ToInt32(value2);
            int c = Convert.ToInt32(value3);
            int d = Convert.ToInt32(value4);
            int e = Convert.ToInt32(value5);
            int f = Convert.ToInt32(value6);    

            bool IsSucceed = a >= 100000 && a < 1000000 && b >= 100000 && b < 1000000 && c >= 100000 && c < 1000000 && d >= 100000 && d < 1000000 && e >= 100000 && e < 1000000;

            if (!IsSucceed)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            int sum = a + b + c + d + e + f;
            Console.WriteLine($"Sum of inputted numbers: {sum}");

            int newNumber = a * 1000000 + c;
            Console.WriteLine($"New number: {newNumber}");

            double nextStep = (sum - newNumber) * 0.1;
            Console.WriteLine($"First result: {nextStep}");

            double lastStep = (nextStep + e + f) * 0.11;
            Console.WriteLine($"The final result: {lastStep}");
        }
    }
}
