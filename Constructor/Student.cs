using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_Programs.Constructor
{
    public class Student
    {
        private int id;
        private string name;
        private double per;

        public Student(int id,string name,double per)
        {
            this.id = id;
            this.name = name;
            this.per = per;
        }
        public string print()
        {
            return $"{id},{name},{per}";
        }
    }
      public class stud
      {
        static void Main(string[] args)
        {
            Student s = new Student(1,"mohan",78.32);
            Console.WriteLine(s.print());
        }
      }
}
