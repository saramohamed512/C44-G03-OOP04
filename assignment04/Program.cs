namespace assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Calculator
            //Calculator calc = new Calculator();
            //Console.WriteLine($"Add two integers: 5 + 3 = {calc.Add(5, 3)}");
            //Console.WriteLine($"Add three integers: 5 + 3 + 2 = {calc.Add(5, 3, 2)}");
            //Console.WriteLine($"Add two doubles: 5.5 + 3.2 = {calc.Add(5.5, 3.2)}");
            #endregion
            #region Q2 - Rectangle
            Rectangle rect1 = new Rectangle();
            Rectangle rect2 = new Rectangle(5, 10);
            Rectangle rect3 = new Rectangle(7);
            Console.WriteLine(rect1);
            Console.WriteLine(rect2);
            Console.WriteLine(rect3);
            #endregion


        }
    }
}
