using System;

namespace Suplimentar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
           // Ex2();

        }
        static void Ex1()
        {
            /*      Se citesc doua numere de la tastatura. Scrieti un program care va calcula
                    cel mai mare divizor comun al numerelor
               */
             
            
            Console.WriteLine("Introduceti primul numar");
            int primulNumar = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar");
            int alDoileaNumar = int.Parse(Console.ReadLine());

            Console.WriteLine($"Rezultatul este: {CMMDC(primulNumar, alDoileaNumar)}");
        }
              
        static void Ex2()
        {
            /*  Scrie un program care afiseaza numerele de la 1 la N. Daca numarul este
                multiplu de 3, sa se afiseze Fizz, daca este multiplu de 5 sa se afiseze Buzz,
                daca e multiplu si de 3 si de 5 (ex: 15) sa se afiseze FizzBuzz, in restul
                cazurilor sa se afiseze numarul. 
             */

            Console.WriteLine("Introduceti un numar de la tastatura.");
            int n = int.Parse(Console.ReadLine());
            FizzBuzz(n);
        }
        static void FizzBuzz(int n)
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }
            }
        }

        static int CMMDC(int a, int b)
        {
            int n = a;
            int m = b;

            while (n != m)
            {
                if (n > m)
                    n -= m;
                else

                    m -= n;
            }
            return n;
        }

    }
}
