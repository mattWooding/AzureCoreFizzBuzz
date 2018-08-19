using System;
using TKMW.AzureCoreFizzBuzz.Interfaces;

namespace TKMW.AzureCoreFizzBuzz.NumberHandlers
{
    public class NumberHandler : INumberHandler
    {

        public NumberHandler()
        {

        }

        /// <summary>
        /// Checks the input and returns Fizz for 3, Buzz for 5 and FizzBuzz for both
        /// </summary>
        /// <returns>The message.</returns>
        /// <param name="theNumber">A number</param>
        public string GetMessage(int theNumber)
        {
            var result = "";
            if (theNumber % 3 == 0)
            {
                result += "Fizz";
            }
            if (theNumber % 5 == 0)
            {
                result += "Buzz";
            }
            if (result == string.Empty)
            {
                result = theNumber.ToString();
            }
            return result;
        }

    }
}
