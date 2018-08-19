using System;
using TKMW.AzureCoreFizzBuzz.Interfaces;
using TKMW.AzureCoreFizzBuzz.Models;
using TKMW.AzureCoreFizzBuzz.NumberProviders;
using TKMW.AzureCoreFizzBuzz.NumberHandlers;

namespace TKMW.AzureCoreFizzBuzz.Classes
{
    public class Game : IGame
    {
        private FizzBuzzResponseModel model;
        private IOutputHandler outputHandler;
        private INumberHandler numberHandler;
        private INumberProvider numberProvider;

        public Game(IOutputHandler outputHandler, INumberHandler numberHandler, INumberProvider numberProvider)
        {
            this.model = model;
            this.outputHandler = outputHandler;
            this.numberHandler = numberHandler;
            this.numberProvider = numberProvider;
        }

        public void Go()
        {
            while (numberProvider.Next())
            {
                outputHandler.Output(numberHandler.GetMessage(numberProvider.TheNumber));
            }
        }
    }
}
