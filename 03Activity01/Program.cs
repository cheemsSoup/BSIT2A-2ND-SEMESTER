

using System;
namespace MathApp
{
    class MathProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO CALC");
            Console.WriteLine("Calc is short for calculator btw");
            Console.WriteLine("Im just using slang");

            Console.WriteLine("\n[1] Power");
            Console.WriteLine("Enter base number.");
            Console.Write(": ");
            double baseNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter exponent.");
            Console.Write(": ");
            double expNum = Convert.ToDouble(Console.ReadLine());
            double powerResult = Math.Pow(baseNum, expNum);
            Console.WriteLine(baseNum + " raised to " + expNum + " is " + powerResult);

            Console.WriteLine("\n[2] Square Root");
            Console.WriteLine("Enter base number.");
            Console.Write(": ");
            double sqrNum = Convert.ToDouble(Console.ReadLine());
            double sqrResult = Math.Sqrt(sqrNum);
            Console.WriteLine("The square root of " + sqrNum + " is " + sqrResult);

            Console.WriteLine("\n[3] Absolute Value");
            Console.WriteLine("Enter negative number.");
            Console.Write(": ");
            double negativeNum = Convert.ToDouble(Console.ReadLine());
            double absResult = Math.Abs(negativeNum);
            Console.WriteLine("The absolute number of " + negativeNum + " is " + absResult);

            Console.WriteLine("\n[4] Round UP");
            Console.WriteLine("Enter a decimal to round UP (ceiling).");
            Console.Write(": ");
            double ceilingNum = Convert.ToDouble(Console.ReadLine());
            double ceilingResult = Math.Ceiling(ceilingNumNum);
            Console.WriteLine("The ceiling of " + ceilingNumNum + " is " + ceilingNum);

            Console.WriteLine("\n[5] Round OFF");
            Console.WriteLine("Enter a decimal number to round off.");
            Console.Write(": ");
            double roundNum = Convert.ToDouble(Console.ReadLine());
            double roundResult = Math.Abs(roundNum);
            Console.WriteLine("The rounded value of " + roundNum + " is " + roundResult);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
