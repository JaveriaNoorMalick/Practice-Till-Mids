using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseInteger
{
    class Program
    {
        class ReverseInteger
        {
            string str;
            char[] ch;
            public void reverse(int n)
            {
                
                str = n.ToString().re;
                ch = str.ToCharArray();
                for (int i = 0; i < ch.Length; i++)
                {
                    int x = (int)Char.GetNumericValue(ch[i]);
                    Console.WriteLine(+x);
                    int temp = x;

                }
                
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
