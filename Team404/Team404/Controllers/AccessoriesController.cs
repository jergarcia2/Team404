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
    public class AccessoriesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Adapter()
        {
            AdaptersVM model = new AdaptersVM();
            AAdapters Item1 = new AAdapters();
            Item1.ItemTitle = "Item 1 Title Goes Here";
            Item1.ItemLink = "View Item Detials";
            Item1.MiniDescription.Add("UPC:xxxxxxxxx");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            model.AdaptersItems.Add(Item1);

            return View(model);
        }

        public IActionResult Chargers()
        {
            ChargersVM model = new ChargersVM();
            AChargers Item1 = new AChargers();
            Item1.ItemTitle = "Item 1 Title Goes Here";
            Item1.ItemLink = "View Item Detials";
            Item1.MiniDescription.Add("UPC:xxxxxxxxx");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            model.ChargersItems.Add(Item1);

            return View(model);
        }

        public IActionResult HeadPhones()
        {
            PhonesVM model = new PhonesVM();
            APhones Item1 = new APhones();
            Item1.ItemTitle = "Item 1 Title Goes Here";
            Item1.ItemLink = "View Item Detials";
            Item1.MiniDescription.Add("UPC:xxxxxxxxx");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            model.PhonesItems.Add(Item1);

            return View(model);
        }

        public IActionResult MiscCables()
        {
            MiscCablesVM model = new MiscCablesVM();
            AMiscCables Item1 = new AMiscCables();
            Item1.ItemTitle = "Item 1 Title Goes Here";
            Item1.ItemLink = "View Item Detials";
            Item1.MiniDescription.Add("UPC:xxxxxxxxx");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            model.MiscCableItems.Add(Item1);

            return View(model);
        }

        public IActionResult StorageDevices()
        {
            StorageDevicesVM model = new StorageDevicesVM();
            AStorageDevices Item1 = new AStorageDevices();
            Item1.ItemTitle = "Item 1 Title Goes Here";
            Item1.ItemLink = "View Item Detials";
            Item1.MiniDescription.Add("UPC:xxxxxxxxx");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            model.StorageDevicesItems.Add(Item1);

            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
