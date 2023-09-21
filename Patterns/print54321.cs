using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_Programs.Patterns
{
    internal class print54321
    {
        static void Main(string[] args)
        {
            for(int i=1;i>=5;i--)
            {
                for(int j=1;j<=5;i++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
