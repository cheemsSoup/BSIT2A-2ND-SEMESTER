using System;
namespace DataTypesApp
{
    class DataTypesProgram
    {
        static void Main(string[] args)
        {
            int numberApple;
            double priceApple;
            int convertedPriceApple;

            Console.WriteLine("WELCOME TO APOL STORE!");

            Console.WriteLine("Enter the pieces of apple.");
            Console.Write(": ");
            numberApple = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the total amount of " + numberApple + " apple(s).");
            Console.Write(": ");
            priceApple = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The total price of " + numberApple + " apple(s) is " + priceApple + " PHP");

            Console.WriteLine("\nITEM DETAILS");
            convertedPriceApple = (int)priceApple;
            
            Console.WriteLine("The value of original price is " + priceApple);
            Console.WriteLine("The value of converted price is " + convertedPriceApple);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}