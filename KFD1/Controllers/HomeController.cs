using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KFD1.Models;

namespace KFD1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(FilmRepository.Filmler);
        }
        public IActionResult Detaylar(int id)
        {
            return View(FilmRepository.Filmler.FirstOrDefault(i => i.Id == id));
        }
    }
}
