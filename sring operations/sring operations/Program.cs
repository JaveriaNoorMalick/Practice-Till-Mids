using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sring_operations
{
    class Program
    {
        public class strings
        {
            public void byRef(ref int i)
            {
                Console.WriteLine(i);
                ++i;
            }
            public void byValue(int j)
            {

                ++j;
            }
            public void byOut(out int i)
            {

                i = 100;
            }

            public void checkString()
            {
                int i = 1;
                byValue(i);
                 Console.WriteLine(i);
                 byOut(out i);
                 Console.WriteLine(i);
                byRef(ref i);
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            strings ob = new strings();
            ob.checkString();


        }
    }
}

