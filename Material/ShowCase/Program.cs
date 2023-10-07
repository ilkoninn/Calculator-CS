using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================== Calculator Program ===================");

            int count = 0;
            do
            {
                count++;
                if (count > 1)
                {
                    Console.WriteLine("\n======= Calculator Program =======");
                }
                else
                {
                    Console.WriteLine("Hello, this is C# calculator program :D");
                }

                Console.Write(
                    "\n 1 - Addition" +
                    "\n 2 - Subtraction" +
                    "\n 3 - Multiplication" +
                    "\n 4 - Division" +
                    "\n 5 - Power" +
                    "\nExit(Any number)" +
                    "\n\nPlease choose an operation ID (1-5): ");

                int userChoice;
                if (!int.TryParse(Console.ReadLine(), out userChoice) || userChoice < 1 || userChoice > 5)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.\n");
                    break;
                }

                MyMath operation = new MyMath();
                double answer = 0;

                switch (userChoice)
                {
                    case 1:
                        answer = GetValidNumber("Enter the first number: ") + GetValidNumber("Enter the second number: ");
                        Console.WriteLine("Addition of these numbers: " + answer + "\n");
                        break;
                    case 2:
                        answer = GetValidNumber("Enter the first number: ") - GetValidNumber("Enter the second number: ");
                        Console.WriteLine("Subtraction of these numbers: " + answer + "\n");
                        break;
                    case 3:
                        answer = GetValidNumber("Enter the first number: ") * GetValidNumber("Enter the second number: ");
                        Console.WriteLine("Multiplication of these numbers: " + answer + "\n");
                        break;
                    case 4:
                        double dividend = GetValidNumber("Enter the dividend: ");
                        double divisor = GetValidNumber("Enter the divisor: ");
                        try
                        {
                            answer = dividend / divisor;
                            Console.WriteLine("Division of these numbers: " + answer + "\n");
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine("Error: " + "Division by Zero Occured!" + "\n");
                        }
                        break;
                    case 5:
                        double firstNumber = GetValidNumber("Enter the first number: ");
                        double secondNumber = GetValidNumber("Enter the second number: ");
                        try
                        {
                            answer = Math.Pow(firstNumber, secondNumber);
                            Console.WriteLine(firstNumber + " to the power of " + secondNumber + " (" +
                                firstNumber + "^" + secondNumber + "): " + answer + "\n");
                        }
                        catch (OverflowException ex)
                        {
                            Console.WriteLine("Error: " + "Overflow Occured!" + "\n");
                        }
                        break;
                }

                Console.Write("Do you want to continue? (y/n): ");
                string userContinueChoice = Console.ReadLine();

                if (userContinueChoice.ToLower() != "y" && userContinueChoice.ToLower() != "yes")
                {
                    break;
                }

            } while (true);

            Console.WriteLine("\nProgram has been stopped\n");
            Console.WriteLine("==========================================================");
        }

        static double GetValidNumber(string message)
        {
            double number;
            while (true)
            {
                Console.Write(message);
                if (double.TryParse(Console.ReadLine(), out number))
                {
                    return number;
                }
                Console.WriteLine("Invalid input. Please enter a valid number.\n");
            }
        }
    }
}