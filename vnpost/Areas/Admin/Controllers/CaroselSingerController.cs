using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vnpost.Models.connectDB;
using vnpost.Models.Services;

namespace vnpost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CaroselSingerController : Controller
    {
        private readonly IIsNavSinger IThem;
        public CaroselSingerController(IIsNavSinger Them)
        {
            IThem = Them;
        }
        [Route("CaroselSinger")]
        public IActionResult Index(IsNavSinger The, int id)
        {
            if (id == 0)
            {
                if (The.NavbarSingerId == 0 && The.Title != null && The.ImageSinger != null && The.LinkImage != null)
                {
                    IThem.Add(The);
                }
                else if (The.NavbarSingerId != 0 && The.Title != null && The.ImageSinger != null && The.LinkImage != null)
                {
                    IThem.Edit(The);
                }
                else
                {

                }
            }
            else
            {
                The = IThem.GetOne(id);
            }
            ViewBag.AllTheme = IThem.GetAll();
            return View(The);
        }
        [Route("DeleteNavAdmin")]
        public IActionResult DeleteThemeAdmin(int id)
        {
            IThem.Delete(id);
            return Redirect("CaroselSinger");
        }
        [HttpPost]
        public JsonResult UpLoadCKEditor(IFormFile upload)
        {
            var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + upload.FileName;
            var file = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ImagePost", fileName);
            upload.CopyToAsync(new FileStream(file, FileMode.Create));
            return Json("ImagePost/" + fileName);
        }
    }
}