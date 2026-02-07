using System;
namespace DataTypeApp
{
    class DataTypeProgram
    {
        static void Main(string[] args)
        {
            String name;
            String address;
            string item;
            double price;
            bool payment = true;
            int estDelivery = 3;
            DateTime today = DateTime.Now;

            Console.WriteLine("WELCOME TO APOL STORE!");

            Console.WriteLine("I am your assistant, please enter your name.");
            Console.Write(": ");
            name = Console.ReadLine()!;
            Console.WriteLine("Hello, " + name + ".");

            Console.WriteLine("What would you like to get in our catalog? ");
            Console.Write(": ");
            item = Console.ReadLine()!;

            Console.WriteLine("How much is the price? ");
            Console.Write(": ");
            price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Where can we ship it? ");
            Console.Write(": ");
            address = Console.ReadLine()!;

            Console.WriteLine("\nITEM DETAILS");

            Console.WriteLine(item + " - " + price + " PHP");

            Console.WriteLine("Name: " + name);

            Console.WriteLine("Address: " + address);

            Console.WriteLine("Payment Status: " + payment);

            Console.WriteLine("Date of Order: " + today);

            Console.WriteLine("Estimated Time of Delivery: " + estDelivery + " Business Days");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}