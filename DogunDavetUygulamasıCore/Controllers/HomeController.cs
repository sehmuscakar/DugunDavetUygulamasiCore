﻿using DogunDavetUygulamasıCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DogunDavetUygulamasıCore.Controllers
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
        public ViewResult CevapFormu()
        {
            return View();
        }
        [HttpPost]
        public ViewResult CevapFormu(Cevap KatilimciCevapi)
        {
            if (ModelState.IsValid)//Eğer validsyon kontroleri doğruysa bu işlemleri yap
            {
                Repository.CevapEkle(KatilimciCevapi);

                return View("Tesekkurler", KatilimciCevapi);
            }

            else
            {
                return View();
            }
        }

        public ViewResult CevaplariListele()
        {
            return View(Repository.Cevaplar.Where(x => x.DuguneGelecekmi == true));
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
