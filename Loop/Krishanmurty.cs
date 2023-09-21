using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_Programs.Loop
{
    internal class Krishanmurty
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int sum = 0;
            int rem = 0;
            
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            while(num>0)
            {
                rem = num % 10;
                int fact = 1;
              
                num = num / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("krishamurty number");
            }
            else
            {
                Console.WriteLine("not krishnamurty number");
            }
        }
    }
}
