using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Simple Calculator!");

        while (true)
        {
            Console.Write("Choose operation (+, -, *, /) or type 'exit' to quit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            Console.Write("Enter first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }

            Console.Write("Enter second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                continue;
            }

            double result = 0;
            bool validOperation = true;

            switch (input)
            {
                case "+":
                    result = Add(num1, num2);
                    break;
                case "-":
                    result = Subtract(num1, num2);
                    break;
                case "*":
                    result = Multiply(num1, num2);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        validOperation = false;
                    }
                    else
                    {
                        result = Divide(num1, num2);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    validOperation = false;
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine($"Result: {num1} {input} {num2} = {result}");
            }

            Console.WriteLine();
        }
    }

    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b) => a / b;
}
