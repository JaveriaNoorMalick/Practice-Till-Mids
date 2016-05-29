using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemovingDuplicates
{
    class Program
    {
        class RemovingDuplicateElements
        {
            int [] array={1,2,2,3};
            int[] arrarWithNoDup=new int [5];
            int count = 0;
            public void removeDuplicate()
            {
                for (int i = 0; i < array.Length; i++)
                {
                      if(array[i]!=array[count])
                         {
                             count++;  
                                array[count ]=array[i];

                         }  
                 }
                
               /* for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != array[count])
                    {
                        array[count] = array[i];
                    }
                    int n = 1;
                    while((n+i)<11)
                    {
                        if (array[i] == array[i + n])
                        {
                            int dupFound = array[i + n];
                            Console.WriteLine("dup found at index # " + (i + n));
                            array[i + n] = array[i + n + 1];
                        }
                        n++;

                    }//end of while  
                }*/
                foreach (int element in arrarWithNoDup)
                {
                    Console.WriteLine(+arrarWithNoDup[count]);
                }
                
            }
        }
        static void Main(string[] args)
        {
            RemovingDuplicateElements ob = new RemovingDuplicateElements();
          ob.removeDuplicate();
        }
    }
}
