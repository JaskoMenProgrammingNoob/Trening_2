using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        
        Random los = new Random();
        int losowa;
        for (int i = 1; i <= 5; i++)
        {
            
            losowa = los.Next(0,100);
            
            Console.WriteLine($"Losowa liczba to: {losowa}");
        }
        
        
        
        /* int suma = 0;
        int i = 1;
        do
        {
            if (!(i % 2 == 0))
            {
                suma = suma + i;
            }
            i++;
        } while ( i <= 100);
        Console.WriteLine($"Suma liczb nieparzystych do 100 włącznie to: {suma} "); */



        /* int suma = 0;
        int i = 1;
        while (i <= 100)
        {
            

            if (!(i % 2 == 0))
               
            {
                
                suma = suma + i;
                
            }
            i++;
        }
            Console.WriteLine($"Suma: {suma}"); */






        /* ! oznacza negację, czyli zaprzeczenie warunku, który jest w nawiasie. W tym przypadku, jeśli i jest parzyste (i % 2 == 0), to ! (i % 2 == 0) będzie fałszywe, a jeśli i jest nieparzyste, to ! (i % 2 == 0) będzie prawdziwe. */
        /* int suma = 0;
        for (int i = 1; i <= 100; i++)
        {

            if (! (i % 2 == 0))
            {
                suma = suma + i; 

            } 

        }
        Console.WriteLine($"Suma liczb nieparzystych do 100 włącznie to: {suma} "); */






        /* 
         int suma = 0;
        int i = 0;
        
        while (i <= 100)
        {
            i++;
            if (i % 2 == 0)
            {
                suma = suma + i;
            }
        }
        Console.WriteLine($"Suma liczb to {suma}"); */




        /* do
        {
            i++;
            if (i % 2 == 0)
            {
                suma = suma + i;
            }

        } while (i <= 100);
        Console.WriteLine($"Suma to: {suma}"); */




        /* 
         for (int i = 2; i <= 100; i++)
        {
            
            if (i % 2 == 0)
            {
                suma = suma + i;
                
            }
            
        }
        Console.WriteLine($"Suma liczb parzystych do 100 włącznie to: {suma} "); */




        /* int suma = 0;
        int x = 1;
        while (x <= 100)
        {
            x++;
            suma = suma + x;
        }
        Console.WriteLine($"Suma = {suma}"); */




        /* int suma = 0;
        int x = 1;
        do 
        {
             
                x++;
            suma = suma + x;
            
        } while (x <= 100);
        Console.WriteLine($"suma = {suma}"); */


        /*
        int suma = 0;
        for (int x = 1; x <= 100; x++ )
        {
            suma = suma + x;
            

        }
        Console.Write($" suma = {suma}"); */






        /* int x = 0;
        while ( x < 20)
        {
            x++;
            if (x < 20)
            {
                Console.Write($"{x}, ");
            }
            else
            {
                   Console.Write($"{x}.");
            }

        } */





        /* int x = 0;
        do
        {
            x++;
            if (x < 20)
            {
                Console.Write($"{x}, ");
            }
            else
            {
                Console.Write($"{x}.");

            }

           
        } while (x < 20); */









        /* double x;
        for ( x = 1; x <= 20; x++)
        {
            if (x < 20)
            {
                Console.Write($"{x}, ");
            }
            else
            {
                Console.Write($"{x}.");
            }




            } */



        /*
        int x = 0;
        int y = 0;
        while (x < 11)
        {
            y = 3 * x;
                        Console.WriteLine($"Wartość funkcji y dla x = {x} to {y}");
            x++;
        } */







        /*
        int x = 0;
        int y = 0;
        do 
        {

            y = 3 * x;
            Console.WriteLine($"Wartość funkcji y dla x = {x} to {y}");
            x++;

        } while (x < 11);

        */




        /* int x;
        for (x = 0; x <= 10; x++)
        {
            int y = 3 * x;
            Console.WriteLine($"Wartość funkcji y dla x = {x} to {y}");
        }
       */
    }
}
