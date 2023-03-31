using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    public class PrimeNumberLogic
    {
        public static void findPrimeNumber(int startPos, int endPos)
        {
            //Declaration  
            bool isPrime = true;
            int i, j;
            //Calculate and display the Prime number  
            Console.WriteLine("Prime Numbers are : ");
            for (i = startPos; i <= endPos; i++)
            {
                for (j = 2; j <= 100; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("\t" + i);
                }
                isPrime = true;
            }

            Console.ReadKey();
        }
    }
}
