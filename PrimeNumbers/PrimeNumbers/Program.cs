using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static int[] primeArray=new int [10];
        public class PrimeNumbers
        {
            public void findPrimeNo( int n)
            {
                int count = 0;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (i != j)
                        {
                            if (i % j != 0)
                            {
                                primeArray[count] = i;
                            }
                        }
                    }
                }
                 for (int i = 0; i < 10; i++)
                   {
                      Console.WriteLine( +primeArray[i]);
                      }
        }        
        }
        static void Main(string[] args)
        {
            PrimeNumbers ob = new PrimeNumbers();
            ob.findPrimeNo(10);
            
        }
    }
}
