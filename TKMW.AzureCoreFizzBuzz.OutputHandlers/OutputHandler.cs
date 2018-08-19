using System;
using System.Collections.Generic;
using TKMW.AzureCoreFizzBuzz.Interfaces;

namespace TKMW.AzureCoreFizzBuzz.OutputHandlers
{
    public class OutputHandler : IOutputHandler
    {
        private List<string> output;

        public OutputHandler(List<string> output)
        {
            this.output = output;
        }

        public void Output(string message)
        {
            output.Add(message);
        }
    }
}
