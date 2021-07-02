using System;

namespace CodeAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            //WORKING WITH NUMBERS

            //Introduction to Working with Numbers 

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

            //Numerical Data Types

            // Number of pizza shops
            int pizzaShops = 4332;

            // Number of employees
            int totalEmployees = 86928;

            // Revenue
            decimal revenueEmployees = 390819.28m;

            // Log the values to the console:
            Console.WriteLine($"{pizzaShops}, {totalEmployees}, {revenueEmployees}");

            //Built-In Methods

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
