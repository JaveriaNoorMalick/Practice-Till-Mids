using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingAnagrams
{
    class Program
    {
        class ArmstorngNo
        {
        int size;
        int count = 1;
        string str;
        int sum = 0;
        int[] arr;
        int[] arr1;
        public void getArray()
        {
            size = int.Parse(Console.ReadLine());
            
            arr1= new int[size];
            arr = new int[size];
            for (int s = 0; s < size; s++)
            {
                arr1[s] = Convert.ToInt32(Console.ReadLine());
                arr[s] = arr1[s];
            }
        }

            public bool isArmstorng()
            {
                getArray();
                    for (int i = 0; i <size; i++)
                    {
                       int count = 0;
                       int temp = arr[i];
                       while (count<size-1)
                       {
                           temp = temp *arr[i];
                           count++;
                       }
                     //  Console.WriteLine(+temp);
                       arr[i] = temp;
                       Console.WriteLine(+arr[i]);
                       //count++;
                    }
                for (int j = 0; j <size; j++)
                {
                    sum = sum + arr[j];
                }
                Console.WriteLine(+sum);
                String si = sum.ToString();
                Char[] ch = si.ToCharArray();
                for (int k = 0; k < size; k++)
                {

                    Console.WriteLine("///////");
                    Console.WriteLine(+ch[k]);
                    Console.WriteLine(+arr1[k]);
                    if ((char)ch[k] !=arr1[k])
                    {
                        Console.WriteLine("///////");
                        Console.WriteLine((char)ch[k]);
                        Console.WriteLine(+arr1[k]);
                        return false;
                    }
                }

                return true;
             }

   
        }
       
      
        static void Main(string[] args)
        {
            ArmstorngNo ob = new ArmstorngNo();
            
            Console.WriteLine( ob.isArmstorng());
        }
    }
}
