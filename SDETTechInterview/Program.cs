using System;

namespace SDETTechInterview
{
    class Program
    {
        //Write a function that computes the list of the first 100 Fibonacci numbers.The first two Fibonacci numbers are 1 and 1. The n+1-st Fibonacci number can be computed by adding the n-th and the n-1-th Fibonacci number.The first few are therefore 1, 1, 1+1=2, 1+2=3, 2+3=5, 3+5=8.

        //Write a program that finds the longest palindromic substring of a given string. Try to be as efficient as possible! eg 1001 == 1001, greek == ee, trial == not a palindrome

        static void Main(string[] args)
        {
           Fib(100);
        }

        static void Fib(int n)
        {

            //array to store the fibonacci numbers
            float[] fibs = new float[n];

            fibs[0] = 1;
            fibs[1] = 1;
            fibs[2] = 2;
            


            for(int i=3; i < n; i++)
            {
                fibs[i] = fibs[i - 1] + fibs[i - 2];
            }
       
            foreach (var item in fibs)
            {
                Console.WriteLine(item);
            }
           

        }


    }
}
