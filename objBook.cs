using Pratice_Programs.Constructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_Programs
{
    internal class objBook
    {
        static void Main(string[] args)
        {
            Book b1 = new Book(1, "math", "dr.santosh");

            string result = b1.display();
            Console.WriteLine(result);
        }
    }
}
