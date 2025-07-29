namespace assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Calculator
            Calculator calc = new Calculator();
            Console.WriteLine($"Add two integers: 5 + 3 = {calc.Add(5, 3)}");
            Console.WriteLine($"Add three integers: 5 + 3 + 2 = {calc.Add(5, 3, 2)}");
            Console.WriteLine($"Add two doubles: 5.5 + 3.2 = {calc.Add(5.5, 3.2)}");
            #endregion
        }
    }
}
