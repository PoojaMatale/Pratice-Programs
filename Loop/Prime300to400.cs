using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_Programs.Loop
{
    internal class Prime300to400
    {
        static void Main(string[] args)
        {
            //int temp = 0;
           // Console.WriteLine("enter the number");
            //int no=Convert.ToInt32(Console.ReadLine());

            for(int i=300;i<=400;i++)
            {
                bool isprime = true;
                for(int j=2;j<=i;j++)
                {
                    if(i%j==0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if(isprime==true)
                {
                    Console.WriteLine(i);
                }
            }
            

        }
    }
}
