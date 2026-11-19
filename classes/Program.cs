using System;
using System.Diagnostics.Metrics;
using System.Reflection;
namespace classes
{
    class Program
    {

        static void Main(string[] args)
        {
            Calculator app2 = new Calculator();
            Calculator app = new Calculator();
            app.lichn = 5;
            Calculator.obsh = 10;
            Console.WriteLine(app.lichn + app2.lichn);
        }
    }
    class Calculator
    {
        public static int obsh = 0;
        public int lichn = 1;
    }
}