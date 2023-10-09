namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool running = true;

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

                switch (userChoice)
                {
                    case 1:
                        Console.Write("\nFirst number: ");
                        double firstNumber = double.Parse(Console.ReadLine());

                        Console.Write("Second number: ");
                        double secondNumber = double.Parse(Console.ReadLine());

                        Console.WriteLine("Addition of these numbers: " + GetAnswer(firstNumber, secondNumber, userChoice) + "\n");
                        break;
                    case 2:
                        Console.Write("\nFirst number: ");
                        firstNumber = double.Parse(Console.ReadLine());

                        Console.Write("Second number: ");
                        secondNumber = double.Parse(Console.ReadLine());

                        Console.WriteLine("Subtraction of these numbers: " + GetAnswer(firstNumber, secondNumber, userChoice) + "\n");
                        break;
                    case 3:
                        Console.Write("\nFirst number: ");
                        firstNumber = double.Parse(Console.ReadLine());

                        Console.Write("Second number: ");
                        secondNumber = double.Parse(Console.ReadLine());

                        Console.WriteLine("Multiplication of these numbers: " + GetAnswer(firstNumber, secondNumber, userChoice) + "\n");
                        break;
                    case 4:
                        Console.Write("\nFirst number: ");
                        firstNumber = double.Parse(Console.ReadLine());

                        Console.Write("Second number: ");
                        secondNumber = double.Parse(Console.ReadLine());

                        Console.WriteLine("Division of these numbers: " + GetAnswer(firstNumber, secondNumber, userChoice) + "\n");
                        break;
                    case 5:
                        Console.WriteLine("\nIf you want to find power of numbers, you should look that:" +
                        "\nThe first number will be your number, which find its power");
                        Console.Write("\nFirst number: ");
                        firstNumber = double.Parse(Console.ReadLine());

                        Console.Write("Second number: ");
                        secondNumber = double.Parse(Console.ReadLine());

                        Console.WriteLine(firstNumber + "to the power of " + secondNumber + " (" +
                            firstNumber + "^" + secondNumber + "): " + GetAnswer(firstNumber, secondNumber, userChoice) + "\n");

                        break;
                    default:
                        running = false;
                        break;
                }

                if (running)
                {
                    Console.Write("Do you want to continue?(y/n): ");
                    string userContinueChoice = Console.ReadLine();
                    MyStringClass stringOperation = new MyStringClass();

                    if (stringOperation.ToLowerString(ref userContinueChoice) == "y" ||
                        stringOperation.ToLowerString(ref userContinueChoice) == "yes")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

            } while (running);
            Console.WriteLine("\n\t\tProgram has been stopped\n");
            Console.WriteLine("==========================================================");

        }

        static double GetAnswer(double firstNumber,  double secondNumber, int userInput)
        {
            double answer = 0;
            MyClass operation = new MyClass();

            switch (userInput)
            {
                case 1:
                    answer = operation.Addition(firstNumber, secondNumber);
                    break;
                case 2:
                    answer = operation.Subtraction(firstNumber, secondNumber);
                    break;
                case 3:
                    answer = operation.Multiplication(firstNumber, secondNumber);
                    break;
                case 4:
                    answer = operation.Division(firstNumber, secondNumber);
                    break;
                case 5:
                    answer = operation.Power(firstNumber, secondNumber);
                    break;
                default:
                    break;
            }

            return answer;
        }
    }
}