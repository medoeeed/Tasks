using System;
using System.Collections.Generic;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kiu 7/8 very easy
            
            var res = Isograms(Console.ReadLine());
            
            if (res)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");

        }

        static bool Isograms(string word)
        {
            
            var lowWord = word.ToLower();
            
            for (int i = 0; i < lowWord.Length; i++)
            {
                for (int k = 0; k < lowWord.Length; k++)
                {
                    if (i == k)
                        continue;
                    if (lowWord[i] == lowWord[k])
                        return false;
                }
            }
            
            return true;
            
        }
        
    }
}