using System;

namespace Prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {

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

        }
    }
}
