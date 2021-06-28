using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace KFD1.Controllers
{
    public class LoginController : Controller
    {
        //Context c = new Context();
        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }
        //public async Task<IActionResult> UserLogin2(Kullanicilar p)
        //{
        //    var hesaplar = c.Kullanicilars.Firstofdefault(x => x.Kullanici == prop.Kullanici && x.Sifre == prop.Sifre);
        //    if (hesaplar != null)
        //    {
        //        //işlemler
        //    }
        //    return View();
        //}
    }
}
