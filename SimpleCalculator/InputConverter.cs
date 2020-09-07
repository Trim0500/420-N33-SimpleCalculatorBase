using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    //This method will attempt to convert parse the input into a numerical data type
    public class InputConverter
    {
        //The method will accept the user input as an argument
        public double ConvertInputToNumeric(string argTextInput)
        {
            //Create local variable convertedNumber
            double convertedNumber;
            //Attempt to convert the input, if it fails, throw an execption
            if (!double.TryParse(argTextInput, out convertedNumber)) throw new ArgumentException("Expected a numeric value.");

            //If it succeeds, the conversion is assigned to convertedNumber and returned
            return convertedNumber;
        }
    }
}
