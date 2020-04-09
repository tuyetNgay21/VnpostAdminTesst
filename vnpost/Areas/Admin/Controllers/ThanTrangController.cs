using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace vnpost.Areas.Admin.Controllers
{
    public class ThanTrangController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}