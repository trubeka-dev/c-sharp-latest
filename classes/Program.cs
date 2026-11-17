using System;
namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator app = new Calculator();
            int a1 = 1;
            Console.WriteLine(a1);
            app.GetSum(ref a1);
            Console.WriteLine(a1);
        }
        class Calculator
        {
            public void GetSum(ref int a)
            {
                a += 1;
            }
        }
    }
}