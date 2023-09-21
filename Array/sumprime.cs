using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Pratice_Programs.Array
{
    internal class sumprime
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] array = new int[10];
            for (int i=0; i < array.Length;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("enter the element");
            for(int i=0;i< array.Length;i++)
            {
                if (array[i]%2==0)
                {
                    sum = sum + array[i];
                   
                }
                Console.WriteLine("sum of element" + sum);
            }
        }
    }
}
