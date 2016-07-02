using System;
namespace XUnitDebugging
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var test = new TestClass();
            test.PassingTest();
            Console.WriteLine("Enter text...");
            Console.ReadLine();

        }
    }
}