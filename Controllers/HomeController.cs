using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DBcontext _context;

        public HomeController(ILogger<HomeController> logger, DBcontext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.data = _context.Dbdata.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult savedata(Dbdata Dbdata)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(Dbdata);
                    _context.SaveChanges();
                    ViewBag.Message = "Saved successfully";
                }
                catch(Exception ex)
                {
                    ViewBag.Message = "There is an error";
                }
               
            }
            return View("index");
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
