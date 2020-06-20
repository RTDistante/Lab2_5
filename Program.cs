using System;

namespace Lab2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 2.5 Problem 1"); 
            Console.WriteLine("Math with two integers");
            Console.WriteLine("Enter first number");
            int userInputOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int userInputTwo = int.Parse(Console.ReadLine());
            int twoNumberSum = (userInputOne + userInputTwo);
            int twoNumberSubtract = (userInputOne - userInputTwo);
            int twoNumberMultiply = (userInputOne * userInputTwo);
            int twoNumberDivide = (userInputOne / userInputTwo);
            Console.WriteLine(userInputOne + " + " + userInputTwo + " = " + twoNumberSum);
            Console.WriteLine(userInputOne + " - " + userInputTwo + " = " + twoNumberSubtract);
            Console.WriteLine(userInputOne + " * " + userInputTwo + " = " + twoNumberMultiply);
            Console.WriteLine(userInputOne + " / " + userInputTwo + " = " + twoNumberDivide);
            
            Console.WriteLine("Lab 2.5 Problem 2");
            Console.WriteLine("What is your name?");
            string userInputName = Console.ReadLine();
            Console.WriteLine("Hello " + userInputName);

            Console.WriteLine("Lab 2.5 Problem 3");
            Console.WriteLine("Multiply any three integers");
            int userInputMultiply1 = int.Parse(Console.ReadLine());
            int userInputMultiply2 = int.Parse(Console.ReadLine());
            int userInputMultiply3 = int.Parse(Console.ReadLine());
            int threeNumbersMultiplied = (userInputMultiply1 * userInputMultiply2 * userInputMultiply3);
            Console.WriteLine(userInputMultiply1 * userInputMultiply2 * userInputMultiply3);
            Console.WriteLine(userInputMultiply1 + " * " + userInputMultiply2 + " * " + userInputMultiply3 + " equals " + threeNumbersMultiplied);

            Console.WriteLine("Lab 2.5 Problem 4");
            Console.WriteLine("What is your age?");
            string userInputAge = Console.ReadLine();
            Console.WriteLine("You look younger than " + userInputAge);
        }
    }
}
