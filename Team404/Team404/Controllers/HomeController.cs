using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Team404.Models;

namespace Team404.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpPost] //Processed when calling the 'Post' method
        public IActionResult Contact(ContactFM formModel)
        {
            //Validate Form Data
            if (string.IsNullOrWhiteSpace(formModel.ContactMessage))
            {
                return View();
            }
            return Redirect("ContactResponse");
        }

        public IActionResult ContactResponse ()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
