using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_Programs.Array
{
    internal class Reverse_array
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 90, 45, 29, 37, 781 };
            for(int i=0;i<array.Length-1;i++)
            {
                for(int j=i+1;j<array.Length;j++)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
                Console.WriteLine(array[i]);
            }
        }
    }
}
