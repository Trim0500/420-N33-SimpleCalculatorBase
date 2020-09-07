using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Class to convert user input
                InputConverter inputConverter = new InputConverter();

                //Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                String resultLine = "";
                resultLine += String.Format("First number entered: {0:F2}\n", firstNumber);
                resultLine += String.Format("Second number entered: {0:F2}\n", secondNumber);
                resultLine += String.Format("Operation used: {0}\n", operation);
                resultLine += String.Format("The result is: {0:F2}", result);

                StringBuilder SB = new StringBuilder(resultLine);

                Console.WriteLine(SB.ToString());

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
