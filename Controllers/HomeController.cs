using bookshop.DataBase;
using bookshop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace bookshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DBContext dbcontext;

        public HomeController(ILogger<HomeController> logger, DBContext dBContext)
        {
            _logger = logger;
            dbcontext = dBContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult login(Register register)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    dbcontext.Add(register);
                    dbcontext.SaveChanges();
                    ViewBag.message = "Saved Successfully";
                }
                catch
                {
                    ViewBag.message = "Not Saved ";
                }
                
            }
           
            return View(Index);      
        }

        public IActionResult Form(string fname, string lname, string mail, string p_no)
        {
            if (fname == "mehru" && lname == "nisa" && mail == "abc@gmail.com" && p_no == "9721745673") 
            {
                ViewBag.message = "Successful";
            }
            else
            {
                ViewBag.message = "not successful";
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