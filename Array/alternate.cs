using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_Programs.Array
{
    internal class alternate
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] array = new int[] { 4, 10, 2, 7, 6 };
            for(int i=0;i<array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("enter the number");
            for (int i=0;i<array.Length-2; i++)
            {
                Console.WriteLine(array[i] + array[i+2]);
                sum = sum + array[i];   
            }
           

        }
        
    }
}
