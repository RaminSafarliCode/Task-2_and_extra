using System;

namespace Number7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7) 2 dene 5 reqemli eded verilib.Bu ededleri toplayib.Alinan cavabin evveline ve axirina 5 artir.Neticenin 5 % tap

            Console.Write("Input the first 5-digits number: ");
            var value1 = Console.ReadLine();

            Console.Write("Input the second 5-digits number: ");
            var value2 = Console.ReadLine();

            int a = Convert.ToInt32(value1);
            int b = Convert.ToInt32(value2);

            bool IsSucceed = a >= 10000 && a < 100000 && b >= 10000 && b < 100000;

            if (!IsSucceed)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            int sum = a + b;
            Console.WriteLine($"Sum of inputted numbers: {sum}");

            int count = 0;

            int sumofnumber = sum;
            while (sum > 0) 
            {
                sum = sum / 10;
                count++;
            }

            bool accepted = count == 5;
            bool accepted2 = count == 6;

            int newNumber = 0;

            if (accepted)
            {
                newNumber = (sumofnumber + 500000) * 10 + 5; 
            }

            if (accepted2)
            {
                newNumber = (sumofnumber + 5000000) * 10 + 5;
            }

            Console.WriteLine($"The new number: {newNumber}");

            double percent = newNumber * 0.05;
            Console.WriteLine($"5 percent of the new number: {percent}");
        }
    }
}
