using System;

namespace Prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("Enter the start number..");
            int srt = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the end number..");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            int num = 1;        // true




                int j;
                for (int i = srt; i <= end; i++)
                {


                    if (i == 1)
                    { continue; }

                for (j = 2; j <= i; j++)
                    {


                        if (i != j && (i % j) == 0)
                        {
                            num = 0;
                            break;

                        }

                    }


                    if (num == 1)
                    {
                        Console.Write(i + "   ");


                    }
                    num = 1;


                }





            Console.ForegroundColor = ConsoleColor.White;






            


            // = 1          false
            // = 2      true
            // = 3      true
            // = 4          false
            // = 5      true
            // = 6          false
            // = 7      true
            // = 8          false
            // = 9          false
            // = 10         false
            // = 11     true
            // = 12         false
            // = 13     true
            // = 14         false
            // = 15         false
            // = 16         false
            // = 17     true
            // = 18         false
            // = 19         false
            // = 20         false















































        }
    }
}
