using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        //The method Calculate will accept the operation selected, the first value and the seconf value inputed by the user and use a switch statment to perform an operation
        public double Calculate (string argOperation, double argFirstNumber, double argSecondNumber)
        {
            //Create local variable result to return
            double result;

            //Create switch statement accepting the operation string and putting it to lower case to limit case-sensitive errors
            switch(argOperation.ToLower())
            {
                //If the user chose to add, the first and second values are added together
                case "add":
                case "+":
                    result = argFirstNumber + argSecondNumber;
                    break;
                //If the user chose to subtract, the first value is reduced by the second
                case "subtract":
                case "-":
                    result = argFirstNumber - argSecondNumber;
                    break;
                //If the user chose to multiply, the first value is multiplied by the second
                case "multiply":
                case "*":
                    result = argFirstNumber * argSecondNumber;
                    break;
                //If the user chose to divide, the first value is divided by the second
                case "divide":
                case "/":
                    result = argFirstNumber / argSecondNumber;
                    break;
                //If the user did not put in a valid operation, throw an execption
                default:
                    throw new InvalidOperationException("Specified operation is not recognized.");
            }
            return result;
        }
    }
}
