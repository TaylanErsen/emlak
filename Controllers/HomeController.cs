using emlak.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace emlak.Controllers
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
        [HttpGet]
        public ViewResult MusteriKayit()
        {
            return View();
        }

        [HttpPost]
        public ViewResult MusteriKayit(Musteri MusteriBilgileri)
        {
            if(ModelState.IsValid)
            {

                Repository.MusteriEkle(MusteriBilgileri);
                return View("Tesekkurler", MusteriBilgileri);
            }

            else
            {
                return View();
            }
           
        }

        public ViewResult MusterileriListele()
        {
            return View(Repository.MusteriBilgisi);
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
