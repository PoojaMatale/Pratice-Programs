using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Pratice_Programs.Constructor
{
    /**public class Bank
    {
        private int accno;
        private string name;
        private double accbal;

        public Bank(int accno, string name, double accbal)
        {
            this.accno = accno;
            this.name = name;
            this.accbal = accbal;
        }
        public void credit(double creditant)
        {
            accbal = +creditant;
        }
        public string debit(double debitamt)
        {
            string msg = "";
            if (debitamt <= accbal)
            {
                accbal = accbal - debitamt;
                msg = "done transaction";
            }
            else
            {
                msg = "insuffient balance";

            }
            return msg;


        }
        public string print()
        {
            return $"accono={accno} name={name} accbal={accbal}";

        }

    }
    public class banke
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the balance");
            double bal = Convert.ToDouble(Console.ReadLine());
            Bank b1 = new Bank(12300, "rahul", bal);
            Console.WriteLine(b1.print());

            b1.credit(2388);
            Console.WriteLine(b1.print());

            string msg = b1.debit(17500);
            Console.WriteLine(msg);
            Console.WriteLine(b1.print());
        }
    }**/

  
    
}
