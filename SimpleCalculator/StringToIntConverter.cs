using System;

namespace SimpleCalculator
{
    class StringToIntConverter
    {
        //This method will see if the conversion occurred wo/error, it accepts the user input as an argument
        public int convert(string input)
        {
            try
            {
                //get convertedNumber from InputConverter
                int convertedNumber;
                //Create boolean expression to determine if conversion was done correctly
                bool isConvertedSucessfully = int.TryParse(input, out convertedNumber);

                //If the conversion failed, throw an execption
                if (!isConvertedSucessfully)
                {
                    throw new Exception("Conversion was not successfull.");

                }

                //If it succeeded, return the number
                return convertedNumber;
            }
            //Create a catch statement for error handling
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
