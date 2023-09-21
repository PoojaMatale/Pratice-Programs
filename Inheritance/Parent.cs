using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_Programs.Inheritance
{
    public class Parent
    {
        public Parent(string name)
        {
                Console.WriteLine( "parent"+name);
        }
    }
    class child : Parent
    {
    public child():base("child")
           {
               Console.WriteLine("child");
           }
    }
    public class super
    {
        static void Main(string[] args)
        {
            child child = new child();
        }
    }
    
}
