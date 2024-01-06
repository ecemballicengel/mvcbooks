using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcbooks.Models;

namespace mvcbooks.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View(Repository.Books);
    }

    public IActionResult Privacy()
    {
        return View();
    }

}
