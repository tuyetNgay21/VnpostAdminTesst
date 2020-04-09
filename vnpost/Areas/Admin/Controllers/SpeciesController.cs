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
    public class SpeciesController : Controller
    {
        private readonly IIsSpecies IThem;
        public SpeciesController(IIsSpecies Them)
        {
            IThem = Them;
        }
        [Route("LoaiChuDe")]
        public IActionResult Index(IsSpecies The, int id)
        {
            if (id == 0)
            {
                if (The.SpeciesId == 0 && The.IsTitle != null && The.Isname != null && The.AvatarSpecies != null)
                {
                    IThem.Add(The);
                }
                else if (The.SpeciesId != 0 && The.IsTitle != null && The.Isname != null && The.AvatarSpecies != null)
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
            ViewBag.AllLoaiChuDe = IThem.GetAll();
            ViewBag.AllTheme = IThem.GetAllTheme();
            return View(The);
        }
        [Route("DeleteLoaiChuDeAdmin")]
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
            return Json("ImagePost/" + fileName);
        }
    }
}