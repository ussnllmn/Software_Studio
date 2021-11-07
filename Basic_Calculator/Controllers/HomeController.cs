using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BasicCalculator.Models;
using System.Collections;
using System.Text.RegularExpressions;


namespace BasicCalculator.Controllers
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

    public IActionResult Calculate(String prop)
    {
      List<String> expt = new List<String>();
      double current = 0;

      foreach (var match in Regex.Matches(prop, @"([*+/\-)(])|([0-9]+)"))
      {
        expt.Add(match.ToString());
      }
      String[] arr = expt.ToArray();

      try
      {
        for (int i = 0; i < arr.Length; i++)
        {
          if (arr[i].ToString() == "+")
          {
            double next = Convert.ToDouble(arr[i + 1].ToString());
            current = current + next;
          }
          else if (arr[i].ToString() == "-")
          {
            double next = Convert.ToDouble(arr[i + 1].ToString());
            current = current - next;
          }
          else if (arr[i].ToString() == "*")
          {
            double next = Convert.ToDouble(arr[i + 1].ToString());
            current = current * next;
          }
          else if (arr[i].ToString() == "/")
          {
            double next = Convert.ToDouble(arr[i + 1].ToString());
            current = current / next;
          }

          //first index
          if (i == 0)
          {
            String str = arr[i].ToString();
            current = Convert.ToDouble(str);
          }
        }

        return Content(current.ToString(), "text/plain");
      }
      catch (Exception e)
      {
        System.Console.WriteLine(e.ToString());
        return Content("Error", "text/plain");
      }

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


/*6+6+6
current = 6
next = 6
result = 12



*/