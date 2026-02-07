using System;
namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            int grade1, grade2, grade3, grade4, grade5;
            double initialGrade;
            double averageGrade;
            double convertedAverageGrade;

            Console.WriteLine("WELCOME TO GRADE CALCULATOR");

            Console.WriteLine("Enter 5 grades for each new line.");
            Console.Write(": ");
            grade1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(": ");
            grade2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(": ");
            grade3 = Convert.ToInt32(Console.ReadLine());
            Console.Write(": ");
            grade4 = Convert.ToInt32(Console.ReadLine());
            Console.Write(": ");
            grade5 = Convert.ToInt32(Console.ReadLine());

            initialGrade = grade1 + grade2 + grade3 + grade4 + grade5;
            averageGrade = initialGrade / 5;
            convertedAverageGrade = Math.Round(averageGrade);
            
            Console.WriteLine("The average grade is " + averageGrade + " rounded off to " + convertedAverageGrade);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}