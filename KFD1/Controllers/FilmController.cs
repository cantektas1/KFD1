using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KFD1.Models;
using Microsoft.AspNetCore.Mvc;

namespace KFD1.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            return View(FilmRepository.Filmler);
        }
    }
}
