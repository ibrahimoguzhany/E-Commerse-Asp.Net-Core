using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace CoreIntro_0.Controllers
{
    public class HomeController : Controller
    {
        //Code First icin Entity Framework Core kütüphanesini manage nuget'tan indirmeyi unutmayın...

        //Migrations'i yapabilmek ve terminal komutlarını yazabilmek icin de özellikle EntityFramework Core tools gerekir...
        //Migration terminal komuatlari =>

        public IActionResult Login()
        {
            return View();
        }

    }

    
}
