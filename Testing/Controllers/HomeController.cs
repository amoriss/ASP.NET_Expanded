using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Testing.Models;

namespace Testing.Controllers
{
    public class HomeController : Controller
    {

        /*Controller: Handles a request and hands it to the correct view and model.
        Controller handles the user request.Typically, users interact with View,
        which in-turn raises the appropriate URL request, this request will 
        be handled by a controller.The controller renders the appropriate 
        view with the model data as a response.*/

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
