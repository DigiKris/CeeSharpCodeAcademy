using System;

namespace CodeAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
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
