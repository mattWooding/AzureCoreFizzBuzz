using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TKMW.AzureCoreFizzBuzz.Models;
using TKMW.AzureCoreFizzBuzz.Interfaces;
using TKMW.AzureCoreFizzBuzz.Classes;
using TKMW.AzureCoreFizzBuzz.NumberProviders;
using TKMW.AzureCoreFizzBuzz.NumberHandlers;
using TKMW.AzureCoreFizzBuzz.OutputHandlers;


namespace TKMW.AzureCoreFizzBuzz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult FizzBuzz()
        {
            var outputList = new List<string>();
            IGame game = new Game(new OutputHandler(outputList), new NumberHandler(), new NumberProviderSequential(1, 100, 1));
            game.Go();

            var model = new FizzBuzzResponseModel();
            model.GameOutput = outputList;

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
