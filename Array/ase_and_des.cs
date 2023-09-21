using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_Programs.String
{
    internal class ase_and_des
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int[] array = new int[] { 2, 4, 12, 23, 14, 17, 20 };
            
            for(int i=0; i<array.Length/2; i++)
            {
                for(int j=i+1;j<array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                    
                    
                }

                
            }
            /*for(int i=0;i<array.Length/2;i++)
            {
                //for(int j=i+1;j<array.Length;j++)
                {
                    if (array[i] <array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }*/
            Console.WriteLine("asending order");
            //Console.WriteLine("desending order");
            for (int i=0;i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
