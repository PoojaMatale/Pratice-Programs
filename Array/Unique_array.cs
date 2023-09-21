using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_Programs.Array
{
    internal class Unique_array
    {
        static void Main(string[] args)
        {
            int[]array=new int[10];
            Console.WriteLine("enter the element");
            for(int i= 0; i< array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i= 0; i< array.Length;i++)
            {
                bool isvisited = true;
                int count = 1;
                for(int k=i-1;k>=0;k--)
                {
                    if(array[k] == array[i])
                    {
                        isvisited = false;
                        break;
                    }
                }
                if(isvisited)
                {
                    for(int j=i+1;j<array.Length;j++)
                    {
                        if (array[j] == array[i])
                        {
                            isvisited=false;
                            count++;
                        }
                    }
                    if(count==1)
                    {
                        Console.WriteLine( $"unique elements in array are{array[i]}");
                    }
                }
            }
        }
    }
}
