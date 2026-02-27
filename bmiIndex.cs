using System;

namespace MathApp
{
    class MathProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight in kilograms: ");
            double weightKg = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your height in centimeters: ");
            double heightCm = Convert.ToDouble(Console.ReadLine());

            weightKg = Math.Abs(weightKg);
            heightCm = Math.Max(50, Math.Min(heightCm, 250));

            double heightMi = heightCm / 100;
            double bmi = weightKg / Math.Pow(heightMi, 2);
            double myBmi = Math.Round(bmi, 2);

            string category;
            if (myBmi < 18.5)
                category = "Underweight";
            else if (myBmi < 25)
                category = "Normal";
            else if (myBmi < 30)
                category = "Overweight";
            else
                category = "Obese";

            Console.WriteLine();
            Console.WriteLine("BMI RESULT");
            Console.WriteLine("Your BMI: " + myBmi + " (" + category + ")");

            Console.ReadLine();
        }
    }
}