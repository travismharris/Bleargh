using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
    /*Any number divisible by three is replaced by the word fizz and any divisible by five by the word buzz. 
     * Numbers divisible by both become fizzbuzz. A player who makes a mistake has to take a drink.
     * Einstein will choose a random number to start with – for example: 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz,
     * 13, 14, fizzbuzz…*/
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i< 10 ; i++)
            {
                Console.WriteLine(i.ToString() +" yields " +  Fibonacci(i).ToString());
            }
            Console.ReadKey();
            
        }

        public static int Fibonacci(int n)
        {
            int[] myArray = new int[n + 1];

            for (int i = 0; i <= n ; i++)
            {
                if (i == 0)
                {
                    myArray[i] = n;
                }
                if (i == 1)
                    myArray[i] = n;
                else if(i>1)
                {
                    myArray[i] = (myArray[i - 1] + myArray[i - 2]);
                }
                
            }
            return myArray[n];
        }
    }

    
}
