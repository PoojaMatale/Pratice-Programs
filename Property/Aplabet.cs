using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_Programs
{
    internal class Aplabet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the charter");
            int ch=Convert.ToInt32(Console.ReadLine());

            if(ch>='a'&&ch>='z'||ch>='A'&&ch>='Z')
            {
                Console.WriteLine("alphabet");
            }
            else if(ch>='0'&& ch<='9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("special");
            }
        }
    }
}
