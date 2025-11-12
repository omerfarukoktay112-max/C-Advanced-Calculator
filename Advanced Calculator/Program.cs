using System;
using System.Threading;

namespace Advanced_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Advanced Calculator");
            Console.WriteLine("--------------------");

            while (true)
            {
                Console.WriteLine("Action To Be Taken");
                Console.WriteLine("--------------------");
                Console.WriteLine("Addition -> +");
                Console.WriteLine("Subtraction -> -");
                Console.WriteLine("Multiplication -> *");
                Console.WriteLine("Division -> /");
                Console.WriteLine("Square Root -> sr");
                Console.WriteLine("Exponentiation -> ex");
                Console.WriteLine("Logarithm -> lg");
                Console.WriteLine("Absolute Value -> mv");
                Console.WriteLine("--------------------");
                Console.Write("Action to be taken: ");
                string girdi = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("--------------------");

                double transaction_result = 0;

                if (girdi == "+" || girdi == "-" || girdi == "/" || girdi == "*" ||
                    girdi == "sr" || girdi == "ex" || girdi == "lg" || girdi == "mv")
                {
                    if (girdi == "+" || girdi == "-" || girdi == "/" || girdi == "*" || girdi == "ex")
                    {
                        if (girdi == "+" || girdi == "-" || girdi == "/" || girdi == "*")
                        {
                            Console.Write("1st number: ");
                            double number1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("2nd number: ");
                            double number2 = Convert.ToDouble(Console.ReadLine());

                            switch (girdi)
                            {
                                case "+":
                                    transaction_result = number1 + number2;
                                    Console.WriteLine("Addition result: " + transaction_result);
                                    break;

                                case "-":
                                    transaction_result = number1 - number2;
                                    Console.WriteLine("Subtraction result: " + transaction_result);
                                    break;

                                case "*":
                                    transaction_result = number1 * number2;
                                    Console.WriteLine("Multiplication result: " + transaction_result);
                                    break;

                                case "/":
                                    if (number2 == 0)
                                        Console.WriteLine("Error: Division by zero is not allowed!");
                                    else
                                    {
                                        transaction_result = number1 / number2;
                                        Console.WriteLine("Division result: " + transaction_result);
                                    }
                                    break;
                            }
                        }
                        else
                        {
                            Console.Write("Base number: ");
                            double number1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Exponent value: ");
                            double number2 = Convert.ToDouble(Console.ReadLine());
                            transaction_result = Math.Pow(number1, number2);
                            Console.WriteLine("Exponentiation result: " + transaction_result);
                        }
                    }
                    else
                    {
                        Console.Write("Enter the number: ");
                        double number1 = Convert.ToDouble(Console.ReadLine());

                        switch (girdi)
                        {
                            case "lg":
                                transaction_result = Math.Log10(number1);
                                Console.WriteLine("Logarithm result: " + transaction_result);
                                break;

                            case "sr":
                                transaction_result = Math.Sqrt(number1);
                                Console.WriteLine("Square root result: " + transaction_result);
                                break;

                            case "mv":
                                transaction_result = Math.Abs(number1);
                                Console.WriteLine("Absolute value: " + transaction_result);
                                break;
                        }
                    }

                    Console.WriteLine("--------------------");
                    Console.Write("Will you continue? (yes - no): ");
                    string vote = Console.ReadLine().ToLower();

                    if (vote == "yes")
                    {
                        Console.WriteLine("Returning to main menu...");
                        Thread.Sleep(600);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Exiting...");
                        Thread.Sleep(1000);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid operation, restarting...");
                    Thread.Sleep(1800);
                    Console.Clear();
                }
            }
        }
    }
}
