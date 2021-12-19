using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            do
            {
               Console.Write("Input a integer that is >=2: ");
               int.TryParse(Console.ReadLine(), out A) ;
            } while (A < 2);
            
            bool[]primenums = new bool[A];
            for (int i=0; i < A; i++)
            {
                primenums[i] = true;
            }

            for (int i = 2; i < A; i++)
            {
                if (primenums[i - 1])
                {
                    for (int t = (i * i); t < A; t += i)
                    {
                        primenums[t - 1] = false;
                    }
                }
            }     
            for (int i = 2; i < A; i++)
                if (primenums[i - 1]) 
            { Console.Write(" " + i + " "); }
         
            



        }
    }
}
