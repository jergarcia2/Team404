using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Team404.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Team404.Controllers
{
    public class BundlesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Beginner()
        {
			BeginnerVM model = new BeginnerVM();
			BeginnerBundles Bundle1 = new BeginnerBundles();
			Bundle1.BundleTitle = "Rockstar Bundle";
			Bundle1.BundleLink = "View Bundle Details";
			Bundle1.Wishlist = "Add to Wishlist";
			Bundle1.RemoveDetails = "Hide Details";
			Bundle1.BundlePrice = 514.97;
			Bundle1.ProductName1 = "i5-7600K";
			Bundle1.ProductName2 = "ASRock MB";
			Bundle1.ProductName3 = "16GB";
			Bundle1.MiniDescription1.Add("for product one");
			Bundle1.MiniDescription1.Add("for product one");
			Bundle1.MiniDescription1.Add("for product one");
			Bundle1.MiniDescription2.Add("for product two");
			Bundle1.MiniDescription2.Add("for product two");
			Bundle1.MiniDescription2.Add("for product two");
			Bundle1.MiniDescription3.Add("for product three");
			Bundle1.MiniDescription3.Add("for product three");
			Bundle1.MiniDescription3.Add("for product three");
			model.BeginnerItems.Add(Bundle1);

			return View(model);
        }

        public IActionResult MidGrade()
        {
			MidGradeVM model = new MidGradeVM();
			MidGradeBundles Bundle1 = new MidGradeBundles();
			Bundle1.BundleTitle = "Rockstar Bundle";
			Bundle1.BundleLink = "View Bundle Details";
			Bundle1.Wishlist = "Add to Wishlist";
			Bundle1.RemoveDetails = "Hide Details";
			Bundle1.BundlePrice = 514.97;
			Bundle1.ProductName1 = "i5-7600K";
			Bundle1.ProductName2 = "ASRock MB";
			Bundle1.ProductName3 = "16GB";
			Bundle1.MiniDescription1.Add("for product one");
			Bundle1.MiniDescription1.Add("for product one");
			Bundle1.MiniDescription1.Add("for product one");
			Bundle1.MiniDescription2.Add("for product two");
			Bundle1.MiniDescription2.Add("for product two");
			Bundle1.MiniDescription2.Add("for product two");
			Bundle1.MiniDescription3.Add("for product three");
			Bundle1.MiniDescription3.Add("for product three");
			Bundle1.MiniDescription3.Add("for product three");

			model.MidGradeItems.Add(Bundle1);

			return View(model);
        }

        public IActionResult Professional()
        {
			ProfessionalVM model = new ProfessionalVM();
			ProfessionalBundles Bundle1 = new ProfessionalBundles();
			Bundle1.BundleTitle = "Rockstar Bundle";
			Bundle1.BundleLink = "View Bundle Details";
			Bundle1.Wishlist = "Add to Wishlist";
			Bundle1.RemoveDetails = "Hide Details";
			Bundle1.BundlePrice = 514.97;
			Bundle1.ProductName1 = "i5-7600K";
			Bundle1.ProductName2 = "ASRock MB";
			Bundle1.ProductName3 = "16GB";
			Bundle1.MiniDescription1.Add("for product one");
			Bundle1.MiniDescription1.Add("for product one");
			Bundle1.MiniDescription1.Add("for product one");
			Bundle1.MiniDescription2.Add("for product two");
			Bundle1.MiniDescription2.Add("for product two");
			Bundle1.MiniDescription2.Add("for product two");
			Bundle1.MiniDescription3.Add("for product three");
			Bundle1.MiniDescription3.Add("for product three");
			Bundle1.MiniDescription3.Add("for product three");
			model.ProfessionalItems.Add(Bundle1);

			return View(model);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
