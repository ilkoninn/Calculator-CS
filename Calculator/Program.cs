namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("=================== Calculator Program ===================");
            do
            {
                count++;
                if (count == 1) Console.WriteLine("Hello, this is C# calculator program :D");
                else Console.WriteLine("\n======= Calculator Program =======");

                Console.Write(
                    "\n 1 - Addition" +
                    "\n 2 - Subtraction" +
                    "\n 3 - Multiplication" +
                    "\n 4 - Division" +
                    "\n 5 - Power" +
                    "\nExit(Any number)" +
                    "\n\nPlease choose a operation ID(1-5): ");
                int userChoice = int.Parse(Console.ReadLine());

                MyClass operation = new MyClass();
                double answer = 0;
                if (userChoice == 1)
                {
                    Console.Write("\nFirst number: ");
                    double firstNumber = double.Parse(Console.ReadLine());

                    Console.Write("Second number: ");
                    double secondNumber = double.Parse(Console.ReadLine());

                    answer = operation.Addition(firstNumber, secondNumber);

                    Console.WriteLine("Addition of these numbers: " + answer + "\n");

                }
                else if (userChoice == 2)
                {
                    Console.Write("\nFirst number: ");
                    double firstNumber = double.Parse(Console.ReadLine());

                    Console.Write("Second number: ");
                    double secondNumber = double.Parse(Console.ReadLine());

                    answer = operation.Subtraction(firstNumber, secondNumber);

                    Console.WriteLine("Subtraction of these numbers: " + answer + "\n");
                }
                else if (userChoice == 3)
                {
                    Console.Write("\nFirst number: ");
                    double firstNumber = double.Parse(Console.ReadLine());

                    Console.Write("Second number: ");
                    double secondNumber = double.Parse(Console.ReadLine());

                    answer = operation.Multiplication(firstNumber, secondNumber);

                    Console.WriteLine("Multiplication of these numbers: " + answer + "\n");
                }
                else if (userChoice == 4)
                {
                    Console.Write("\nFirst number: ");
                    double firstNumber = double.Parse(Console.ReadLine());

                    Console.Write("Second number: ");
                    double secondNumber = double.Parse(Console.ReadLine());

                    answer = operation.Division(firstNumber, secondNumber);

                    Console.WriteLine("Division of these numbers: " + answer + "\n");
                }
                else if (userChoice == 5)
                {
                    Console.WriteLine("\nIf you want to find power of numbers, you should look that:" +
                        "\nThe first number will be your number, which find its power");
                    Console.Write("\nFirst number: ");
                    double firstNumber = double.Parse(Console.ReadLine());

                    Console.Write("Second number: ");
                    double secondNumber = double.Parse(Console.ReadLine());

                    answer = operation.Power(firstNumber, secondNumber);

                    Console.WriteLine(firstNumber + "to the power of " + secondNumber + " (" +
                        firstNumber + "^" + secondNumber + "): " + answer + "\n");

                }
                else
                {
                    break;
                }

                Console.Write("Do you want to continue?(y/n): ");
                string userContinueChoice = Console.ReadLine();

                if (operation.ToLowerString(ref userContinueChoice) == "y" || operation.ToLowerString(ref userContinueChoice) == "yes")
                {
                    continue;
                }
                else
                {
                    break;
                }

            } while (true);
            Console.WriteLine("\n\t\tProgram has been stopped\n");
            Console.WriteLine("==========================================================");


        }
    }
}