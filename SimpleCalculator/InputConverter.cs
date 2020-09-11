using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumeric(string argTextInput)
        {
            double convertedNumber;
            while (!double.TryParse(argTextInput, out convertedNumber))
            {
                Console.WriteLine("Not a valid number, try again.");
                Console.WriteLine("Try a proper number like 5, 5.2, etc.:");
                argTextInput = Console.ReadLine();
                double.TryParse(argTextInput, out convertedNumber);
            }

            return convertedNumber;
        }
    }
}
