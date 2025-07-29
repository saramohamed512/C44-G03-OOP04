using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04
{
    internal static class Helper
    {
      
        private const double pi=3.14;
        //private static double pi = 3.14;

        public static double PI
        {
            get { return pi; }
            //set { pi = value; }
        }
 
        //static  Helper()
        //{
        //    pi = 3.14; // Default value for pi
        //}
      
        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }
        public static double CalacCircleArea(double radius)
        {
            return pi * Math.Pow(radius,2);
        }
    }
}
