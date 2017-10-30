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
            Item1.ItemTitle = "Item 1 Title Goes Here";
            Item1.ItemLink = "View Item Details";
            Item1.MiniDescription.Add("UPC:xxxxxxxxx");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
            Item1.MiniDescription.Add("Bullet goes here");
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
