using System;
namespace DataTypeApp
{
    class DataTypeProgram
    {
        static void Main (string[] args)
        {
            string fullName = "Juan Antonio Dela Cruz";
            int age = 21;
            double height = 5.7;
            bool isStudent = true;
            char grade = 'A';
            const double Pi = 3.14;

            Console.WriteLine("Full name: " + fullName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Is he/she/they a student?: " + isStudent);
            Console.WriteLine("What is his/her/their grade?: " + grade);
            Console.WriteLine("Pi: " + Pi);

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}