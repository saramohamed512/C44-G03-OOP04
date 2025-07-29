using OOP04.PolyMorphismOverriding;

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
            #region overriding
            TypeB typeB = new TypeB(10, 20);
            typeB.Func01(); // Calls the Func01 method of TypeB
            typeB.Func02(); // Calls the Func02 method of TypeB

            #endregion
            #endregion
        }
    }
}
