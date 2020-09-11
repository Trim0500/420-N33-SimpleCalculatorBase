using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CalculatorEngine;

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

                bool confirmation = false;

                while (confirmation != true)
                {

                    double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                    double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                    string operation = Console.ReadLine();

                    Console.WriteLine("Are you sure that you've entered the right values?");
                    Console.WriteLine("If yes, then write Yes/yes, if no, then write No/no to re-enter them.");
                    string anwser = "";
                
                    while(anwser != "yes" && anwser != "Yes" && anwser != "no" && anwser != "No") { 
                        
                        anwser = Console.ReadLine();


                        if (anwser == "yes" || anwser == "Yes")
                        {
                            double result = CalcEng.Calculate(operation, firstNumber, secondNumber);
                            String resultLine = "";
                            resultLine += String.Format("First number entered: {0:F2}\n", firstNumber);
                            resultLine += String.Format("Second number entered: {0:F2}\n", secondNumber);
                            resultLine += String.Format("Operation used: {0}\n", operation);
                            resultLine += String.Format("The result is: {0:F2}", result);

                            StringBuilder SB = new StringBuilder(resultLine);

                            Console.WriteLine(SB.ToString());
                            confirmation = true;
                        }
                        else if (anwser == "no" || anwser == "No")
                        {
                            confirmation = false;
                            Console.WriteLine("You can now re-enter the values.");
                        }
                        else
                        {
                            Console.WriteLine("Please answer yes or no.");
                        }

                    }
 
                }


            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
