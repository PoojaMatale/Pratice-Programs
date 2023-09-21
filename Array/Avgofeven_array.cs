using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_Programs.Array
{
    internal class Avgofeven_array
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            int[] array = new int[10];
            for(int i=0;i<array.Length;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("enter the number");
            for(int i=0;i<array.Length/2;i++)
            {
                if (array[i]%2==0)
                {
                    //Console.WriteLine(array[i]);
                    sum = sum + array[i];
                    count++;
                }
                    

                
            }
            double avg = (double)sum / count;
            Console.WriteLine("avg of even number"+avg);

        }
    }
}
