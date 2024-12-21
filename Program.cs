using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double lastResult = 0;
            bool continueCalculation = true;

            while (continueCalculation)
            {
                Console.WriteLine("Welcome to the Simple Calculator!");

                Console.Write("Enter the first number: ");
                double number1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double number2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Console.WriteLine("5 - Exponentiation (Power)");
                Console.WriteLine("6 - Square Root");
                Console.WriteLine("7 - Use the last result");

                int choice = Convert.ToInt32(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = number1 + number2;
                        break;
                    case 2:
                        result = number1 - number2;
                        break;
                    case 3:
                        result = number1 * number2;
                        break;
                    case 4:
                        if (number2 != 0)
                            result = number1 / number2;
                        else
                            Console.WriteLine("Division by zero is not allowed!");
                        break;
                    case 5:
                        result = Math.Pow(number1, number2);
                        break;
                    case 6:
                        if (number1 >= 0)
                            result = Math.Sqrt(number1);
                        else
                            Console.WriteLine("The number must be non-negative to calculate the square root!");
                        break;
                    case 7:
                        result = lastResult;
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        continue;
                }

                Console.WriteLine("Result: " + result);
                lastResult = result;

                Console.WriteLine("Do you want to perform another operation? (y/n)");
                continueCalculation = Console.ReadLine().ToLower() == "y";
            }
        }
    }
}
