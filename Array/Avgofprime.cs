using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_Programs.Array
{
    internal class Avgofprime
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            int[]array=new int[10];
            for(int i=0;i<array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<array.Length ; i++)
            {
                bool isprime = true;
                for(int j = 2; j < array[i]; j++)
                {
                    if (array[i]%j==0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    Console.WriteLine(array[i]);
                    sum = sum + array[i];
                    count++;
                }
            }
            double avg = (double)sum / count;
            Console.WriteLine("avg of prime number"+avg);

        }
    }
}
