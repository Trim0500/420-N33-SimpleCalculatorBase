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
                Console.WriteLine("Please enter a numeric value (e.g. 1, 2 or 3)");
                argTextInput = Console.ReadLine();
                double.TryParse(argTextInput, out convertedNumber);
            }

            return convertedNumber;
        }
    }
}
