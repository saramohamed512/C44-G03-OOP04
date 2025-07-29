using OOP04.PolyMorphismOverriding;
using OOP04.OperatorOverloading;

using System.Numerics;
using Complex = OOP04.OperatorOverloading.Complex;

namespace OOP04
{
    internal class Program
    {
        #region MethodOverloading
        public static int Sum(int X , int Y)
        {
            return X + Y;
        }
        public static double Sum(double X, double Y)
        {
            return X + Y;
        }
        public static double Sum(double X, double Y, double Z)
        {
            return X + Y + Z;
        }

        #endregion
        static void Main(string[] args)
        {
            #region polymerphism
            #region overloading
            //Console.WriteLine(Sum(10, 20)); // Calls the int version
            //Console.WriteLine(Sum(10.5, 20.5)); // Calls the double version
            //Console.WriteLine(Sum(10.5, 20.5, 30.5)); // Calls the double version with three parameters
            #endregion
            #region  method Overloading
            //TypeB typeB = new TypeB(10, 20);
            //typeB.Func01(); // Calls the Func01 method of TypeB
            //typeB.Func02(); // Calls the Func02 method of TypeB

            #endregion
            #region operator Overloading
            Complex C1 = new Complex() { Real = 10, Imag = 20 };
            Complex C2 = new Complex() { Real = 30, Imag = 40 };
            Complex C3 = default;
            //C3 = C1 + C2; // Uses the overloaded + operator
            //C3 = C1 - C2; // Uses the overloaded - operator
            //Console.WriteLine(C1);
            //C1++;
            //Console.WriteLine(C1);
            //Console.WriteLine(C2);
            //Console.WriteLine("----------------");
            //Console.WriteLine(C3); // Outputs: 40 + 60i
            if (C1 > C2)
            {
                Console.WriteLine($"{C1} is greater than {C2}");
            }
            else { 
                Console.WriteLine($"{C1} is not greater than {C2}");
            }
            #endregion
            #endregion
        }
    }
}
