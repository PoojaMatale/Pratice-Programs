using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_Programs.Loop
{
    internal class PrimeNumbercheck
    {
        static void Main(string[] args)
        {
            int count = 0;
            int num = 17;
            for(int i=1;i<=num;i++)
            {
                if(num%i==0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                Console.WriteLine("prime number");
            }
            else
            {
                Console.WriteLine("not prime number");
            }
        }
    }
}
