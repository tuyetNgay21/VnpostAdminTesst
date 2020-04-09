using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using vnpost.Models;

namespace vnpost.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult TrangChu()
        {
            return View();
        }       
    }
}
