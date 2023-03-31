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

                    int  r, sum = 0, temp;
                    
                    temp = i;
                    while (temp > 0)
                    {
                        r = temp % 10;
                        sum = (sum * 10) + r;
                        temp = temp / 10;
                    }
                    if (i == sum)
                        Console.Write("\t" + i);
                    
                    
                }
                isPrime = true;
            }

            Console.ReadKey();
        }
    }
}
