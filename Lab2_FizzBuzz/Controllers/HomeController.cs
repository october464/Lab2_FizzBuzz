using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab2_FizzBuzz.Models;
using System.Text;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Drawing.Printing;

namespace Lab2_FizzBuzz.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Solve()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Solve(string fizz, string buzz)
        {
            var firstNum = Convert.ToInt32(fizz);
            var secondNum = Convert.ToInt32(buzz);
            //Step 2:Do something with it
            var output = "";
            for (var i = firstNum; i <= secondNum; i++)
            {
                if (i % firstNum == 0 && i % secondNum == 0)
                {
                    if (secondNum != i)
                    {
                        output += "fizzbuzz, ";
                    }
                    else
                    {
                        output += "fizzbuzz, ";
                    }
                }
                else if (i % firstNum == 0)
                {
                    if (secondNum != i)
                    {
                        output += "fizz, ";
                    }
                    else
                    {
                        output += "fizz, ";
                    }
                }
                else if (i % secondNum == 0)
                {
                    if (secondNum != i)
                    {
                        output += "buzz, ";
                    }

                    else
                    {
                        output+= "buzz, ";
                    }
                }
                else
                {
                    if (secondNum != i)
                    {
                        output += i + ", ";
                    }
                    else
                    {
                        output += i;
                    }

                }
            }

            ViewData["Output"] = output;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
