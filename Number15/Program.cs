using System;

namespace Number15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //15)*5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli. 1 denesi 7 reqemli olsun.
            //    3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.
            //    Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
            //    Cavabdan 7 reqemli ededin son 5 reqemini cix.
            //    Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
            //    Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
            //    Cavabin axirina 11 artir.
            //    Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
            //    Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.

            Console.Write("Input a 3-digits number: ");
            var value1 = Console.ReadLine();

            Console.Write("Input a 3-digits number: ");
            var value2 = Console.ReadLine();

            Console.Write("Input a 6-digits number: ");
            var value3 = Console.ReadLine();

            Console.Write("Input a 6-digits number: ");
            var value4 = Console.ReadLine();

            Console.Write("Input a 7-digits number: ");
            var value5 = Console.ReadLine();

            int a = Convert.ToInt32(value1);
            int b = Convert.ToInt32(value2);
            int c = Convert.ToInt32(value3);
            int d = Convert.ToInt32(value4);
            int e = Convert.ToInt32(value5);

            bool IsSucceed = a >= 100 && a < 1000 && b >= 100 && b < 1000 && c >= 100000 && c < 1000000 && d >= 100000 && d < 1000000 && e >= 1000000 && e < 10000000;

            if (!IsSucceed)
            {
                Console.WriteLine("Invalid number!");

                return;
            }

            Console.WriteLine("---------------------------------------------------------");

            //    3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.

            int sum = a + b;
            Console.WriteLine($"The sum of 3-digits number: {sum}");

            int qaliq = sum %= 100;
            Console.WriteLine($"Last two numbers of sum: {qaliq}");

            double square = Math.Pow(qaliq, 2);
            Console.WriteLine($"Square of this number: {square}");

            Console.WriteLine("---------------------------------------------------------");

            //    Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.

            int newNumber = a * 1000 + b;
            Console.WriteLine($"Matching of 3-digits number: {newNumber}");

            double sumNew = newNumber + square;
            Console.WriteLine($"Square + match: {sumNew}");

            Console.WriteLine("---------------------------------------------------------");

            //    Cavabdan 7 reqemli ededin son 5 reqemini cix.

            int newQaliq = e % 100000;
            Console.WriteLine($"Last 5-digit of 7-digits number: {newQaliq}");

            double newNumberrr = sumNew - newQaliq;
            Console.WriteLine($"Substract with last 5-digit of 7-digits number {newNumberrr}");

            Console.WriteLine("---------------------------------------------------------");

            //    Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.

            int sumsix = c + d;
            Console.WriteLine($"Sum of 6-digits number: {sumsix}");

            int sixQaliq = sumsix %= 1000;
            Console.WriteLine($"Last 3-digit of sum of 6-digits number: {sixQaliq}");

            double newNumberSix = newNumberrr + sixQaliq;
            Console.WriteLine($"Sum with new number: {newNumberSix}");

            Console.WriteLine("---------------------------------------------------------");

            //    Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.


            int newMainNumber = 0;
            int sevendigitNumber = e;
            while (sevendigitNumber > 0)
            {
                newMainNumber += sevendigitNumber % 10;
                sevendigitNumber /= 10;


            }
            Console.WriteLine($"The sum of digits of 7-digits number: {newMainNumber}");

            int remainder = 0;
            int reverse = 0;

            while (newMainNumber > 0)
            {
                remainder = newMainNumber % 10;
                reverse = reverse * 10 + remainder;
                newMainNumber = newMainNumber / 10;
            }

            Console.WriteLine($"The reverse of new number: {reverse}");

            double finalnewNumber = newNumberSix + reverse;
            Console.WriteLine($"Reverse + previous new number: {finalnewNumber}");

            Console.WriteLine("---------------------------------------------------------");

            //    Cavabin axirina 11 artir.

            double nextStage = finalnewNumber * 100 + 11;
            Console.WriteLine($"Matching 11 to the end of number: {nextStage}");

            Console.WriteLine("---------------------------------------------------------");

            //    Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.

            int counter = 1;
            int yeniEded = 0;

            while (e > 0)
            {
                int Qaliq = e % 10;
                e = e / 10;

                if (counter % 2 != 0)
                {
                    yeniEded = yeniEded * 10 + Qaliq;
                }
                counter++;
            }

            while (yeniEded > 0)
            {
                int Qaliq = yeniEded % 10;
                yeniEded /= 10;

                e = e * 10 + Qaliq; 
            }
            Console.WriteLine($"Numbers of 7-digits number that standing in odd places: {e}");

            double lastNew = e - nextStage;
            Console.WriteLine($"Substraction with previous stage: {lastNew}");

            Console.WriteLine("---------------------------------------------------------");

            //    Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.

            double newRemainder = lastNew % 10;
            int lastNewVersion = Convert.ToInt32(lastNew);
            int lastnewNumber;

            if (lastNew > 0)
            {
                lastnewNumber = (lastNewVersion / 10) * 100 + 88;
            }
            else
            {
                lastnewNumber = (((lastNewVersion / 10) * 100) * -1 + 88) * -1;
            }
            
            double finalnewlastNumber = lastnewNumber * 10 + newRemainder;

            Console.WriteLine($"Adding 88 between last 2-digit of result: {finalnewlastNumber}");
        }
    }
}
