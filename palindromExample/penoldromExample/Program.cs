using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penoldromExample
{
    class Program
    {
        class IsPenoldrom
        {
            string strCheck;
         
            

            public bool isPenoldrome()
            {
                Console.WriteLine("enter size of array");
                int n = Console.Read();
                Console.WriteLine("enter a string to be checked");
                strCheck = Console.ReadLine();

               char[] ary=strCheck.ToCharArray();
                for (int i = n; i > 0; i -- )
                {
                    char []reverseAry;
                    for (int j = 0; j <= n; j++)
                    {
                        reverseAry[i] = ary[j];
                    }
                }




                return true;
            }

        }
        static void Main(string[] args)
        {
        }
    }
}
