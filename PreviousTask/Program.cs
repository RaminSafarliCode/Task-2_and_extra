using System;

namespace PreviousTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // birinci eded ucun
            int a = 12345;
            int cem = 0;
            int qaliq;
            int last_a;

            bool accepted = a >= 10000 && a < 100000;

            Console.WriteLine("Daxil edilen birinci eded: " + a);


            // ikinci eded ucun
            int b = 12345;
            int hasil = 1;
            int qaliq2;

            bool accepted2 = b >= 10000 && b < 100000;

            Console.WriteLine("Daxil edilen ikinci eded: " + b);

            if (accepted || accepted2)
            {
                // birinci ededin son reqemini tapmaq ucun emeliyyat 
                last_a = a % 10;

                // birinci eded ucun condition
                while (a > 0)
                {
                    qaliq = a % 10;
                    a = (a - qaliq) / 10;
                    cem = cem + qaliq;
                }
                Console.WriteLine("Birinci ededin reqemlerinin cemi: " + cem);


                // ikinci eded ucun condition

                while (b > 0)
                {
                    qaliq2 = b % 10;
                    b = (b - qaliq2) / 10;
                    hasil = hasil * qaliq2;
                }
                Console.WriteLine("Ikinci ededin reqemlerinin hasili: " + hasil);


                // hasilin ve cemin tapilmasi ucun emeliyyat 
                int z = cem + hasil;
                Console.WriteLine("Neticelerin cemi: " + z);

                // birinci ededin son reqeminin cap olunmasi 
                Console.WriteLine("Birinci ededin son reqemi: " + last_a);

                // neticenin sonuna birinci ededin son reqemini yapisdirmaq ucun emeliyyat
                int c = z * 10;
                int x = c + last_a;
                Console.WriteLine("Son netice: " + x);
            }
        }
    }
}
