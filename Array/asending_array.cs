using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_Programs.Array
{
    internal class asending_array
    {
        static void Main(string[] args)
        {
            int temp=0;
            int[] array = new int[] {5,3,7,4,6,10};
            for(int i=0;i<array.Length;i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("enter the array element");
            for(int i=0;i<array.Length;i++)
            {
                for(int j=i+1;j<array.Length;j++)
                {
                    if (array[i]>array[j])
                    {
                        array[i]=temp;
                        array[i] = array[j];
                        temp = array[j];
                    }
                }
                
            }
            Console.WriteLine("asendiing order the elemnet");
            for (int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
               
            }
            Console.WriteLine();
        }
    }
}
