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


        [HttpPost] //Processed when calling the 'Post' method
        public IActionResult SignIn(SignInFM form)
        {
            //Validate Form Data

            return Redirect("SignInResponse");
        }

        public IActionResult SignInResponse()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }



        public IActionResult WishList()
        {

			WishlistVM model = new WishlistVM();
			Wishlist Item1 = new Wishlist();
			Wishlist Item2 = new Wishlist();
			Item1.ItemNames = "Product 1";
			Item1.LinkRemove = "Delete";
			Item1.Undo = "Undo";
			Item1.Prices1 = 80;
			Item1.Prices2 = 75;
			Item1.Prices3 = 70;
			model.ListItems.Add(Item1);
			Item2.ItemNames = "Product 2";
			Item2.LinkRemove = "Delete";
			Item2.Undo = "Undo";
			Item2.Prices1 = 80;
			Item2.Prices2 = 75;
			Item2.Prices3 = 70;
			model.ListItems.Add(Item2);


			return View(model);
        }

        public IActionResult Contact()
        {

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

        public IActionResult ContactResponse()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
