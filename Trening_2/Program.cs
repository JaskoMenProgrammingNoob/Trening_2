using System;

class Program
{
    static void Main(string[] args)
    {

        int x;
        for (x = 0; x <= 10; x++)
        {
            int y = 3 * x;
            Console.WriteLine($"Wartość funkcji y dla x = {x} to {y}");
        }

    }
}