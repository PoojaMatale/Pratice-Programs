using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_Programs.Array
{
    internal class asen
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 3, 4, 5, 12, 34, 21, 45, 67, 14 };
            int temp = 0;
            for(int i=0;i<array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine( "enter the array element");
            for (int i=0;i<array.Length;i++)
            {
                for(int j=i+1;j<array.Length;i++)
                {
                    if (array[i] > array[j])
                    {
                        array[i] = temp;
                        array[i] = array[j];
                        temp = array[j];
                    }
                }
                Console.WriteLine("asending element" +array[i]);
            }
        }
    }
}
