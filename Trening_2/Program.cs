using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        int y = 0;
        do 
        {
            
            y = 3 * x;
            Console.WriteLine($"Wartość funkcji y dla x = {x} to {y}");
            x++;

        } while (x < 11);
        
        
        
        
        
        
        /* int x;
        for (x = 0; x <= 10; x++)
        {
            int y = 3 * x;
            Console.WriteLine($"Wartość funkcji y dla x = {x} to {y}");
        }
       */
    }
}