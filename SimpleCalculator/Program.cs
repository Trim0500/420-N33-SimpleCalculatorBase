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

                StringBuilder sb = new StringBuilder();

                sb.AppendFormat("The value {0} {1} the value {2} is equal to {3:f2}", firstNumber, operation, secondNumber, result);

                Console.WriteLine(sb.ToString());

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
