using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate (string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;
            bool recognized = false;

            while (recognized != true)
            {
                switch(argOperation.ToLower())
                {
                    case "add":
                    case "+":
                        result = argFirstNumber + argSecondNumber;
                        recognized = true;
                        break;
                    case "subtract":
                    case "-":
                        result = argFirstNumber - argSecondNumber;
                        recognized = true;
                        break;
                    case "multiply":
                    case "*":
                        result = argFirstNumber * argSecondNumber;
                        recognized = true;
                        break;
                    case "divide":
                    case "/":
                        result = argFirstNumber / argSecondNumber;
                        recognized = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid operation (e.g. add +, subtract -, multiply * or divide /)");
                        argOperation = Console.ReadLine();
                        break;
                       
                }


            }
            return result;

        }
    }
}
