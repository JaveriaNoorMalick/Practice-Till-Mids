using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Setter
{
    class Program
    {
        class DateSetter
        {
            string inpDate;
            char[] dateAry;


            public void getData()
            {
                Console.WriteLine(" Please enter date");
                inpDate = Console.ReadLine();
                dateAry = inpDate.ToCharArray();
            }

            public void computation()
            {
                string []b = inpDate.Split('-');
                for (int i = 0; i < inpDate.Length; i++)
                {
                    Console.Write(inpDate[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            DateSetter obj = new DateSetter();
            obj.getData();
            obj.computation();
        }
    }
}
