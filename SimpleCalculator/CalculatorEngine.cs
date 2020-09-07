using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate (string argOperation, double argFirstNumber, double argSecondNumber)
        {
            argOperation.ToLower();
            while (argOperation != "add" && argOperation != "+" && argOperation != "subtract" && argOperation != "-" && argOperation != "multiply" && argOperation != "*" && argOperation != "divide" && argOperation != "/")
            {
                Console.WriteLine("This opertaion is not recongnized. Try again.");
                Console.WriteLine("Try writing out the operation, add, or using the appropriate symbol, +,:");
                argOperation = Console.ReadLine();
            }
            double result;

            switch(argOperation)
            {
                case "add":
                case "+":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "subtract":
                case "-":
                    result = argFirstNumber - argSecondNumber;
                    break;
                case "multiply":
                case "*":
                    result = argFirstNumber * argSecondNumber;
                    break;
                case "divide":
                case "/":
                    result = argFirstNumber / argSecondNumber;
                    break;
                default:
                    throw new InvalidOperationException("Specified operation is not recognized.");
            }
            return result;
        }
    }
}
