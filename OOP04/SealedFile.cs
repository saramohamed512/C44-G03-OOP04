using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    internal class Parent
    {
        private int salary;
        public virtual int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        //public sealed void Print()
        //{
        //    Console.WriteLine("Hello parent");
        //}
    }
    class Child : Parent
    {
       public override int Salary
        {
            get { return base.Salary; }
            set { base.Salary = value + 1000; } // Adding 1000 to the parent's salary
        }
        //public override void Print()
        //{
        //    Console.WriteLine("Hello child");
        //}
    }
}
