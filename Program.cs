using System;

namespace CodeAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*WORKING WITH NUMBERS*/

            /*Introduction to Working with Numbers*/

            // Calculating Net Income
            double revenue = 853023.45;
            double expenses = 438374.11;
            double netIncome = revenue - expenses;

            Console.WriteLine(netIncome);

            // Calculating a Break-Even Point
            double fixedCosts = 912849.30;
            double salesPrice = 29.99;
            double variableCostPerUnit = 17.65;

            double breakEvenVolume = fixedCosts / (salesPrice - variableCostPerUnit);
            Console.WriteLine(breakEvenVolume);

            /*Numerical Data Types*/

            // Number of pizza shops
            int pizzaShops = 4332;

            // Number of employees
            int totalEmployees = 86928;

            // Revenue
            decimal revenueEmployees = 390819.28m;

            // Log the values to the console:
            Console.WriteLine($"{pizzaShops}, {totalEmployees}, {revenueEmployees}");

            /*Arithmetic Operators*/

            // Your Age
            int userAge = 29;
            Console.WriteLine("User age: " + userAge);

            // Length of years on Jupiter (in Earth years)
            double jupiterYears = 11.86;
            Console.WriteLine("Length of years on Jupiter (in Earth years): " + jupiterYears);

            // Age on Jupiter
            double jupiterAge = userAge / jupiterYears;
            Console.WriteLine("Jupiter age: " + jupiterAge);

            // Time to Jupiter
            double journeyToJupiter = 6.142466;
            Console.WriteLine("Journey to Jupiter: " + journeyToJupiter);

            // New Age on Earth
            double newEarthAge = userAge + journeyToJupiter;
            Console.WriteLine("New Age on Earth: " + newEarthAge);

            // New Age on Jupiter
            double newJupiterAge = newEarthAge / jupiterYears;
            Console.WriteLine("New Age on Jupiter: " + newJupiterAge);

            // Log calculations to console
            Console.WriteLine(newEarthAge);
            Console.WriteLine(newJupiterAge);

            /*Operator Shortcuts*/

            // declare steps variable
            int steps = 0;

            // Two steps forward 
            steps += 2;

            // One step back 
            steps--;

            // Print result to the console
            Console.WriteLine(steps);

            /*Modulo*/

            // Number of students
            int students = 18;

            // Number of students in a group
            int groupSize = 2;

            // Does groupSize go evenly into students?

            Console.WriteLine(students % groupSize);

            /*Built-In Methods*/

            // Starting variables 
            int numberOne = 12932;
            int numberTwo = -2828472;

            // Use built-in methods and save to variable
            /*double numberOneSqrt = Math.Floor(Math.Sqrt(numberOne));
            double numberTwoSqrt = Math.Floor(Math.Sqrt(numberTwo));*/

            Console.WriteLine(Math.Floor(Math.Sqrt(numberOne)));
            Console.WriteLine(Math.Floor(Math.Sqrt(numberTwo)));

        }
    }
}
