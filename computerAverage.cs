using System;
namespace ComputerAverage
{
    class ComputerAverageProgram
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Enter 5 grades separated by new line: ");

            int first;
            first = Convert.ToInt32(Console.ReadLine());
            int second;
            second = Convert.ToInt32(Console.ReadLine());
            int third;
            third = Convert.ToInt32(Console.ReadLine());
            int fourth;
            fourth = Convert.ToInt32(Console.ReadLine());
            int fifth;
            fifth = Convert.ToInt32(Console.ReadLine());

            double totalGrades = first + second + third + fourth + fifth;
            double average = totalGrades / 5;

            int roundOff;
            roundOff = Convert.ToInt32(Math.Round(average));

            Console.WriteLine("The average is " +  average + " and round off to " + roundOff);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}