using bookshop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace bookshop.Controllers
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

        public IActionResult Form(string fname, string lname, string mail, string p_no, string gen, string cust, string msg)
        {

            if(fname == "" && lname == "" && mail == "" && p_no == ""&& gen == ""&& cust == ""&& msg == "") {
                ViewBag.message = "Successful";
            }
            else
            {
                ViewBag.message = "Failed ";
            }
                return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}