using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }

        public IActionResult CoolingSystems()
        {
            return View();
        }

        public IActionResult Memory()
        {
            return View();
        }

        public IActionResult Motherboards()
        {
            return View();
        }

        public IActionResult PowerSupply()
        {
            return View();
        }

        public IActionResult Processors()
        {
            return View();
        }

        public IActionResult SoundCards()
        {
            return View();
        }

        public IActionResult VideoCards()
        {
            return View();
        }
    }
}
