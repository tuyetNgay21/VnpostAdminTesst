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
    public class ThemeController : Controller
    {
        private readonly IIsTheme IThem;
        public  ThemeController(IIsTheme Them)
        {
            IThem = Them;
        }
        [Route("ThemeAdmin")]
        public IActionResult Index(IsTheme The, int id)
        {
            if(id==0)
            {
                if (The.ThemeId==0&&The.IsTitle != null&& The.Isname!=null&&The.AvatarTheme!=null)
                {
                    IThem.Add(The);
                }
                else if(The.ThemeId != 0 && The.IsTitle != null && The.Isname != null && The.AvatarTheme != null)
                {
                    IThem.Edit(The);
                }
                else
                {
                   
                }
            }
            else
            {
                The= IThem.GetOne(id);
            }
            ViewBag.AllTheme = IThem.GetAll();
            return View(The);
        }
        [Route("DeleteThemeAdmin")]
        public IActionResult DeleteThemeAdmin(int id)
        {
            IThem.Delete(id);
            return Redirect("ThemeAdmin");
        }
        [HttpPost]
        public JsonResult UpLoadCKEditor(IFormFile upload)
        {
            var fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + upload.FileName;
            var file = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/ImagePost", fileName);
            upload.CopyToAsync(new FileStream(file, FileMode.Create));
            return Json("ImagePost/"+fileName);
        }
    }
}