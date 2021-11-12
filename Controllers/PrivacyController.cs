using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPratico_1.Controllers
{
    public class PrivacyController : Controller
    {
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
