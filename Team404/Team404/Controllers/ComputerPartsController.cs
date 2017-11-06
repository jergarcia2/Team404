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
    public class ComputerPartsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cases()
        {
            CasesVM model = new CasesVM();
            CPCases Item1 = new CPCases();
            Item1.ItemTitle = "DIYPC Skyline-06-WG Black/Green Dual USB 3.0 ATX Full Tower Gaming Computer Case";
            Item1.ItemLink = "View Item Details";
			Item1.Price1Name = "Newegg";
			Item1.Price2Name = "Amazon";
			Item1.ItemPrice = 87.99;
			Item1.ItemPrice2 = 107.01;
            Item1.MiniDescription.Add("Steel ATX Full Tower");
            Item1.MiniDescription.Add("Hot Swap Docking");
            Item1.MiniDescription.Add("Built in Green LED Fans: 5mm x 120mm");
			Item1.LongDescription.Add("Full black interior, Intel TAC 2.0");
			Item1.LongDescription.Add("Advanced cable management design ");
			Item1.LongDescription.Add("Advanced Bottom-Mounted PSU Design ");
			Item1.LongDescription.Add("Top mounted IO ports - 2x USB 3.0 for up-to-date high speed data transfer ");
			Item1.LongDescription.Add("Top-mounted HDD hot swap docking station provides superb file transfer  ");
			Item1.LongDescription.Add("Screw-less design for 5.25 Devices & 3.5 HDDs");
			Item1.LongDescription.Add("Front panel dust-proof mesh design; dust filter on top/bottom panel");
			Item1.LongDescription.Add("8 PCI slots provide flexibility for multiple graphics cards solutions.");
			Item1.Wishlist = "Add to Wishlist";
			Item1.RemoveDetails = "Hide Details";


			model.CasesItems.Add(Item1);

            return View(model);
        }

        public IActionResult CoolingSystems()
        {
            CoolingSystemsVM model = new CoolingSystemsVM();
            CPCoolingSystems Item1 = new CPCoolingSystems();
            Item1.ItemTitle = "Item 1 Title Goes Here";
            Item1.ItemLink = "View Item Details";
            Item1.MiniDescription.Add("UPC:xxxxxxxxx");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            model.CoolingSystemItems.Add(Item1);

            return View(model);
        }

        public IActionResult Memory()
        {
            MemoryVM model = new MemoryVM();
            CPMemory Item1 = new CPMemory();
            Item1.ItemTitle = "Item 1 Title Goes Here";
            Item1.ItemLink = "View Item Details";
            Item1.MiniDescription.Add("UPC:xxxxxxxxx");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            model.MemoryItems.Add(Item1);

            return View(model);
        }

        public IActionResult Motherboards()
        {
            MotherboardVM model = new MotherboardVM();
            CPMotherboard Item1 = new CPMotherboard();
            Item1.ItemTitle = "Item 1 Title Goes Here";
            Item1.ItemLink = "View Item Details";
            Item1.MiniDescription.Add("UPC:xxxxxxxxx");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            model.MotherboardItems.Add(Item1);

            return View(model);
        }

        public IActionResult PowerSupply()
        {
            PowerSupplyVM model = new PowerSupplyVM();
            CPPowerSupply Item1 = new CPPowerSupply();
            Item1.ItemTitle = "Item 1 Title Goes Here";
            Item1.ItemLink = "View Item Details";
            Item1.MiniDescription.Add("UPC:xxxxxxxxx");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            model.PowerSupplyItems.Add(Item1);

            return View(model);
        }

        public IActionResult Processors()
        {
            ProcessorsVM model = new ProcessorsVM();
            CPProcessors Item1 = new CPProcessors();
            Item1.ItemTitle = "Item 1 Title Goes Here";
            Item1.ItemLink = "View Item Details";
            Item1.MiniDescription.Add("UPC:xxxxxxxxx");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            model.ProcessorsItems.Add(Item1);

            return View(model);
        }

        public IActionResult SoundCards()
        {
            SoundCardsVM model = new SoundCardsVM();
            CPSoundCards Item1 = new CPSoundCards();
            Item1.ItemTitle = "Item 1 Title Goes Here";
            Item1.ItemLink = "View Item Details";
            Item1.MiniDescription.Add("UPC:xxxxxxxxx");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            model.SoundCardsItems.Add(Item1);

            return View(model);
        }

        public IActionResult VideoCards()
        {
            VideoCardsVM model = new VideoCardsVM();
            CPVideoCards Item1 = new CPVideoCards();
            Item1.ItemTitle = "Item 1 Title Goes Here";
            Item1.ItemLink = "View Item Details";
            Item1.MiniDescription.Add("UPC:xxxxxxxxx");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            model.VideoCardsItems.Add(Item1);

            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
