using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    //Modified by: Tristan Lafleur & Randy Chunn
    class Program
    {
        //This program will perform some basic arithmetic operations by asking the user to enter values and choosing which operation to use
        static void Main(string[] args)
        {
            try
            {
                //Class to convert user input
                InputConverter inputConverter = new InputConverter();

                //Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                //Greet the user
                Console.WriteLine("Welcome to the Simple Calculator!");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Enter a whole or decimal number:");
                //Prompt the user to enter a value
                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Enter the next number:");
                //Prompt the user to enter the next value
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Choose which arithmetic operation to perform (add, subtract, etc.):");
                //Prompt the user to choose which operation to do as per the switch cases in the calculator engine
                string operation = Console.ReadLine();

                //Calculate the result
                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                //Display the result to the user
                Console.WriteLine(result);

            }
            //Catch statement for errors
            catch (Exception ex)
            {
                //Show the error message
                Console.WriteLine(ex.Message);
            }
        }
    }
}
