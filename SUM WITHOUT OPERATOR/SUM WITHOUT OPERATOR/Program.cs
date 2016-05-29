using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUM_WITHOUT_OPERATOR
{
    class Program
    {
        class SumWithNoOpeator
        {
            static int a = 3;
            static int b = 4;
            int i = 0;
            string str=a.ToString();
            string str2 = b.ToString();

            public void sum()
            {
               char []ch1= str.ToCharArray();
               while (b != 0)
               {
                   int count = 0;
                   char temp = ch1[count];
                   count++;
                
                         b--;

                         Console.WriteLine(+temp);
                }

               
               int sum = Convert.ToInt32(ch1[i]);
               Console.WriteLine(+sum);

                
            }
        }
        static void Main(string[] args)
        {
            SumWithNoOpeator ob = new SumWithNoOpeator();
            ob.sum();
            
            
        }
    }
}
