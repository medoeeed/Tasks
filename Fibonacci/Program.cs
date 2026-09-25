using System;
using System.Collections.Generic;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            // I think this is 9/8 kyu :D but why can't I write this? I fkng love FIBONACCI!
            Console.WriteLine(Fibonacci(10));
            
        }

        static int Fibonacci(int number)
        {

            int counter = 1;
            var a = 0;
            var b = 1;
            
            while (number > counter)
            {
                var tempA = a; 
                
                a = b;
                b = tempA + b;
                
                counter++;
            }
            
            return a;
        }
        
    }
}